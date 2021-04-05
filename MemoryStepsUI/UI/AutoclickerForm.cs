using Gma.System.MouseKeyHook;
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class AutoclickerForm : MaterialForm, IFormWithCancelRequest
    {
        public bool CancelHasBeenRequested { get; set; }
        private IKeyboardMouseEvents m_GlobalHook;
        private ConfigUIForm _parent;
        private CursorExecutorService _executor;
        private decimal _totalDuration;
        private decimal _elapsedTime;

        public AutoclickerForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.DeepPurple200, TextShade.WHITE);
            this.Icon = Properties.Resources.logo;
        }

        public AutoclickerForm(ConfigUIForm parent, CursorExecutorService executor, long totalDuration) 
            : this() 
        {
            _parent = parent;
            _executor = executor;
            _totalDuration = totalDuration;
            TopLevel = true;
            lblHint.Text = $"To cancel current execution press {parent.CompleteTestKeyBind}";
            Rectangle res = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(res.Width - Size.Width, res.Height - Size.Height);
            Subscribe();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Unsubscribe();
        }

        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.KeyPress += GlobalHookKeyPress;
            _executor.StepCompleted += _executor_StepCompleted;
        }

        private void _executor_StepCompleted(long currentStepDuration)
        {
            _elapsedTime += currentStepDuration;
            progressBar.Value = Convert.ToInt32(_elapsedTime / _totalDuration * 100);
            lblProgressVal.Text = progressBar.Value + "%";
            Application.DoEvents();
        }

        public void Unsubscribe()
        {
            if (m_GlobalHook == null)
                return;

            m_GlobalHook.KeyPress -= GlobalHookKeyPress;
            _executor.StepCompleted -= _executor_StepCompleted;

            m_GlobalHook.Dispose();
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == _parent.CompleteTestKeyBind)
            {
                Unsubscribe();
                e.Handled = true;
                CancelHasBeenRequested = true;
                lblHint.Text = "Execution canceled by user";
            }
        }
    }
}
