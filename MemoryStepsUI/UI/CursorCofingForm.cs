using Gma.System.MouseKeyHook;
using MemoryStepsUI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStepsUI.UI
{
    public partial class CursorCofingForm : Form
    {
        private ConfigUIForm _parent;
        private IKeyboardMouseEvents m_GlobalHook;
        bool subscribed;
        public CursorCofingForm()
        {
            InitializeComponent();
        }
        public CursorCofingForm(ConfigUIForm parent) 
        :this()
        {
            _parent = parent;
            rtbStatus.Text = $"To configure mouse positions + keys press \"{btnStartConfig.Text}\". {Environment.NewLine} To stop configuration press {_parent.CompleteTestKeyBind}.";

        }

        private void btnStartConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            _parent.cursorRegister.ResetList();
            Subscribe();
        }

        protected override void OnClosed(EventArgs e)
        {
            Unsubscribe();
            base.OnClosed(e);
            _parent.Show();
        }

        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();
            
            m_GlobalHook.KeyPress += GlobalHookKeyPress;
            m_GlobalHook.MouseClick += GlobalHook_MouseClick;
            subscribed = true;
        }

        public void Unsubscribe()
        {
            if (m_GlobalHook == null)
                return;

            m_GlobalHook.KeyPress -= GlobalHookKeyPress;
            m_GlobalHook.MouseClick -= GlobalHook_MouseClick;

            _parent.cursorRegister.StopLastCursorTimewatch();
            m_GlobalHook.Dispose();
            subscribed = false;
            this.Show();
        }

        private void GlobalHook_MouseClick(object sender, MouseEventArgs e)
        {
            _parent.cursorRegister.RegisterMouseButtonClick(e.Location, e.Button);
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
      {
            if (e.KeyChar == _parent.CompleteTestKeyBind)
            {
                Unsubscribe();
                e.Handled = true;
                return;
            }

            _parent.cursorRegister.RegisterKeyPress(e.KeyChar);
            e.Handled = true;
        }

        private void btnStartClick_Click(object sender, EventArgs e)
        {
            if (subscribed)
            {
                Unsubscribe();
                _parent.cursorRegister.CursorList.RemoveAt(_parent.cursorRegister.CursorList.Count - 1);
            }
            
            CursorExecutorService executor = new CursorExecutorService(_parent.cursorRegister);
            executor.Execute();
        }

    }
}
