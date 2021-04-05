using Gma.System.MouseKeyHook;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;


namespace MemoryStepsUI
{
    public partial class TestForm : MaterialForm
    {
        private int numberOfRepeats;
        private Queue<StepEntity> queue;
        private Stopwatch timer;
        private IKeyboardMouseEvents m_GlobalHook;
        private ConfigUIForm _parent;
        private bool _useMouse;
        private int _clicksThisSession;
        private StepEntity _currentProcessingEntity;
        private MaterialLabel lblStep;
        private MaterialLabel lblStepNumber;
        private MaterialLabel lblRepsRemaining;
        private MaterialLabel lblRepRem;
        private MaterialMultiLineTextBox rtbDescription;
        private MaterialLabel lblDesc;
        private MaterialButton btnCompleteStep;
        private MaterialButton btnClose;
        private bool _formIsLoading;

        public TestForm()
        {
            _formIsLoading = true;
            InitializeComponent();
            _clicksThisSession = 0;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.DeepPurple200, TextShade.WHITE);
            this.Icon = Properties.Resources.logo;
        }

        public TestForm(ConfigUIForm parent, int numOfRep, List<StepEntity> stack, bool useMouse)
            :this()
        {
            _parent = parent;
            numberOfRepeats = numOfRep +1;
            _useMouse = useMouse;

            if (stack.Count <= 1 || numOfRep <= 1)
            {
                TestCompleted();
                return;
            }

          
            Subscribe(useMouse);
            ProcessStack(stack);
            CompleteStep();

            if (useMouse)
            {
                CompleteMouseStep();
                btnCompleteStep.Text = "Start test";
            }

            _formIsLoading = false;
        }

        private void ProcessStack(List<StepEntity> list) 
        {
            queue = new Queue<StepEntity>();
            for(int i=list.Count - 1 ; i >= 0; i--)
            {
                queue.Enqueue(list[i]);
            }
        }

        private void CompleteStep()
        {
            _currentProcessingEntity = queue.Dequeue();

            if (_currentProcessingEntity.StepNumber == 1) //decrement only first step
                numberOfRepeats--;

            if (numberOfRepeats == 0)
            {
                TestCompleted();
                return;
            }

            lblRepRem.Text = numberOfRepeats.ToString();

            lblStepNumber.Text = _currentProcessingEntity.StepNumber.ToString();
            rtbDescription.Text = _currentProcessingEntity.StepDescription;
            queue.Enqueue(_currentProcessingEntity);
        }

        private void CompleteMouseStep() 
        {
            //if (int.Parse(_currentProcessingEntity.MouseClicks) - _clicksThisSession == 0)
            //{
            //    _clicksThisSession = 0;
            //    CompleteStep();
            //}

            //lblClicksRemainingNumber.Text = (int.Parse(_currentProcessingEntity.MouseClicks) - _clicksThisSession).ToString();
        }

        private void TestCompleted()
        {
            lblRepRem.Visible = false;
            lblStepNumber.Visible = false;
            rtbDescription.Visible = false;
            btnCompleteStep.Visible = false;

            if (timer is not null)
            {
                timer.Stop();
                _parent.CompleteTest(timer.Elapsed.ToString());
            }

            Unsubscribe();

            this.Close();
        }

