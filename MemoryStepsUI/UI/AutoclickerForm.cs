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
    public partial class AutoclickerForm : Form
    {
        private IKeyboardMouseEvents m_GlobalHook;
        private ConfigUIForm _parent;
        CursorExecutorService executor;
        public AutoclickerForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        public AutoclickerForm(ConfigUIForm parent) 
            :this()
        {
            _parent = parent;
            lblHint.Text = $"To stop the autoclicker press {_parent.CompleteTestKeyBind}";
            executor = new CursorExecutorService(_parent.cursorRegister);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _parent.Show();
        }

        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyPress += GlobalHookKeyPress;
            executor.ExecutionCompleted += Executor_ExecutionCompleted;

        }

        private void Executor_ExecutionCompleted(bool status)
        {
            if (status)
            {
                StopAutoclicker();
            }
        }

        public void Unsubscribe()
        {
            if (m_GlobalHook == null)
                return;

            m_GlobalHook.KeyPress -= GlobalHookKeyPress;
            executor.ExecutionCompleted -= Executor_ExecutionCompleted;
            
            m_GlobalHook.Dispose();
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == _parent.CompleteTestKeyBind)
            {
                StopAutoclicker(); //TODO: call Executor cancel

                e.Handled = true;
                return;
            }

        }

        private void StopAutoclicker() 
        {
            Unsubscribe();
            this.Close();
        }

        private void btnStartAutoclicker_Click(object sender, EventArgs e)
        {
            Rectangle res = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(res.Width - Size.Width, res.Height - Size.Height);
            Subscribe();
            executor.Execute();

            btnStartAutoclicker.Visible = false;
            btnExit.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            StopAutoclicker();
        }
    }
}
