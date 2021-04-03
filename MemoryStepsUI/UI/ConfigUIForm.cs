using MemoryStepsUI.Services;
using MemoryStepsUI.UI;
using Microsoft.Test.Input;
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
    public partial class ConfigUIForm : Form
    {
        private int numberOfSteps = 0;
        private Button btnAddStep;
        private Button btnRemoveStep;
        private Button btnLaunchTest;
        private Label lblConfig;
        private Label lblRepsText;
        private TextBox tbRepsTextBox;
        private Label lblTComp;
        private Label lblKeyBind;
        private TextBox txtBoxKeybind;
        private Label lblTstCompSec;
        Stack<StepEntity> steps;
        private Button btnAutoclickerConfig;
        private Button btnStartAutoclicker;
        private CheckBox chkMouse;
        public char CompleteTestKeyBind;
        public CursorRegisterService cursorRegister;

        public ConfigUIForm()
        {
            InitializeComponent();
            CompleteTestKeyBind = '`';
            txtBoxKeybind.Text = CompleteTestKeyBind.ToString();
            steps = new Stack<StepEntity>();
            cursorRegister = new CursorRegisterService();
        }

        private void InitializeComponent()
        {
            this.lblConfig = new System.Windows.Forms.Label();
            this.btnAddStep = new System.Windows.Forms.Button();
            this.btnRemoveStep = new System.Windows.Forms.Button();
            this.btnLaunchTest = new System.Windows.Forms.Button();
            this.lblRepsText = new System.Windows.Forms.Label();
            this.tbRepsTextBox = new System.Windows.Forms.TextBox();
            this.lblTComp = new System.Windows.Forms.Label();
            this.lblTstCompSec = new System.Windows.Forms.Label();
            this.lblKeyBind = new System.Windows.Forms.Label();
            this.txtBoxKeybind = new System.Windows.Forms.TextBox();
            this.btnAutoclickerConfig = new System.Windows.Forms.Button();
            this.btnStartAutoclicker = new System.Windows.Forms.Button();
            this.chkMouse = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblConfig
            // 
            this.lblConfig.AutoSize = true;
            this.lblConfig.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfig.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConfig.Location = new System.Drawing.Point(11, 9);
            this.lblConfig.Name = "lblConfig";
            this.lblConfig.Size = new System.Drawing.Size(144, 21);
            this.lblConfig.TabIndex = 0;
            this.lblConfig.Text = "Test Configuration";
            // 
            // btnAddStep
            // 
            this.btnAddStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddStep.Location = new System.Drawing.Point(575, 78);
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
            this.btnRemoveStep.Location = new System.Drawing.Point(575, 144);
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
            this.btnLaunchTest.Location = new System.Drawing.Point(575, 342);
            this.btnLaunchTest.Name = "btnLaunchTest";
            this.btnLaunchTest.Size = new System.Drawing.Size(120, 60);
            this.btnLaunchTest.TabIndex = 1;
            this.btnLaunchTest.Text = "Launch test";
            this.btnLaunchTest.UseVisualStyleBackColor = true;
            this.btnLaunchTest.Click += new System.EventHandler(this.btnLaunchTest_Click);
            // 
            // lblRepsText
            // 
            this.lblRepsText.AutoSize = true;
            this.lblRepsText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRepsText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRepsText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRepsText.Location = new System.Drawing.Point(11, 61);
            this.lblRepsText.Name = "lblRepsText";
            this.lblRepsText.Size = new System.Drawing.Size(46, 21);
            this.lblRepsText.TabIndex = 0;
            this.lblRepsText.Text = "Reps";
            // 
            // tbRepsTextBox
            // 
            this.tbRepsTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbRepsTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRepsTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbRepsTextBox.Location = new System.Drawing.Point(91, 59);
            this.tbRepsTextBox.Name = "tbRepsTextBox";
            this.tbRepsTextBox.Size = new System.Drawing.Size(56, 27);
            this.tbRepsTextBox.TabIndex = 2;
            this.tbRepsTextBox.Text = "5";
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
            this.lblTComp.Visible = false;
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
            this.lblTstCompSec.Visible = false;
            // 
            // lblKeyBind
            // 
            this.lblKeyBind.AutoSize = true;
            this.lblKeyBind.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKeyBind.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKeyBind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKeyBind.Location = new System.Drawing.Point(153, 62);
            this.lblKeyBind.Name = "lblKeyBind";
            this.lblKeyBind.Size = new System.Drawing.Size(182, 21);
            this.lblKeyBind.TabIndex = 0;
            this.lblKeyBind.Text = "Complete step KeyBind";
            // 
            // txtBoxKeybind
            // 
            this.txtBoxKeybind.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxKeybind.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxKeybind.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBoxKeybind.Location = new System.Drawing.Point(350, 59);
            this.txtBoxKeybind.MaxLength = 1;
            this.txtBoxKeybind.Name = "txtBoxKeybind";
            this.txtBoxKeybind.Size = new System.Drawing.Size(56, 27);
            this.txtBoxKeybind.TabIndex = 2;
            this.txtBoxKeybind.TextChanged += new System.EventHandler(this.txtBoxKeybind_TextChanged);
            // 
            // btnAutoclickerConfig
            // 
            this.btnAutoclickerConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoclickerConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAutoclickerConfig.Location = new System.Drawing.Point(575, 210);
            this.btnAutoclickerConfig.Name = "btnAutoclickerConfig";
            this.btnAutoclickerConfig.Size = new System.Drawing.Size(120, 60);
            this.btnAutoclickerConfig.TabIndex = 3;
            this.btnAutoclickerConfig.Text = "Autoclicker config";
            this.btnAutoclickerConfig.UseVisualStyleBackColor = true;
            this.btnAutoclickerConfig.Click += new System.EventHandler(this.btnAutoclickerConfig_Click);
            // 
            // btnStartAutoclicker
            // 
            this.btnStartAutoclicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAutoclicker.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartAutoclicker.Location = new System.Drawing.Point(575, 276);
            this.btnStartAutoclicker.Name = "btnStartAutoclicker";
            this.btnStartAutoclicker.Size = new System.Drawing.Size(120, 60);
            this.btnStartAutoclicker.TabIndex = 3;
            this.btnStartAutoclicker.Text = "Start Autoclicker";
            this.btnStartAutoclicker.UseVisualStyleBackColor = true;
            this.btnStartAutoclicker.Click += new System.EventHandler(this.btnStartAutoclicker_Click);
            // 
            // chkMouse
            // 
            this.chkMouse.AutoSize = true;
            this.chkMouse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMouse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkMouse.ForeColor = System.Drawing.SystemColors.Control;
            this.chkMouse.Location = new System.Drawing.Point(412, 61);
            this.chkMouse.Name = "chkMouse";
            this.chkMouse.Size = new System.Drawing.Size(152, 25);
            this.chkMouse.TabIndex = 4;
            this.chkMouse.Text = "Use mouse clicks";
            this.chkMouse.UseVisualStyleBackColor = true;
            this.chkMouse.CheckedChanged += new System.EventHandler(this.chkMouse_CheckedChanged);
            // 
            // ConfigUIForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(707, 414);
            this.Controls.Add(this.chkMouse);
            this.Controls.Add(this.btnStartAutoclicker);
            this.Controls.Add(this.btnAutoclickerConfig);
            this.Controls.Add(this.txtBoxKeybind);
            this.Controls.Add(this.tbRepsTextBox);
            this.Controls.Add(this.btnLaunchTest);
            this.Controls.Add(this.btnRemoveStep);
            this.Controls.Add(this.lblKeyBind);
            this.Controls.Add(this.lblRepsText);
            this.Controls.Add(this.btnAddStep);
            this.Controls.Add(this.lblTstCompSec);
            this.Controls.Add(this.lblTComp);
            this.Controls.Add(this.lblConfig);
            this.MinimumSize = new System.Drawing.Size(616, 0);
            this.Name = "ConfigUIForm";
            this.Text = "Memory steps 1.11 Alpha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            numberOfSteps++;
            if (numberOfSteps > 6)
                this.Size = new Size(this.Size.Width, this.Size.Height + 50);

            StepEntity entity = new StepEntity(numberOfSteps, chkMouse.Checked);
            foreach (var control in entity.GetControlListForConfig()) 
            {
                this.Controls.Add(control);
            }

            steps.Push(entity);
        }

        private void btnRemoveStep_Click(object sender, EventArgs e)
        {
            if (numberOfSteps == 0)
                return; 

            if (numberOfSteps > 6)
                this.Size = new Size(this.Size.Width, this.Size.Height - 50);
            numberOfSteps--;

            StepEntity entity = steps.Pop();
            foreach (var control in entity.GetControlListForConfig())
            {
                this.Controls.Remove(control);
            }
        }

        private void btnLaunchTest_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbRepsTextBox.Text, out int numberOfReps))
                throw new ApplicationException("Invalid number of reps value");

            TestForm testForm = new TestForm(this, numberOfReps, ConvertEntityStackToList(), chkMouse.Checked)
            {
                TopMost = true //always in focus
            };

            if (testForm.IsDisposed) //int value < 0
                return;

            testForm.Show();
            this.Hide();
        }

        private List<StepEntity> ConvertEntityStackToList() 
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

        private void txtBoxKeybind_TextChanged(object sender, EventArgs e)
        {
            CompleteTestKeyBind = txtBoxKeybind.Text[0];
        }

        private void btnStartAutoclicker_Click(object sender, EventArgs e)
        {
            this.Hide();

            AutoclickerForm autoclicker = new AutoclickerForm(this);
            autoclicker.Show();
        }

        private void btnAutoclickerConfig_Click(object sender, EventArgs e)
        {
            this.Hide();

            CursorCofingForm cursorConfig = new CursorCofingForm(this);
            cursorConfig.Show();
            
        }

        private void chkMouse_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxKeybind.Enabled = !chkMouse.Checked;

            foreach (var entity in steps) 
            {
                entity.MouseClicksChanged(chkMouse.Checked);
            }
        }
    }
}
