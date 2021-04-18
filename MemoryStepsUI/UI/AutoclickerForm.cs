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
using MemoryStepsUI.Properties;

namespace MemoryStepsUI.UI
{
    public partial class AutoclickerForm : MaterialForm, IFormWithCancelRequest
    {
        public bool CancelHasBeenRequested { get; set; }
        private IKeyboardMouseEvents _globalHook;
        private MainForm _parent;
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

        public AutoclickerForm(MainForm parent) 
            :this()
        {
            _parent = parent;
            lblHint.Text = string.Format(Resources.AutoclickerForm_AutoclickerForm_To_cancel_current_execution_press__0_, parent.CompleteTestKeyBind.ToString());
            Rectangle res = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(res.Width - Size.Width, res.Height - Size.Height);

        }

        public AutoclickerForm(MainForm parent, CursorExecutorService executor, long totalDuration) 
            : this(parent) 
        {
            _executor = executor;
            _totalDuration = totalDuration;
            progressBar.Visible = true;
            btnExit.Visible = true;
            lblCurrentProgress.Visible = true;
            lblProgressVal.Visible = true;

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
            _globalHook = GlobalHookService.Instance.SubscribeGlobalHook(GlobalHookKeyPress);
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
            GlobalHookService.Instance.UnsubscribeGlobalHook(_globalHook, GlobalHookKeyPress);
            _executor.StepCompleted -= _executor_StepCompleted;
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != _parent.CompleteTestKeyBind)
                return;

            Unsubscribe();
            e.Handled = true;
            CancelHasBeenRequested = true;
            lblHint.Text = "Execution canceled by user";
        }
    }
}
