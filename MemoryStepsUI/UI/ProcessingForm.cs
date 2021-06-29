using Gma.System.MouseKeyHook;
using MaterialSkin.Controls;
using MemoryStepsCore.Services;
using MemoryStepsUI.Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using MemoryStepsUI.Properties;
using MemoryStepsCore.Models;
using MemoryStepsCore.Config;
using MaterialSkin;

namespace MemoryStepsUI.UI
{
    public partial class ProcessingForm : MaterialForm, IMemoryProcessingForm
    {
        public bool CancelHasBeenRequested { get; set; }
        private IKeyboardMouseEvents _globalHook;
        private readonly MainForm _parent;
        private CursorExecutorService _executor;
        private decimal _totalDuration;
        private decimal _elapsedTime;

        public ProcessingForm()
        {
            InitializeComponent();

            FormStyleService.InitMaterialSkin(this);
        }

        /// <summary>
        /// Constructor used for manual configuration
        /// </summary>
        public ProcessingForm(MainForm parent)
            : this()
        {
            _parent = parent;
            Hide();
        }

        public void ShowFormOnExecute(CursorExecutorService executor, long totalDuration)
        {
            lblHint.Text = string.Format(Resources.CaptionCancelCurrentExecutionFormat, AppConfig.Config.KeyBind.ToString());
            _executor = executor;
            _totalDuration = totalDuration;
            progressBar.Visible = true;
            lblCurrentProgress.Visible = true;
            lblProgressVal.Visible = true;
            cursorControlCurrent.Visible = true;
            cursorControlNext.Visible = true;
            Height = 157;
            CancelHasBeenRequested = false;
            _elapsedTime = 0;

            Subscribe();
            Show();
            SetWindowLocation();
        }

        public void ShowFormOnRegister() 
        {
            lblHint.Text = string.Format(Resources.CaptionCancelCurrentExecutionFormat, AppConfig.Config.KeyBind.ToString());
            Height = 57;
            CancelHasBeenRequested = false;
            cursorControlCurrent.Visible = false;
            cursorControlNext.Visible = false;
            Show();
            SetWindowLocation();
        }

        public void UnsubscribeAndHide() 
        {
            Unsubscribe();
            Hide();
        }


        private void SetWindowLocation() 
        {
            Rectangle res = Screen.PrimaryScreen.Bounds;
            Location = new Point(res.Width - Size.Width, res.Height - Size.Height);
        }

      
        private void Subscribe()
        {
            _globalHook = GlobalHookService.SubscribeGlobalHook(GlobalHookKeyPress);
        }

        private void Unsubscribe()
        {
            GlobalHookService.UnsubscribeGlobalHook(_globalHook, GlobalHookKeyPress);
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != AppConfig.Config.KeyBind)
                return;

            Unsubscribe();
            e.Handled = true;
            CancelHasBeenRequested = true;
            lblHint.Text = Resources.CaptionExecutionCanceledByUser;
            this.Hide();
            _parent.Show();
        }

        public void Executor_StepCompleted(long currentDuration, CursorEntity currentCursor, CursorEntity nextCursor)
        {
            _elapsedTime += currentDuration;
            progressBar.Value = Convert.ToInt32(_elapsedTime / _totalDuration * 100);
            lblProgressVal.Text = $"{progressBar.Value}%";
            SetCardsValues(currentCursor, nextCursor);
            Application.DoEvents();
        }

        private void SetCardsValues(CursorEntity currentCursor, CursorEntity nextCursor) 
        {
            cursorControlCurrent.InitCursorAction(currentCursor, true, nextCursor == null);

            if (nextCursor == null)
            {
                cursorControlNext.Visible = false;
                return;
            }
            cursorControlNext.InitCursorAction(nextCursor, true, true);
        }

        public void SendKey(string value) 
        {
            SendKeys.Send(value);
        }
    }
}
