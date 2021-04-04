
using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class ConfigUIForm : MaterialForm
    {
        private int numberOfSteps = 0;
        private Label lblTComp;
        private Label lblTstCompSec;
        Stack<StepEntity> steps;
        public char CompleteTestKeyBind;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialTabControl materialTabControl1;
        private TabPage tabHome;
        private TabPage tabSettings;
        private IContainer components;
        internal ImageList icons_imageList;
        private TabPage tabAutoclicker;
        private MaterialLabel lblTestSummary;
        private CheckBox chkMouse;
        private TextBox txtBoxKeybind;
        private MaterialButton btnAddStep;
        private MaterialButton btnRemoveStp;
        private MaterialCard materialCard1;
        private MaterialButton btnLaunchTest;
        private Button btnAutoclickerConfig;
        private Button btnStartAutoclicker;
        private MaterialLabel lblRepsText;
        private MaterialTextBox tbRepsTextBox;
        public CursorRegisterService cursorRegister;

        public ConfigUIForm()
        {
            InitializeComponent();
            CompleteTestKeyBind = '`';
            txtBoxKeybind.Text = CompleteTestKeyBind.ToString();
            steps = new Stack<StepEntity>();
            cursorRegister = new CursorRegisterService();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.DeepPurple200, TextShade.WHITE);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigUIForm));
            this.lblTComp = new System.Windows.Forms.Label();
            this.lblTstCompSec = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tbRepsTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.lblRepsText = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnLaunchTest = new MaterialSkin.Controls.MaterialButton();
            this.btnAddStep = new MaterialSkin.Controls.MaterialButton();
            this.btnRemoveStp = new MaterialSkin.Controls.MaterialButton();
            this.lblTestSummary = new MaterialSkin.Controls.MaterialLabel();
            this.tabAutoclicker = new System.Windows.Forms.TabPage();
            this.btnStartAutoclicker = new System.Windows.Forms.Button();
            this.btnAutoclickerConfig = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.chkMouse = new System.Windows.Forms.CheckBox();
            this.txtBoxKeybind = new System.Windows.Forms.TextBox();
            this.icons_imageList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabAutoclicker.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTComp
            // 
            this.lblTComp.AutoSize = true;
            this.lblTComp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTComp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTComp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTComp.Location = new System.Drawing.Point(531, 34);
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
            this.lblTstCompSec.Location = new System.Drawing.Point(701, 34);
            this.lblTstCompSec.Name = "lblTstCompSec";
            this.lblTstCompSec.Size = new System.Drawing.Size(19, 21);
            this.lblTstCompSec.TabIndex = 0;
            this.lblTstCompSec.Text = "#";
            this.lblTstCompSec.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "444";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(458, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabHome);
            this.materialTabControl1.Controls.Add(this.tabAutoclicker);
            this.materialTabControl1.Controls.Add(this.tabSettings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.icons_imageList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 3);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(896, 573);
            this.materialTabControl1.TabIndex = 5;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.tbRepsTextBox);
            this.tabHome.Controls.Add(this.lblRepsText);
            this.tabHome.Controls.Add(this.materialCard1);
            this.tabHome.Controls.Add(this.lblTestSummary);
            this.tabHome.Controls.Add(this.lblTComp);
            this.tabHome.Controls.Add(this.lblTstCompSec);
            this.tabHome.ImageKey = "home_icon.png";
            this.tabHome.Location = new System.Drawing.Point(4, 39);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(888, 530);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tbRepsTextBox
            // 
            this.tbRepsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRepsTextBox.Depth = 0;
            this.tbRepsTextBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRepsTextBox.Location = new System.Drawing.Point(227, 91);
            this.tbRepsTextBox.MaxLength = 10;
            this.tbRepsTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.tbRepsTextBox.Multiline = false;
            this.tbRepsTextBox.Name = "tbRepsTextBox";
            this.tbRepsTextBox.Size = new System.Drawing.Size(100, 36);
            this.tbRepsTextBox.TabIndex = 11;
            this.tbRepsTextBox.Text = "";
            this.tbRepsTextBox.UseTallSize = false;
            // 
            // lblRepsText
            // 
            this.lblRepsText.AutoSize = true;
            this.lblRepsText.Depth = 0;
            this.lblRepsText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRepsText.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblRepsText.Location = new System.Drawing.Point(37, 108);
            this.lblRepsText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRepsText.Name = "lblRepsText";
            this.lblRepsText.Size = new System.Drawing.Size(154, 19);
            this.lblRepsText.TabIndex = 10;
            this.lblRepsText.Text = "Number of repetitions";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnLaunchTest);
            this.materialCard1.Controls.Add(this.btnAddStep);
            this.materialCard1.Controls.Add(this.btnRemoveStp);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(-45, 448);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(948, 68);
            this.materialCard1.TabIndex = 9;
            // 
            // btnLaunchTest
            // 
            this.btnLaunchTest.AutoSize = false;
            this.btnLaunchTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLaunchTest.Depth = 0;
            this.btnLaunchTest.DrawShadows = true;
            this.btnLaunchTest.HighEmphasis = true;
            this.btnLaunchTest.Icon = ((System.Drawing.Image)(resources.GetObject("btnLaunchTest.Icon")));
            this.btnLaunchTest.ImageKey = "(none)";
            this.btnLaunchTest.Location = new System.Drawing.Point(671, 12);
            this.btnLaunchTest.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLaunchTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLaunchTest.Name = "btnLaunchTest";
            this.btnLaunchTest.Size = new System.Drawing.Size(176, 36);
            this.btnLaunchTest.TabIndex = 8;
            this.btnLaunchTest.Text = "Launch test";
            this.btnLaunchTest.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLaunchTest.UseAccentColor = false;
            this.btnLaunchTest.UseVisualStyleBackColor = true;
            this.btnLaunchTest.Click += new System.EventHandler(this.btnLaunchTest_Click);
            // 
            // btnAddStep
            // 
            this.btnAddStep.AutoSize = false;
            this.btnAddStep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStep.Depth = 0;
            this.btnAddStep.DrawShadows = true;
            this.btnAddStep.HighEmphasis = true;
            this.btnAddStep.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddStep.Icon")));
            this.btnAddStep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStep.ImageKey = "(none)";
            this.btnAddStep.Location = new System.Drawing.Point(82, 12);
            this.btnAddStep.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddStep.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStep.Name = "btnAddStep";
            this.btnAddStep.Size = new System.Drawing.Size(152, 36);
            this.btnAddStep.TabIndex = 6;
            this.btnAddStep.Text = "Add step";
            this.btnAddStep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStep.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddStep.UseAccentColor = false;
            this.btnAddStep.UseVisualStyleBackColor = true;
            this.btnAddStep.Click += new System.EventHandler(this.btnAddStep_Click);
            // 
            // btnRemoveStp
            // 
            this.btnRemoveStp.AutoSize = false;
            this.btnRemoveStp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveStp.Depth = 0;
            this.btnRemoveStp.DrawShadows = true;
            this.btnRemoveStp.HighEmphasis = true;
            this.btnRemoveStp.Icon = ((System.Drawing.Image)(resources.GetObject("btnRemoveStp.Icon")));
            this.btnRemoveStp.Location = new System.Drawing.Point(256, 12);
            this.btnRemoveStp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemoveStp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveStp.Name = "btnRemoveStp";
            this.btnRemoveStp.Size = new System.Drawing.Size(175, 36);
            this.btnRemoveStp.TabIndex = 7;
            this.btnRemoveStp.Text = "Remove step";
            this.btnRemoveStp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemoveStp.UseAccentColor = false;
            this.btnRemoveStp.UseVisualStyleBackColor = true;
            this.btnRemoveStp.Click += new System.EventHandler(this.btnRemoveStp_Click);
            // 
            // lblTestSummary
            // 
            this.lblTestSummary.AutoSize = true;
            this.lblTestSummary.Depth = 0;
            this.lblTestSummary.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTestSummary.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTestSummary.Location = new System.Drawing.Point(38, 16);
            this.lblTestSummary.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTestSummary.Name = "lblTestSummary";
            this.lblTestSummary.Size = new System.Drawing.Size(153, 29);
            this.lblTestSummary.TabIndex = 5;
            this.lblTestSummary.Text = "Test summary";
            this.lblTestSummary.UseAccent = true;
            // 
            // tabAutoclicker
            // 
            this.tabAutoclicker.Controls.Add(this.btnStartAutoclicker);
            this.tabAutoclicker.Controls.Add(this.btnAutoclickerConfig);
            this.tabAutoclicker.ImageKey = "mouse_icon.png";
            this.tabAutoclicker.Location = new System.Drawing.Point(4, 39);
            this.tabAutoclicker.Name = "tabAutoclicker";
            this.tabAutoclicker.Size = new System.Drawing.Size(888, 530);
            this.tabAutoclicker.TabIndex = 2;
            this.tabAutoclicker.Text = "Autoclicker";
            this.tabAutoclicker.UseVisualStyleBackColor = true;
            // 
            // btnStartAutoclicker
            // 
            this.btnStartAutoclicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAutoclicker.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartAutoclicker.Location = new System.Drawing.Point(436, 341);
            this.btnStartAutoclicker.Name = "btnStartAutoclicker";
            this.btnStartAutoclicker.Size = new System.Drawing.Size(120, 60);
            this.btnStartAutoclicker.TabIndex = 5;
            this.btnStartAutoclicker.Text = "Start Autoclicker";
            this.btnStartAutoclicker.UseVisualStyleBackColor = true;
            // 
            // btnAutoclickerConfig
            // 
            this.btnAutoclickerConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoclickerConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAutoclickerConfig.Location = new System.Drawing.Point(384, 235);
            this.btnAutoclickerConfig.Name = "btnAutoclickerConfig";
            this.btnAutoclickerConfig.Size = new System.Drawing.Size(120, 60);
            this.btnAutoclickerConfig.TabIndex = 4;
            this.btnAutoclickerConfig.Text = "Autoclicker config";
            this.btnAutoclickerConfig.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.chkMouse);
            this.tabSettings.Controls.Add(this.txtBoxKeybind);
            this.tabSettings.ImageKey = "settings_icon.png";
            this.tabSettings.Location = new System.Drawing.Point(4, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(888, 530);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // chkMouse
            // 
            this.chkMouse.AutoSize = true;
            this.chkMouse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkMouse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkMouse.ForeColor = System.Drawing.SystemColors.Control;
            this.chkMouse.Location = new System.Drawing.Point(372, 329);
            this.chkMouse.Name = "chkMouse";
            this.chkMouse.Size = new System.Drawing.Size(152, 25);
            this.chkMouse.TabIndex = 5;
            this.chkMouse.Text = "Use mouse clicks";
            this.chkMouse.UseVisualStyleBackColor = true;
            // 
            // txtBoxKeybind
            // 
            this.txtBoxKeybind.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxKeybind.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxKeybind.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtBoxKeybind.Location = new System.Drawing.Point(361, 237);
            this.txtBoxKeybind.MaxLength = 1;
            this.txtBoxKeybind.Name = "txtBoxKeybind";
            this.txtBoxKeybind.Size = new System.Drawing.Size(56, 27);
            this.txtBoxKeybind.TabIndex = 3;
            // 
            // icons_imageList
            // 
            this.icons_imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.icons_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons_imageList.ImageStream")));
            this.icons_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.icons_imageList.Images.SetKeyName(0, "launch_icon.png");
            this.icons_imageList.Images.SetKeyName(1, "autoclicker_icon.png");
            this.icons_imageList.Images.SetKeyName(2, "plus_icon.png");
            this.icons_imageList.Images.SetKeyName(3, "minus_icon.png");
            this.icons_imageList.Images.SetKeyName(4, "home_icon.png");
            this.icons_imageList.Images.SetKeyName(5, "settings_icon.png");
            this.icons_imageList.Images.SetKeyName(6, "mouse_icon.png");
            // 
            // ConfigUIForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(902, 579);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MinimumSize = new System.Drawing.Size(616, 0);
            this.Name = "ConfigUIForm";
            this.materialTabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.tabAutoclicker.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.ResumeLayout(false);

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

        private void btnRemoveStp_Click(object sender, EventArgs e)
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
    }
}
