﻿using Gma.System.MouseKeyHook;
using MaterialSkin.Controls;
using MemoryStepsUI.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MemoryStepsCore.Models;
using MemoryStepsCore.Services;
using MemoryStepsCore.Config;
using MemoryStepsUI.Controls;
using System.Threading;

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
            processingForm = new ProcessingForm(this)
            {
                TopMost = true
            };

            _executor = new CursorExecutorService();
        }

        public IMemoryProcessingForm ShowProcessingFormOnExecute(IMemoryMainForm mainForm, CursorExecutorService cursorExecutor, long totalDuration)
        {
            processingForm.ShowFormOnExecute(_executor, totalDuration);
            return processingForm;
        }

        public void CloseProcessingForm()
        {
            processingForm.UnsubscribeAndHide();
            this.Show();
        }

        public void CompleteTest(string timeElapsed) //Unused atm
        {
            lblTstCompSec.Visible = true;
            lblTstCompSec.Text = timeElapsed;
            lblTestComp.Visible = true;
        }

        public void DisplayMessage(string message, string caption = "") 
        {
            MaterialMessageBox.Show(message, caption, false);
        }

        private void LaunchAutoclicker()
        {
            Application.DoEvents();
            Hide();

            _executor.Execute(cursorRegister, this);
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
            if (!ValidateCursor())
                return;

            try
            {
                LaunchAutoclicker();
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message, "Error");
                CloseProcessingForm();
            }
        }

        private bool ValidateCursor()
        {
            if (cursorRegister.TestConfig.CursorList == null || cursorRegister.TestConfig.CursorList.Count == 0)
                return false;

            return true;
        }

        private void ShowProcessingForm(IMemoryMainForm mainForm) 
        {
            Hide();
            processingForm.ShowFormOnRegister();
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

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
             _cursorLoader.SaveConfig(cursorRegister.TestConfig); 
        }

        int lastLocation = 0;

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
