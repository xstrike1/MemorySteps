using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;


namespace MemoryStepsUI
{
    public partial class TestForm : Form
    {

        private int numberOfRepeats;
        private Queue<StepEntity> queue;
        private Stopwatch timer;

        private IKeyboardMouseEvents m_GlobalHook;
        private Button btnCloseForm;
        private Button btnCompleteStep;
        private Label label1;
        private Label lblStepNumber;
        private RichTextBox rtbDescription;
        private Label lblTestCompleted;
        private Label label2;
        private Label lblRepRem;
        private Form1 _parent;
 
        public TestForm()
        {
            InitializeComponent();
            Subscribe();


        }
        public TestForm(Form1 parent, int numOfRep, List<StepEntity> stack)
            :this()
        {
            _parent = parent;
            numberOfRepeats = numOfRep + 1;
            if (stack.Count == 0 || numOfRep == 0)
                TestCompleted();
            else
            {
                ProcessStack(stack);
                CompleteStep();
            }
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
            var entity = queue.Dequeue();

            if (entity.StepNumber == 2)
                numberOfRepeats--;

            if (numberOfRepeats == 0)
            {
                TestCompleted();
                return;
            }

            lblRepRem.Text = numberOfRepeats.ToString();

            lblStepNumber.Text = entity.StepNumber.ToString();
            rtbDescription.Text = entity.StepDescriptionTxt.Text;

            queue.Enqueue(entity);
        }

        private void TestCompleted()
        {
            lblRepRem.Visible = false;
            lblStepNumber.Visible = false;
            rtbDescription.Visible = false;
            btnCompleteStep.Visible = false;
            lblTestCompleted.Visible = true;
            label1.Visible = true;
            label2.Visible = true;

            if (timer is not null)
                timer.Stop();

            _parent.CompleteTest(timer.Elapsed.ToString());
            Unsubscribe();
            this.Close();
        }

        private void InitializeComponent()
        {
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnCompleteStep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStepNumber = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblTestCompleted = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRepRem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseForm.Location = new System.Drawing.Point(246, 273);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(145, 66);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Text = "Close";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnCompleteStep
            // 
            this.btnCompleteStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteStep.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCompleteStep.Location = new System.Drawing.Point(44, 273);
            this.btnCompleteStep.Name = "btnCompleteStep";
            this.btnCompleteStep.Size = new System.Drawing.Size(145, 66);
            this.btnCompleteStep.TabIndex = 0;
            this.btnCompleteStep.Text = "Complete step";
            this.btnCompleteStep.UseVisualStyleBackColor = true;
            this.btnCompleteStep.Click += new System.EventHandler(this.btnCompleteStep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Step";
            // 
            // lblStepNumber
            // 
            this.lblStepNumber.AutoSize = true;
            this.lblStepNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStepNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStepNumber.Location = new System.Drawing.Point(75, 33);
            this.lblStepNumber.Name = "lblStepNumber";
            this.lblStepNumber.Size = new System.Drawing.Size(19, 21);
            this.lblStepNumber.TabIndex = 1;
            this.lblStepNumber.Text = "#";
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbDescription.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rtbDescription.Location = new System.Drawing.Point(44, 83);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(319, 141);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            // 
            // lblTestCompleted
            // 
            this.lblTestCompleted.AutoSize = true;
            this.lblTestCompleted.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTestCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTestCompleted.Location = new System.Drawing.Point(12, 54);
            this.lblTestCompleted.Name = "lblTestCompleted";
            this.lblTestCompleted.Size = new System.Drawing.Size(387, 65);
            this.lblTestCompleted.TabIndex = 3;
            this.lblTestCompleted.Text = "Test COMPLETED";
            this.lblTestCompleted.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(225, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reps remaining";
            // 
            // lblRepRem
            // 
            this.lblRepRem.AutoSize = true;
            this.lblRepRem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRepRem.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRepRem.Location = new System.Drawing.Point(347, 33);
            this.lblRepRem.Name = "lblRepRem";
            this.lblRepRem.Size = new System.Drawing.Size(19, 21);
            this.lblRepRem.TabIndex = 1;
            this.lblRepRem.Text = "#";
            // 
            // TestForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(427, 371);
            this.Controls.Add(this.lblTestCompleted);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblStepNumber);
            this.Controls.Add(this.lblRepRem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompleteStep);
            this.Controls.Add(this.btnCloseForm);
            this.KeyPreview = true;
            this.Name = "TestForm";
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


        public void Subscribe()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.KeyPress += GlobalHookKeyPress;
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '`') 
            {
                e.Handled = true;
                btnCompleteStep.PerformClick();
            }
        }

      
        public void Unsubscribe()
        {
            m_GlobalHook.KeyPress -= GlobalHookKeyPress;

            //It is recommened to dispose it
            m_GlobalHook.Dispose();
        }

        private void btnCompleteStep_Click(object sender, EventArgs e)
        {
            if (timer is null)
            {
                timer = new Stopwatch();
                timer.Start();
            }
            CompleteStep();
        }
    }
}
