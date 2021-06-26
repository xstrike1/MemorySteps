﻿using Gma.System.MouseKeyHook;
using MaterialSkin.Controls;
using MemoryStepsCore.Services;
using MemoryStepsUI.Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using MemoryStepsUI.Properties;
using MemoryStepsCore.Models;
using MemoryStepsCore.Config;

namespace MemoryStepsUI.UI
{
    public partial class ProcessingForm : MaterialForm, IMemoryProcessingForm
    {
        public bool CancelHasBeenRequested { get; set; }
        private IKeyboardMouseEvents _globalHook;
        private readonly MainForm _parent;
        private readonly CursorExecutorService _executor;
        private readonly decimal _totalDuration;
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
            :this()
        {
            _parent = parent;
            lblHint.Text = string.Format(Resources.CaptionCancelCurrentExecutionFormat, AppConfig.Config.KeyBind.ToString());
        }

        /// <summary>
        /// Constructor used for execution
        /// </summary>
        public ProcessingForm(MainForm parent, CursorExecutorService executor, long totalDuration) 
            : this(parent) 
        {
            _executor = executor;
            _totalDuration = totalDuration;
            progressBar.Visible = true;
            lblCurrentProgress.Visible = true;
            lblProgressVal.Visible = true;
            cardCurrent.Visible = true;
            cardNext.Visible = true;

            Subscribe();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Rectangle res = Screen.PrimaryScreen.Bounds;
            Location = new Point(res.Width - Size.Width, res.Height - Size.Height);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Unsubscribe();
        }

        private void Subscribe()
        {
            _globalHook = GlobalHookService.SubscribeGlobalHook(GlobalHookKeyPress);
            _executor.StepCompleted += _executor_StepCompleted;
           
        }

        private void Unsubscribe()
        {
            GlobalHookService.UnsubscribeGlobalHook(_globalHook, GlobalHookKeyPress);

            if (_executor == null)
                return;

            _executor.StepCompleted -= _executor_StepCompleted;
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

        private void _executor_StepCompleted(long currentStepDuration, long currentDuration, CursorEntity currentCursor, CursorEntity nextCursor)
        {
            _elapsedTime += currentStepDuration;
            progressBar.Value = Convert.ToInt32(_elapsedTime / _totalDuration * 100);
            lblProgressVal.Text = $"{progressBar.Value}%";
            SetCardsValues(currentDuration, currentCursor, nextCursor);
            Application.DoEvents();
        }

        private void SetCardsValues(long currentDuration, CursorEntity currentCursor, CursorEntity nextCursor) 
        {
            lblCurrentType.Text = currentCursor.ControlType;
            lblCurrentName.Text = currentCursor.ControlName;
            lblCurrentPos.Text = currentCursor.Position.ToString();
            lblCurrentDuration.Text = currentDuration.ToString() + " ms";
            lblCurrentCursorNumber.Text = currentCursor.CursorNumber.ToString();

            if (nextCursor == null)
            {
                cardNext.Visible = false;
                return;
            }

            lblNextType.Text = nextCursor.ControlType;
            lblNextName.Text =  nextCursor.ControlName;
            lblNextPos.Text =  nextCursor.Position.ToString();
            lblNextDuration.Text =  currentCursor.MilisecondsToNextCursor.ToString() + " ms";
        }
    }
}
