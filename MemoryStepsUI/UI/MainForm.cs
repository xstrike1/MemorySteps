using Gma.System.MouseKeyHook;
using MaterialSkin.Controls;
using MemoryStepsUI.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MemoryStepsCore.Models;
using MemoryStepsCore.Services;
using MemoryStepsCore.Config;
using MemoryStepsUI.Controls;

namespace MemoryStepsUI.UI
{
    public partial class MainForm : MaterialForm, IMemoryMainForm
    {
        public CursorRegisterService cursorRegister = new();
        private readonly CursorLoaderService _cursorLoader = new();
        private CursorExecutorService _executor;
        private ProcessingForm processingForm;
        public MainForm()
        {
            InitializeComponent();
            FormStyleService.InitMaterialSkin(this);
            cursorRegister.OnRegisterFinish += OnRegisterComplete;
        }

        public IMemoryProcessingForm CreateProcessingForm(IMemoryMainForm mainForm, CursorExecutorService cursorExecutor, long totalDuration)
        {
            processingForm = new ProcessingForm(this, cursorExecutor, totalDuration)
            {
                TopMost = true
            };
            return processingForm;
        }

        public void CloseProcessingForm()
        {
            this.Show();
            if (processingForm == null)
                return;

            processingForm.Close();
            processingForm.Dispose();
        }

        public void CompleteTest(string timeElapsed)
        {
            lblTstCompSec.Visible = true;
            lblTstCompSec.Text = timeElapsed;
            lblTestComp.Visible = true;
        }

        private void LaunchAutoclicker()
        {
            Application.DoEvents();
            Hide();

            _executor = new CursorExecutorService(cursorRegister);

            CompleteTest(_executor.Execute(this).ToString());
        }

        public void OnRegisterComplete() 
        {
            SetTestFields(true);
            CloseProcessingForm();
            UpdatePanelConfig();
            cursorEditorControl1.Visible = false;
        }

        private void btnLaunchTest_Click(object sender, EventArgs e)
        {
            try
            {
                LaunchAutoclicker();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                CloseProcessingForm();
            }
        }

        private void ShowProcessingForm(IMemoryMainForm mainForm) 
        {
            processingForm = new ProcessingForm(this)
            {
                TopMost = true
            };
            Hide();
            processingForm.Show();
        }

        private void btnStartManualConfig_Click(object sender, EventArgs e)
        {
            AutomationService.StartTimer();
            ShowProcessingForm(this);
            cursorRegister.StartCursorRegister();
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            cursorRegister.TestConfig = _cursorLoader.LoadConfig();
            if (cursorRegister.TestConfig == null)
                return;

            SetTestFields();
            UpdatePanelConfig();
        }

        int lastLocation = 0;
        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
             _cursorLoader.SaveConfig(cursorRegister.TestConfig); 
        }

        private void UpdatePanelConfig() 
        {
            lastLocation = 0;

            foreach (CursorControl ctrl in pnlCurrentConfig.Controls)
            {
                ctrl.CardClicked -= CardClicked;
                ctrl.Dispose();
            }

            pnlCurrentConfig.Controls.Clear();

            for (int i = 0; i < cursorRegister.TestConfig.CursorList.Count; i++)
            {
                CursorControl cc = new CursorControl();
                cc.Width -= 120;
                bool isLastElement = i == cursorRegister.TestConfig.CursorList.Count - 1;
                cc.InitCursorAction(cursorRegister.TestConfig.CursorList[i], isLastElement: isLastElement);
                cc.Location = new System.Drawing.Point(10, lastLocation + cc.Height);
                if (isLastElement)
                    cc.Height -= 80;
                pnlCurrentConfig.Controls.Add(cc);
                cc.CardClicked += CardClicked;
            }
        }

        private void CardClicked(CursorControl cc)
        {
            cursorEditorControl1.Visible = true;
            cursorEditorControl1.EditCursor(cc);
        }

        private void SetTestFields(bool manualConfig = false) 
        {
            txtTestDuration.Text = cursorRegister.TestConfig.TotalDuration.ToString();
            txtNumberOfClicks.Text = cursorRegister.TestConfig.NumberOfClicks.ToString();
            txtNumberOfCharacters.Text = cursorRegister.TestConfig.NumberOfCharacters.ToString();

            if (manualConfig)
                return;

            txtBoxTestName.Text = cursorRegister.TestConfig.TestName;
            txtBoxTestDescr.Text = cursorRegister.TestConfig.TestDescription;
        }

        private void txtBoxTestName_TextChanged(object sender, EventArgs e)
        {
            if (cursorRegister.TestConfig == null)
                return;

            cursorRegister.TestConfig.TestName = txtBoxTestName.Text;
        }

        private void txtBoxTestDescr_TextChanged(object sender, EventArgs e)
        {
            if (cursorRegister.TestConfig == null)
                return;

            cursorRegister.TestConfig.TestDescription = txtBoxTestDescr.Text;
        }
    }
}
