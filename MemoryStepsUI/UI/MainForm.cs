using Gma.System.MouseKeyHook;
using MaterialSkin;
using MaterialSkin.Controls;
using MemoryStepsUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStepsUI.UI
{
    public partial class MainForm : MaterialForm
    {
        public CursorRegisterService cursorRegister = new CursorRegisterService();
        private IKeyboardMouseEvents _globalHook;
        private CursorLoaderService _cursorLoader = new CursorLoaderService();
        private CursorExecutorService _executor;
        public readonly char CompleteTestKeyBind = '`';
        private AutoclickerForm autoclickerF;

        public MainForm()
        {
            InitializeComponent();
            FormStyleService.InitMaterialSkin(this);
        }

        public void CompleteTest(string time)
        {
            lblTstCompSec.Visible = true;
            lblTstCompSec.Text = time;
            lblTestComp.Visible = true;
        }

        private void btnLaunchTest_Click(object sender, EventArgs e)
        {
            ValidateBeforeTestLaunch();
            LaunchAutoclicker();
        }

        private void ValidateBeforeTestLaunch()
        {
            if (string.IsNullOrEmpty(rtbAutoclickerCurrentConfig.Text))
                throw new ApplicationException("Invalid autoclicker configuration");

            return;
        }

        public void Subscribe()
        {
            _globalHook = GlobalHookService.Instance.SubscribeGlobalHook(GlobalHookKeyPress, GlobalHook_MouseClick);
        }

        public void Unsubscribe()
        {
            GlobalHookService.Instance.UnsubscribeGlobalHook(_globalHook, GlobalHookKeyPress, GlobalHook_MouseClick);

            cursorRegister.StopLastCursorTimewatch(true);
            autoclickerF.Hide();
            autoclickerF.Dispose();
            this.Show();
            rtbAutoclickerCurrentConfig.Text = _cursorLoader.GetCurrentConfig(cursorRegister.CursorList);
        }

        private void GlobalHook_MouseClick(object sender, MouseEventArgs e)
        {
            cursorRegister.RegisterMouseButtonClick(e.Location, e.Button);
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == CompleteTestKeyBind)
            {
                Unsubscribe();
                e.Handled = true;
                return;
            }

            cursorRegister.RegisterKeyPress(e.KeyChar);
            e.Handled = true;
        }

        private void btnStartManualConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            cursorRegister.ResetList();
            autoclickerF = new AutoclickerForm(this)
            {
                TopMost = true
            };
            autoclickerF.Show();
            Subscribe();
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            cursorRegister.LoadList(_cursorLoader.LoadConfig());
            rtbAutoclickerCurrentConfig.Text = _cursorLoader.GetCurrentConfig(cursorRegister.CursorList);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            _cursorLoader.SaveConfig(cursorRegister.CursorList);
        }

        private void LaunchAutoclicker()
        {
            Application.DoEvents();
            this.Hide();

            _executor = new CursorExecutorService(cursorRegister);
            Stopwatch timer = new Stopwatch();

            timer.Start();
            _executor.Execute(this);
            timer.Stop();

            CompleteTest(timer.Elapsed.ToString());
        }
    }
}
