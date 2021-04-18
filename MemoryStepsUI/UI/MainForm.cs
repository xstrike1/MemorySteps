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
        private IKeyboardMouseEvents m_GlobalHook;
        private CursorLoaderService _cursorLoader = new CursorLoaderService();
        private CursorExecutorService _executor;
        public readonly char CompleteTestKeyBind = '`';
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

        //private void switchTheme_CheckedChanged(object sender, EventArgs e)
        //{
        //    var materialSkinManager = MaterialSkinManager.Instance;

        //    if (switchTheme.Checked)
        //        materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        //    else
        //        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        //}

        //private void txtBoxKeybind_TextChanged(object sender, EventArgs e)
        //{
        //    CompleteTestKeyBind = txtBoxKeybind.Text[0];
        //}

        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.KeyPress += GlobalHookKeyPress;
            m_GlobalHook.MouseClick += GlobalHook_MouseClick;
        }

        public void Unsubscribe()
        {
            if (m_GlobalHook == null)
                return;

            m_GlobalHook.KeyPress -= GlobalHookKeyPress;
            m_GlobalHook.MouseClick -= GlobalHook_MouseClick;

            cursorRegister.StopLastCursorTimewatch(true);
            m_GlobalHook.Dispose();
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

        private AutoclickerForm autoclickerF;
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
