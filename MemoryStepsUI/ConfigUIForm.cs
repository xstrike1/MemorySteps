using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStepsUI
{
    public partial class Form1 : Form
    {
        private int numberOfSteps = 1;
        public Form1()
        {
            InitializeComponent();
        }

        TextBox textBox1;
        Button btnAddStep;
        Button btnRemoveStep;
        Button btnLaunchTest;
        Label lblConfig;
        Label lblS1;
        private Label label1;
        private TextBox tbReps;
        private Label lblTComp;
        private Label lblTstCompSec;
        CheckBox ckbS1;

        private void InitializeComponent()
        {
            this.lblConfig = new System.Windows.Forms.Label();
            this.btnAddStep = new System.Windows.Forms.Button();
            this.btnRemoveStep = new System.Windows.Forms.Button();
            this.btnLaunchTest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblS1 = new System.Windows.Forms.Label();
            this.ckbS1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbReps = new System.Windows.Forms.TextBox();
            this.lblTComp = new System.Windows.Forms.Label();
            this.lblTstCompSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfig.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConfig.Location = new System.Drawing.Point(33, 9);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(92, 21);
            this.lblConfig.TabIndex = 0;
            this.lblConfig.Text = "Test Config";
            // 
            // btnAddStep
            // 
            this.btnAddStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddStep.Location = new System.Drawing.Point(468, 59);
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(120, 60);
            this.btnAddStep.TabIndex = 1;
            this.btnAddStep.Text = "Add step";
            this.btnAddStep.UseVisualStyleBackColor = true;
            this.btnAddStep.Click += new System.EventHandler(this.btnAddStep_Click);
            // 
            // btnRemoveStep
            // 
            this.btnRemoveStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoveStep.Location = new System.Drawing.Point(468, 139);
            this.btnRemoveStep.Name = "btnRemoveStep";
            this.btnRemoveStep.Size = new System.Drawing.Size(120, 60);
            this.btnRemoveStep.TabIndex = 1;
            this.btnRemoveStep.Text = "Remove step";
            this.btnRemoveStep.UseVisualStyleBackColor = true;
            this.btnRemoveStep.Click += new System.EventHandler(this.btnRemoveStep_Click);
            // 
            // btnLaunchTest
            // 
            this.btnLaunchTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaunchTest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLaunchTest.Location = new System.Drawing.Point(468, 217);
            this.btnLaunchTest.Name = "btnLaunchTest";
            this.btnLaunchTest.Size = new System.Drawing.Size(120, 60);
            this.btnLaunchTest.TabIndex = 1;
            this.btnLaunchTest.Text = "Launch test";
            this.btnLaunchTest.UseVisualStyleBackColor = true;
            this.btnLaunchTest.Click += new System.EventHandler(this.btnLaunchTest_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(91, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Launch Application";
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblS1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblS1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblS1.Location = new System.Drawing.Point(12, 61);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(54, 21);
            this.lblS1.TabIndex = 0;
            this.lblS1.Text = "Step 1";
            // 
            // ckbS1
            // 
            this.ckbS1.AutoSize = true;
            this.ckbS1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ckbS1.Location = new System.Drawing.Point(339, 61);
            this.ckbS1.Name = "ckbS1";
            this.ckbS1.Size = new System.Drawing.Size(62, 19);
            this.ckbS1.TabIndex = 3;
            this.ckbS1.Text = "Repeat";
            this.ckbS1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ckbS1.UseVisualStyleBackColor = true;
            this.ckbS1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reps";
            // 
            // tbReps
            // 
            this.tbReps.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbReps.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbReps.Location = new System.Drawing.Point(91, 96);
            this.tbReps.Name = "tbReps";
            this.tbReps.Size = new System.Drawing.Size(228, 23);
            this.tbReps.TabIndex = 2;
            this.tbReps.Text = "5";
            // 
            // lblTComp
            // 
            this.lblTComp.AutoSize = true;
            this.lblTComp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTComp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTComp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTComp.Location = new System.Drawing.Point(237, 9);
            this.lblTComp.Name = "lblTComp";
            this.lblTComp.Size = new System.Drawing.Size(168, 21);
            this.lblTComp.TabIndex = 0;
            this.lblTComp.Text = "Test completion time:";
            lblTComp.Visible = false;
            // 
            // lblTstCompSec
            // 
            this.lblTstCompSec.AutoSize = true;
            this.lblTstCompSec.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTstCompSec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTstCompSec.ForeColor = System.Drawing.Color.Lime;
            this.lblTstCompSec.Location = new System.Drawing.Point(407, 9);
            this.lblTstCompSec.Name = "lblTstCompSec";
            this.lblTstCompSec.Size = new System.Drawing.Size(19, 21);
            this.lblTstCompSec.TabIndex = 0;
            this.lblTstCompSec.Text = "#";
            lblTstCompSec.Visible = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 413);
            this.Controls.Add(this.ckbS1);
            this.Controls.Add(this.tbReps);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLaunchTest);
            this.Controls.Add(this.btnRemoveStep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddStep);
            this.Controls.Add(this.lblTstCompSec);
            this.Controls.Add(this.lblTComp);
            this.Controls.Add(this.lblS1);
            this.Controls.Add(this.lblConfig);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        Stack<StepEntity> steps = new Stack<StepEntity>();

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            numberOfSteps++;
            if (numberOfSteps > 6)
                this.Size = new Size(616, this.Size.Height + 50);

            StepEntity entity = new StepEntity(numberOfSteps);
            this.Controls.Add(entity.StepIsReccursive);
            this.Controls.Add(entity.StepLabel);
            this.Controls.Add(entity.StepDescriptionTxt);
            steps.Push(entity);

        }

        private void btnRemoveStep_Click(object sender, EventArgs e)
        {
            if (numberOfSteps > 6)
                this.Size = new Size(616, this.Size.Height - 50);
            numberOfSteps--;

            StepEntity entity = steps.Pop();
            this.Controls.Remove(entity.StepIsReccursive);
            this.Controls.Remove(entity.StepLabel);
            this.Controls.Remove(entity.StepDescriptionTxt);
        }

        private void btnLaunchTest_Click(object sender, EventArgs e)
        {
            TestForm form = new TestForm(this, int.Parse(tbReps.Text), ConverToList());
            form.TopMost = true;
            form.Show();
            this.Hide();
        }

        private List<StepEntity> ConverToList() 
        {
            List<StepEntity> entityList = new List<StepEntity>();
            foreach (StepEntity entity in steps) 
            {
                entityList.Add(entity);
            }

            return entityList;
        }
        public void CompleteTest(string time) 
        {
            lblTstCompSec.Visible = true;
            lblTstCompSec.Text = time;
            lblTComp.Visible = true;
        }
    }
}