        private void InitializeComponent()
        {
            this.lblStep = new MaterialSkin.Controls.MaterialLabel();
            this.lblStepNumber = new MaterialSkin.Controls.MaterialLabel();
            this.lblRepsRemaining = new MaterialSkin.Controls.MaterialLabel();
            this.lblRepRem = new MaterialSkin.Controls.MaterialLabel();
            this.rtbDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lblDesc = new MaterialSkin.Controls.MaterialLabel();
            this.btnCompleteStep = new MaterialSkin.Controls.MaterialButton();
            this.btnClose = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Depth = 0;
            this.lblStep.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStep.Location = new System.Drawing.Point(28, 74);
            this.lblStep.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(33, 19);
            this.lblStep.TabIndex = 3;
            this.lblStep.Text = "Step";
            // 
            // lblStepNumber
            // 
            this.lblStepNumber.AutoSize = true;
            this.lblStepNumber.Depth = 0;
            this.lblStepNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStepNumber.Location = new System.Drawing.Point(67, 74);
            this.lblStepNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStepNumber.Name = "lblStepNumber";
            this.lblStepNumber.Size = new System.Drawing.Size(11, 19);
            this.lblStepNumber.TabIndex = 4;
            this.lblStepNumber.Text = "#";
            // 
            // lblRepsRemaining
            // 
            this.lblRepsRemaining.AutoSize = true;
            this.lblRepsRemaining.Depth = 0;
            this.lblRepsRemaining.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRepsRemaining.Location = new System.Drawing.Point(193, 74);
            this.lblRepsRemaining.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRepsRemaining.Name = "lblRepsRemaining";
            this.lblRepsRemaining.Size = new System.Drawing.Size(155, 19);
            this.lblRepsRemaining.TabIndex = 5;
            this.lblRepsRemaining.Text = "Repetitions remaining";
            // 
            // lblRepRem
            // 
            this.lblRepRem.AutoSize = true;
            this.lblRepRem.Depth = 0;
            this.lblRepRem.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRepRem.Location = new System.Drawing.Point(354, 74);
            this.lblRepRem.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRepRem.Name = "lblRepRem";
            this.lblRepRem.Size = new System.Drawing.Size(11, 19);
            this.lblRepRem.TabIndex = 6;
            this.lblRepRem.Text = "#";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Depth = 0;
            this.rtbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtbDescription.Hint = "";
            this.rtbDescription.Location = new System.Drawing.Point(28, 139);
            this.rtbDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(351, 142);
            this.rtbDescription.TabIndex = 7;
            this.rtbDescription.Text = "";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Depth = 0;
            this.lblDesc.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDesc.Location = new System.Drawing.Point(28, 117);
            this.lblDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(115, 19);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Step description";
            // 
            // btnCompleteStep
            // 
            this.btnCompleteStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCompleteStep.Depth = 0;
            this.btnCompleteStep.DrawShadows = true;
            this.btnCompleteStep.HighEmphasis = true;
            this.btnCompleteStep.Icon = null;
            this.btnCompleteStep.Location = new System.Drawing.Point(28, 323);
            this.btnCompleteStep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCompleteStep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCompleteStep.Name = "btnCompleteStep";
            this.btnCompleteStep.Size = new System.Drawing.Size(136, 36);
            this.btnCompleteStep.TabIndex = 9;
            this.btnCompleteStep.Text = "Complete step";
            this.btnCompleteStep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCompleteStep.UseAccentColor = false;
            this.btnCompleteStep.UseVisualStyleBackColor = true;
            this.btnCompleteStep.Click += new System.EventHandler(this.btnCompleteStep_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.Depth = 0;
            this.btnClose.DrawShadows = true;
            this.btnClose.HighEmphasis = true;
            this.btnClose.Icon = null;
            this.btnClose.Location = new System.Drawing.Point(313, 323);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 36);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClose.UseAccentColor = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TestForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(399, 376);
            this.Controls.Add(this.lblRepsRemaining);
            this.Controls.Add(this.btnCompleteStep);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblStepNumber);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblRepRem);
            this.KeyPreview = true;
            this.Name = "TestForm";
            this.Text = "Test body";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _parent.Show();
            Unsubscribe();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Subscribe(bool Use)
        {
            m_GlobalHook = Hook.GlobalEvents();
            if(!_useMouse)
                m_GlobalHook.KeyPress += GlobalHookKeyPress;

          
        }

        private void GlobalHook_MouseClick(object sender, MouseEventArgs e)
        {
            if (_formIsLoading)
                return;

            _clicksThisSession++;
            CompleteMouseStep();
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == _parent.CompleteTestKeyBind) 
            {
                if (_useMouse)
                    _clicksThisSession--;
                else
                    btnCompleteStep.PerformClick();

                e.Handled = true;
            }
        }

        public void Unsubscribe()
        {
            if (m_GlobalHook == null)
                return;
            if (!_useMouse)
                m_GlobalHook.KeyPress -= GlobalHookKeyPress;
            else
                m_GlobalHook.MouseClick -= GlobalHook_MouseClick;

            m_GlobalHook.Dispose();
        }


        private void btnCompleteStep_Click(object sender, EventArgs e)
        {
            if (timer is null)
            {
                timer = new Stopwatch();
                timer.Start();

                if (_useMouse)
                {
                    m_GlobalHook.MouseClick += GlobalHook_MouseClick;
                    btnCompleteStep.Visible = false;
                    return;
                }
            }

            CompleteStep();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
