using Gma.System.MouseKeyHook;
using MaterialSkin.Controls;
using MemoryStepsUI.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MemoryStepsUI.Models;

namespace MemoryStepsUI.UI
{
    public partial class MainForm : MaterialForm
    {
        public CursorRegisterService cursorRegister = new();
        private IKeyboardMouseEvents _globalHook;
        private CursorLoaderService _cursorLoader = new();
        private CursorExecutorService _executor;
        public readonly char CompleteTestKeyBind = AppConfig.KeyBind;
        private AutoclickerForm autoclickerF;

        public MainForm()
        {
            InitializeComponent();
            FormStyleService.InitMaterialSkin(this);
        }

        public void CompleteTest(string timeElapsed)
        {
            lblTstCompSec.Visible = true;
            lblTstCompSec.Text = timeElapsed;
            lblTestComp.Visible = true;
        }

        public void Subscribe()
        {
            _globalHook = GlobalHookService.Instance.SubscribeGlobalHook(GlobalHookKeyPress, GlobalHook_MouseClick);
        }

        public void Unsubscribe()
        {
            GlobalHookService.Instance.UnsubscribeGlobalHook(_globalHook, GlobalHookKeyPress, GlobalHook_MouseClick);

            cursorRegister.StopLastCursorTimer(true);
            autoclickerF.Close();
            autoclickerF.Dispose();
            this.Show();
            rtbAutoclickerCurrentConfig.Text = _cursorLoader.GetCurrentConfig(cursorRegister.TestConfig);
        }

        private void LaunchAutoclicker()
        {
            Application.DoEvents();
            this.Hide();

            _executor = new CursorExecutorService(cursorRegister);
            
            CompleteTest(_executor.Execute(this).ToString());
        }

        private void ValidateBeforeTestLaunch()
        {
            if (string.IsNullOrEmpty(rtbAutoclickerCurrentConfig.Text))
                throw new ApplicationException("Invalid autoclicker configuration");

            return;
        }

        private void GlobalHook_MouseClick(object sender, MouseEventArgs e)
        {
            cursorRegister.RegisterMouseButtonClick(e.Location, e.Button);
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == CompleteTestKeyBind)
            {
                AutomationService.StopTimer();
                Unsubscribe();
                e.Handled = true;
                SetTestFields(true);
                return;
            }

            cursorRegister.RegisterKeyPress(e.KeyChar);
            e.Handled = true;
        }

        private void btnLaunchTest_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateBeforeTestLaunch();
                LaunchAutoclicker();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStartManualConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutomationService.StartTimer();
            cursorRegister.TestConfig.CursorList = new List<CursorEntity>();
            autoclickerF = new AutoclickerForm(this)
            {
                TopMost = true
            };
            autoclickerF.Show();
            Subscribe();
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            cursorRegister.TestConfig = _cursorLoader.LoadConfig();
            rtbAutoclickerCurrentConfig.Text = _cursorLoader.GetCurrentConfig(cursorRegister.TestConfig);
            SetTestFields();
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            _cursorLoader.SaveConfig(cursorRegister.TestConfig);
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
            cursorRegister.TestConfig.TestName = txtBoxTestName.Text;
        }

        private void txtBoxTestDescr_TextChanged(object sender, EventArgs e)
        {
            cursorRegister.TestConfig.TestDescription = txtBoxTestDescr.Text;
        }
    }
}
