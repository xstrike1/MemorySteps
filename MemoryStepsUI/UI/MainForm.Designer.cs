
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Windows.Forms;

namespace MemoryStepsUI.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.cardConfig = new MaterialSkin.Controls.MaterialCard();
            this.txtBoxTestDescr = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lblTestDescr = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumberOfClicks = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTestDuration = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNumberOfCharacters = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBoxTestName = new MaterialSkin.Controls.MaterialTextBox();
            this.lblTestName = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstDurat = new MaterialSkin.Controls.MaterialLabel();
            this.lblPressedChars = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumberOfClicks = new MaterialSkin.Controls.MaterialLabel();
            this.lblAutoClickerConfigTitle = new MaterialSkin.Controls.MaterialLabel();
            this.matCard_Top = new MaterialSkin.Controls.MaterialCard();
            this.lblTestSummary = new MaterialSkin.Controls.MaterialLabel();
            this.lblTstCompSec = new MaterialSkin.Controls.MaterialLabel();
            this.lblTestComp = new MaterialSkin.Controls.MaterialLabel();
            this.matcard_Down = new MaterialSkin.Controls.MaterialCard();
            this.btnLaunchTest = new MaterialSkin.Controls.MaterialButton();
            this.tabAutoclicker = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnStartManualConfig = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveConfig = new MaterialSkin.Controls.MaterialButton();
            this.btnLoadConfig = new MaterialSkin.Controls.MaterialButton();
            this.rtbAutoclickerCurrentConfig = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblAutoclickerTitle = new MaterialSkin.Controls.MaterialLabel();
            this.icons_imageList = new System.Windows.Forms.ImageList(this.components);
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.cardConfig.SuspendLayout();
            this.matCard_Top.SuspendLayout();
            this.matcard_Down.SuspendLayout();
            this.tabAutoclicker.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
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
            this.materialTabControl1.Controls.Add(this.tabAutoclicker);
            this.materialTabControl1.Controls.Add(this.tabHome);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.icons_imageList;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(896, 598);
            this.materialTabControl1.TabIndex = 5;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.cardConfig);
            this.tabHome.Controls.Add(this.matCard_Top);
            this.tabHome.Controls.Add(this.matcard_Down);
            this.tabHome.ImageKey = "home_icon.png";
            this.tabHome.Location = new System.Drawing.Point(4, 39);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(888, 555);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // cardConfig
            // 
            this.cardConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardConfig.Controls.Add(this.txtBoxTestDescr);
            this.cardConfig.Controls.Add(this.lblTestDescr);
            this.cardConfig.Controls.Add(this.txtNumberOfClicks);
            this.cardConfig.Controls.Add(this.txtTestDuration);
            this.cardConfig.Controls.Add(this.txtNumberOfCharacters);
            this.cardConfig.Controls.Add(this.txtBoxTestName);
            this.cardConfig.Controls.Add(this.lblTestName);
            this.cardConfig.Controls.Add(this.lblEstDurat);
            this.cardConfig.Controls.Add(this.lblPressedChars);
            this.cardConfig.Controls.Add(this.lblNumberOfClicks);
            this.cardConfig.Controls.Add(this.lblAutoClickerConfigTitle);
            this.cardConfig.Depth = 0;
            this.cardConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardConfig.Location = new System.Drawing.Point(28, 112);
            this.cardConfig.Margin = new System.Windows.Forms.Padding(14);
            this.cardConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardConfig.Name = "cardConfig";
            this.cardConfig.Padding = new System.Windows.Forms.Padding(14);
            this.cardConfig.Size = new System.Drawing.Size(764, 420);
            this.cardConfig.TabIndex = 15;
            // 
            // txtBoxTestDescr
            // 
            this.txtBoxTestDescr.AutoWordSelection = true;
            this.txtBoxTestDescr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBoxTestDescr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTestDescr.Depth = 0;
            this.txtBoxTestDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxTestDescr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBoxTestDescr.Location = new System.Drawing.Point(206, 221);
            this.txtBoxTestDescr.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBoxTestDescr.Name = "txtBoxTestDescr";
            this.txtBoxTestDescr.Size = new System.Drawing.Size(447, 159);
            this.txtBoxTestDescr.TabIndex = 7;
            this.txtBoxTestDescr.Text = "Write a description here";
            this.txtBoxTestDescr.TextChanged += new System.EventHandler(this.txtBoxTestDescr_TextChanged);
            // 
            // lblTestDescr
            // 
            this.lblTestDescr.AutoSize = true;
            this.lblTestDescr.Depth = 0;
            this.lblTestDescr.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTestDescr.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblTestDescr.Location = new System.Drawing.Point(20, 225);
            this.lblTestDescr.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTestDescr.Name = "lblTestDescr";
            this.lblTestDescr.Size = new System.Drawing.Size(100, 17);
            this.lblTestDescr.TabIndex = 6;
            this.lblTestDescr.Text = "Test description";
            // 
            // txtNumberOfClicks
            // 
            this.txtNumberOfClicks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberOfClicks.Depth = 0;
            this.txtNumberOfClicks.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumberOfClicks.LeadingIcon = null;
            this.txtNumberOfClicks.Location = new System.Drawing.Point(206, 125);
            this.txtNumberOfClicks.MaxLength = 50;
            this.txtNumberOfClicks.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumberOfClicks.Multiline = false;
            this.txtNumberOfClicks.Name = "txtNumberOfClicks";
            this.txtNumberOfClicks.ReadOnly = true;
            this.txtNumberOfClicks.Size = new System.Drawing.Size(447, 36);
            this.txtNumberOfClicks.TabIndex = 5;
            this.txtNumberOfClicks.Text = "";
            this.txtNumberOfClicks.TrailingIcon = null;
            this.txtNumberOfClicks.UseTallSize = false;
            // 
            // txtTestDuration
            // 
            this.txtTestDuration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTestDuration.Depth = 0;
            this.txtTestDuration.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTestDuration.LeadingIcon = null;
            this.txtTestDuration.Location = new System.Drawing.Point(206, 83);
            this.txtTestDuration.MaxLength = 50;
            this.txtTestDuration.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTestDuration.Multiline = false;
            this.txtTestDuration.Name = "txtTestDuration";
            this.txtTestDuration.ReadOnly = true;
            this.txtTestDuration.Size = new System.Drawing.Size(447, 36);
            this.txtTestDuration.TabIndex = 5;
            this.txtTestDuration.Text = "";
            this.txtTestDuration.TrailingIcon = null;
            this.txtTestDuration.UseTallSize = false;
            // 
            // txtNumberOfCharacters
            // 
            this.txtNumberOfCharacters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumberOfCharacters.Depth = 0;
            this.txtNumberOfCharacters.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumberOfCharacters.LeadingIcon = null;
            this.txtNumberOfCharacters.Location = new System.Drawing.Point(206, 167);
            this.txtNumberOfCharacters.MaxLength = 50;
            this.txtNumberOfCharacters.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumberOfCharacters.Multiline = false;
            this.txtNumberOfCharacters.Name = "txtNumberOfCharacters";
            this.txtNumberOfCharacters.ReadOnly = true;
            this.txtNumberOfCharacters.Size = new System.Drawing.Size(447, 36);
            this.txtNumberOfCharacters.TabIndex = 5;
            this.txtNumberOfCharacters.Text = "";
            this.txtNumberOfCharacters.TrailingIcon = null;
            this.txtNumberOfCharacters.UseTallSize = false;
            // 
            // txtBoxTestName
            // 
            this.txtBoxTestName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTestName.Depth = 0;
            this.txtBoxTestName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxTestName.LeadingIcon = null;
            this.txtBoxTestName.Location = new System.Drawing.Point(206, 41);
            this.txtBoxTestName.MaxLength = 50;
            this.txtBoxTestName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxTestName.Multiline = false;
            this.txtBoxTestName.Name = "txtBoxTestName";
            this.txtBoxTestName.Size = new System.Drawing.Size(447, 36);
            this.txtBoxTestName.TabIndex = 5;
            this.txtBoxTestName.Text = "";
            this.txtBoxTestName.TrailingIcon = null;
            this.txtBoxTestName.UseTallSize = false;
            this.txtBoxTestName.TextChanged += new System.EventHandler(this.txtBoxTestName_TextChanged);
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Depth = 0;
            this.lblTestName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTestName.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblTestName.Location = new System.Drawing.Point(20, 60);
            this.lblTestName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(66, 17);
            this.lblTestName.TabIndex = 4;
            this.lblTestName.Text = "Test name";
            // 
            // lblEstDurat
            // 
            this.lblEstDurat.AutoSize = true;
            this.lblEstDurat.Depth = 0;
            this.lblEstDurat.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEstDurat.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblEstDurat.Location = new System.Drawing.Point(20, 102);
            this.lblEstDurat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstDurat.Name = "lblEstDurat";
            this.lblEstDurat.Size = new System.Drawing.Size(84, 17);
            this.lblEstDurat.TabIndex = 3;
            this.lblEstDurat.Text = "Test duration";
            // 
            // lblPressedChars
            // 
            this.lblPressedChars.AutoSize = true;
            this.lblPressedChars.Depth = 0;
            this.lblPressedChars.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPressedChars.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblPressedChars.Location = new System.Drawing.Point(20, 186);
            this.lblPressedChars.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPressedChars.Name = "lblPressedChars";
            this.lblPressedChars.Size = new System.Drawing.Size(137, 17);
            this.lblPressedChars.TabIndex = 2;
            this.lblPressedChars.Text = "Number of characters";
            // 
            // lblNumberOfClicks
            // 
            this.lblNumberOfClicks.AutoSize = true;
            this.lblNumberOfClicks.Depth = 0;
            this.lblNumberOfClicks.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumberOfClicks.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblNumberOfClicks.Location = new System.Drawing.Point(20, 144);
            this.lblNumberOfClicks.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumberOfClicks.Name = "lblNumberOfClicks";
            this.lblNumberOfClicks.Size = new System.Drawing.Size(104, 17);
            this.lblNumberOfClicks.TabIndex = 1;
            this.lblNumberOfClicks.Text = "Number of clicks";
            // 
            // lblAutoClickerConfigTitle
            // 
            this.lblAutoClickerConfigTitle.AutoSize = true;
            this.lblAutoClickerConfigTitle.Depth = 0;
            this.lblAutoClickerConfigTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAutoClickerConfigTitle.Location = new System.Drawing.Point(9, 11);
            this.lblAutoClickerConfigTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAutoClickerConfigTitle.Name = "lblAutoClickerConfigTitle";
            this.lblAutoClickerConfigTitle.Size = new System.Drawing.Size(151, 19);
            this.lblAutoClickerConfigTitle.TabIndex = 0;
            this.lblAutoClickerConfigTitle.Text = "Current configuration";
            // 
            // matCard_Top
            // 
            this.matCard_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCard_Top.Controls.Add(this.lblTestSummary);
            this.matCard_Top.Controls.Add(this.lblTstCompSec);
            this.matCard_Top.Controls.Add(this.lblTestComp);
            this.matCard_Top.Depth = 0;
            this.matCard_Top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCard_Top.Location = new System.Drawing.Point(28, 6);
            this.matCard_Top.Margin = new System.Windows.Forms.Padding(14);
            this.matCard_Top.MouseState = MaterialSkin.MouseState.HOVER;
            this.matCard_Top.Name = "matCard_Top";
            this.matCard_Top.Padding = new System.Windows.Forms.Padding(14);
            this.matCard_Top.Size = new System.Drawing.Size(764, 66);
            this.matCard_Top.TabIndex = 14;
            // 
            // lblTestSummary
            // 
            this.lblTestSummary.AutoSize = true;
            this.lblTestSummary.Depth = 0;
            this.lblTestSummary.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTestSummary.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTestSummary.Location = new System.Drawing.Point(9, 16);
            this.lblTestSummary.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTestSummary.Name = "lblTestSummary";
            this.lblTestSummary.Size = new System.Drawing.Size(153, 29);
            this.lblTestSummary.TabIndex = 5;
            this.lblTestSummary.Text = "Test summary";
            this.lblTestSummary.UseAccent = true;
            // 
            // lblTstCompSec
            // 
            this.lblTstCompSec.AutoSize = true;
            this.lblTstCompSec.Depth = 0;
            this.lblTstCompSec.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTstCompSec.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTstCompSec.Location = new System.Drawing.Point(580, 21);
            this.lblTstCompSec.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTstCompSec.Name = "lblTstCompSec";
            this.lblTstCompSec.Size = new System.Drawing.Size(13, 24);
            this.lblTstCompSec.TabIndex = 13;
            this.lblTstCompSec.Text = "#";
            this.lblTstCompSec.UseAccent = true;
            this.lblTstCompSec.Visible = false;
            // 
            // lblTestComp
            // 
            this.lblTestComp.AutoSize = true;
            this.lblTestComp.Depth = 0;
            this.lblTestComp.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTestComp.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblTestComp.Location = new System.Drawing.Point(384, 21);
            this.lblTestComp.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTestComp.Name = "lblTestComp";
            this.lblTestComp.Size = new System.Drawing.Size(190, 24);
            this.lblTestComp.TabIndex = 12;
            this.lblTestComp.Text = "Test completion time";
            this.lblTestComp.Visible = false;
            // 
            // matcard_Down
            // 
            this.matcard_Down.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matcard_Down.Controls.Add(this.btnLaunchTest);
            this.matcard_Down.Depth = 0;
            this.matcard_Down.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matcard_Down.Location = new System.Drawing.Point(-45, 540);
            this.matcard_Down.Margin = new System.Windows.Forms.Padding(14);
            this.matcard_Down.MouseState = MaterialSkin.MouseState.HOVER;
            this.matcard_Down.Name = "matcard_Down";
            this.matcard_Down.Padding = new System.Windows.Forms.Padding(14);
            this.matcard_Down.Size = new System.Drawing.Size(948, 68);
            this.matcard_Down.TabIndex = 9;
            // 
            // btnLaunchTest
            // 
            this.btnLaunchTest.AutoSize = false;
            this.btnLaunchTest.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLaunchTest.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLaunchTest.Depth = 0;
            this.btnLaunchTest.HighEmphasis = true;
            this.btnLaunchTest.Icon = global::MemoryStepsUI.Properties.Resources.launch_icon;
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
            // tabAutoclicker
            // 
            this.tabAutoclicker.Controls.Add(this.materialCard3);
            this.tabAutoclicker.Controls.Add(this.rtbAutoclickerCurrentConfig);
            this.tabAutoclicker.Controls.Add(this.materialCard1);
            this.tabAutoclicker.ImageKey = "settings_icon.png";
            this.tabAutoclicker.Location = new System.Drawing.Point(4, 39);
            this.tabAutoclicker.Name = "tabAutoclicker";
            this.tabAutoclicker.Size = new System.Drawing.Size(888, 555);
            this.tabAutoclicker.TabIndex = 2;
            this.tabAutoclicker.Text = "Configuration";
            this.tabAutoclicker.UseVisualStyleBackColor = true;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.btnStartManualConfig);
            this.materialCard3.Controls.Add(this.btnSaveConfig);
            this.materialCard3.Controls.Add(this.btnLoadConfig);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(-45, 540);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(1274, 68);
            this.materialCard3.TabIndex = 6;
            // 
            // btnStartManualConfig
            // 
            this.btnStartManualConfig.AutoSize = false;
            this.btnStartManualConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartManualConfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStartManualConfig.Depth = 0;
            this.btnStartManualConfig.HighEmphasis = true;
            this.btnStartManualConfig.Icon = global::MemoryStepsUI.Properties.Resources.start_icon;
            this.btnStartManualConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartManualConfig.Location = new System.Drawing.Point(73, 12);
            this.btnStartManualConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStartManualConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartManualConfig.Name = "btnStartManualConfig";
            this.btnStartManualConfig.Size = new System.Drawing.Size(280, 36);
            this.btnStartManualConfig.TabIndex = 0;
            this.btnStartManualConfig.Text = "Start manual configuration";
            this.btnStartManualConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStartManualConfig.UseAccentColor = false;
            this.btnStartManualConfig.UseVisualStyleBackColor = true;
            this.btnStartManualConfig.Click += new System.EventHandler(this.btnStartManualConfig_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.AutoSize = false;
            this.btnSaveConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveConfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSaveConfig.Depth = 0;
            this.btnSaveConfig.HighEmphasis = true;
            this.btnSaveConfig.Icon = global::MemoryStepsUI.Properties.Resources.save_icon;
            this.btnSaveConfig.Location = new System.Drawing.Point(671, 12);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(205, 36);
            this.btnSaveConfig.TabIndex = 1;
            this.btnSaveConfig.Text = "Save configuration";
            this.btnSaveConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSaveConfig.UseAccentColor = false;
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.AutoSize = false;
            this.btnLoadConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoadConfig.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoadConfig.Depth = 0;
            this.btnLoadConfig.HighEmphasis = true;
            this.btnLoadConfig.Icon = global::MemoryStepsUI.Properties.Resources.load_icon;
            this.btnLoadConfig.Location = new System.Drawing.Point(430, 13);
            this.btnLoadConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoadConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(217, 36);
            this.btnLoadConfig.TabIndex = 2;
            this.btnLoadConfig.Text = "Load configuration";
            this.btnLoadConfig.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoadConfig.UseAccentColor = false;
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // rtbAutoclickerCurrentConfig
            // 
            this.rtbAutoclickerCurrentConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtbAutoclickerCurrentConfig.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAutoclickerCurrentConfig.Depth = 0;
            this.rtbAutoclickerCurrentConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rtbAutoclickerCurrentConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rtbAutoclickerCurrentConfig.Location = new System.Drawing.Point(44, 134);
            this.rtbAutoclickerCurrentConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtbAutoclickerCurrentConfig.Name = "rtbAutoclickerCurrentConfig";
            this.rtbAutoclickerCurrentConfig.ReadOnly = true;
            this.rtbAutoclickerCurrentConfig.Size = new System.Drawing.Size(733, 389);
            this.rtbAutoclickerCurrentConfig.TabIndex = 5;
            this.rtbAutoclickerCurrentConfig.Text = "";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblAutoclickerTitle);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(28, 6);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(765, 66);
            this.materialCard1.TabIndex = 3;
            // 
            // lblAutoclickerTitle
            // 
            this.lblAutoclickerTitle.AutoSize = true;
            this.lblAutoclickerTitle.Depth = 0;
            this.lblAutoclickerTitle.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAutoclickerTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblAutoclickerTitle.Location = new System.Drawing.Point(9, 16);
            this.lblAutoclickerTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAutoclickerTitle.Name = "lblAutoclickerTitle";
            this.lblAutoclickerTitle.Size = new System.Drawing.Size(274, 29);
            this.lblAutoclickerTitle.TabIndex = 0;
            this.lblAutoclickerTitle.Text = "AutoClicker configuration";
            // 
            // icons_imageList
            // 
            this.icons_imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.icons_imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons_imageList.ImageStream")));
            this.icons_imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.icons_imageList.Images.SetKeyName(0, "start_icon.png");
            this.icons_imageList.Images.SetKeyName(1, "load_icon.png");
            this.icons_imageList.Images.SetKeyName(2, "save_icon.png");
            this.icons_imageList.Images.SetKeyName(3, "mouse_icon.png");
            this.icons_imageList.Images.SetKeyName(4, "launch_icon.png");
            this.icons_imageList.Images.SetKeyName(5, "autoclicker_icon.png");
            this.icons_imageList.Images.SetKeyName(6, "plus_icon.png");
            this.icons_imageList.Images.SetKeyName(7, "minus_icon.png");
            this.icons_imageList.Images.SetKeyName(8, "home_icon.png");
            this.icons_imageList.Images.SetKeyName(9, "settings_icon.png");
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(206, 167);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(447, 36);
            this.materialTextBox3.TabIndex = 5;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            this.materialTextBox3.UseTallSize = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 665);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximumSize = new System.Drawing.Size(902, 665);
            this.MinimumSize = new System.Drawing.Size(902, 665);
            this.Name = "MainForm";
            this.Text = "Memory steps 4";
            this.materialTabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.cardConfig.ResumeLayout(false);
            this.cardConfig.PerformLayout();
            this.matCard_Top.ResumeLayout(false);
            this.matCard_Top.PerformLayout();
            this.matcard_Down.ResumeLayout(false);
            this.tabAutoclicker.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialTabControl materialTabControl1;
        private TabPage tabHome;
        internal ImageList icons_imageList;
        private TabPage tabAutoclicker;
        private MaterialLabel lblTestSummary;
        private MaterialCard matcard_Down;
        private MaterialButton btnLaunchTest;
        private MaterialLabel lblTstCompSec;
        private MaterialLabel lblTestComp;
        private MaterialCard matCard_Top;
        private MaterialButton btnLoadConfig;
        private MaterialButton btnSaveConfig;
        private MaterialButton btnStartManualConfig;
        private MaterialCard materialCard1;
        private MaterialLabel lblAutoclickerTitle;
        private MaterialMultiLineTextBox rtbAutoclickerCurrentConfig;
        private MaterialCard materialCard3;

        #endregion

        private MaterialCard cardConfig;
        private MaterialLabel lblAutoClickerConfigTitle;
        private MaterialTextBox txtBoxTestName;
        private MaterialLabel lblTestName;
        private MaterialLabel lblEstDurat;
        private MaterialLabel lblPressedChars;
        private MaterialLabel lblNumberOfClicks;
        private MaterialTextBox txtNumberOfClicks;
        private MaterialTextBox txtTestDuration;
        private MaterialTextBox txtNumberOfCharacters;
        private MaterialTextBox materialTextBox3;
        private MaterialMultiLineTextBox txtBoxTestDescr;
        private MaterialLabel lblTestDescr;
    }
}