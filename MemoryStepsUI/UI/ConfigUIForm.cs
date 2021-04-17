
using Gma.System.MouseKeyHook;
using MaterialSkin;
using MaterialSkin.Controls;
using MemoryStepsUI.Services;
using MemoryStepsUI.UI;
using Microsoft.Test.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStepsUI.UI
{
    public partial class ConfigUIForm : MaterialForm
    {
        #region Fields
        private int numberOfSteps = 0;
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
        private MaterialButton btnAddStep;
        private MaterialButton btnRemoveStp;
        private MaterialCard matcard_Down;
        private MaterialButton btnLaunchTest;
        private MaterialLabel lblTstCompSec;
        private MaterialLabel lblTestComp;
        private MaterialCard matCard_Top;
        private MaterialDivider materialDivider1;
        private MaterialSwitch switchAutoclicker;
        private MaterialTextBox tbRepsTextBox;
        private MaterialLabel lblRepsText;
        private MaterialSwitch switchTheme;
        private MaterialTextBox txtBoxKeybind;
        private MaterialLabel lblKeyBind;
        private MaterialButton btnLoadConfig;
        private MaterialButton btnSaveConfig;
        private MaterialButton btnStartManualConfig;
        private MaterialCard materialCard1;
        private MaterialLabel lblAutoclickerTitle;
        private MaterialCard materialCard2;
        private MaterialLabel lblSettings;
        private MaterialMultiLineTextBox rtbAutoclickerCurrentConfig;
        private MaterialLabel lblAutoclickerSummary;
        private MaterialCard materialCard3;
        public CursorRegisterService cursorRegister;
        private IKeyboardMouseEvents m_GlobalHook;
        private CursorLoaderService _cursorLoader;
        private CursorExecutorService _executor;
        #endregion Fields

        public ConfigUIForm()
        {
            InitializeComponent();
            CompleteTestKeyBind = '`';
            txtBoxKeybind.Text = CompleteTestKeyBind.ToString();
            steps = new Stack<StepEntity>();
            cursorRegister = new CursorRegisterService();
            _cursorLoader = new CursorLoaderService();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.DeepPurple200, TextShade.WHITE);
            tbRepsTextBox.Text = "5";
            this.Icon = Properties.Resources.logo;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigUIForm));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.switchAutoclicker = new MaterialSkin.Controls.MaterialSwitch();
            this.tbRepsTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.lblRepsText = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.matCard_Top = new MaterialSkin.Controls.MaterialCard();
            this.lblTestSummary = new MaterialSkin.Controls.MaterialLabel();
            this.lblTstCompSec = new MaterialSkin.Controls.MaterialLabel();
            this.lblTestComp = new MaterialSkin.Controls.MaterialLabel();
            this.matcard_Down = new MaterialSkin.Controls.MaterialCard();
            this.btnLaunchTest = new MaterialSkin.Controls.MaterialButton();
            this.btnAddStep = new MaterialSkin.Controls.MaterialButton();
            this.btnRemoveStp = new MaterialSkin.Controls.MaterialButton();
            this.tabAutoclicker = new System.Windows.Forms.TabPage();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnStartManualConfig = new MaterialSkin.Controls.MaterialButton();
            this.btnSaveConfig = new MaterialSkin.Controls.MaterialButton();
            this.btnLoadConfig = new MaterialSkin.Controls.MaterialButton();
            this.rtbAutoclickerCurrentConfig = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lblAutoclickerSummary = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblAutoclickerTitle = new MaterialSkin.Controls.MaterialLabel();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.lblSettings = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxKeybind = new MaterialSkin.Controls.MaterialTextBox();
            this.lblKeyBind = new MaterialSkin.Controls.MaterialLabel();
            this.switchTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.icons_imageList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.matCard_Top.SuspendLayout();
            this.matcard_Down.SuspendLayout();
            this.tabAutoclicker.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.materialCard2.SuspendLayout();
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
            this.materialTabControl1.Size = new System.Drawing.Size(896, 659);
            this.materialTabControl1.TabIndex = 5;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.switchAutoclicker);
            this.tabHome.Controls.Add(this.tbRepsTextBox);
            this.tabHome.Controls.Add(this.lblRepsText);
            this.tabHome.Controls.Add(this.materialDivider1);
            this.tabHome.Controls.Add(this.matCard_Top);
            this.tabHome.Controls.Add(this.matcard_Down);
            this.tabHome.ImageKey = "home_icon.png";
            this.tabHome.Location = new System.Drawing.Point(4, 39);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(888, 616);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // switchAutoclicker
            // 
            this.switchAutoclicker.AutoSize = true;
            this.switchAutoclicker.Depth = 0;
            this.switchAutoclicker.Location = new System.Drawing.Point(617, 83);
            this.switchAutoclicker.Margin = new System.Windows.Forms.Padding(0);
            this.switchAutoclicker.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchAutoclicker.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchAutoclicker.Name = "switchAutoclicker";
            this.switchAutoclicker.Ripple = true;
            this.switchAutoclicker.Size = new System.Drawing.Size(168, 37);
            this.switchAutoclicker.TabIndex = 22;
            this.switchAutoclicker.Text = "Use AutoClicker";
            this.switchAutoclicker.UseVisualStyleBackColor = true;
            // 
            // tbRepsTextBox
            // 
            this.tbRepsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRepsTextBox.Depth = 0;
            this.tbRepsTextBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbRepsTextBox.Location = new System.Drawing.Point(232, 84);
            this.tbRepsTextBox.MaxLength = 10;
            this.tbRepsTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.tbRepsTextBox.Multiline = false;
            this.tbRepsTextBox.Name = "tbRepsTextBox";
            this.tbRepsTextBox.Size = new System.Drawing.Size(100, 36);
            this.tbRepsTextBox.TabIndex = 21;
            this.tbRepsTextBox.Text = "";
            this.tbRepsTextBox.UseTallSize = false;
            // 
            // lblRepsText
            // 
            this.lblRepsText.AutoSize = true;
            this.lblRepsText.Depth = 0;
            this.lblRepsText.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRepsText.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblRepsText.Location = new System.Drawing.Point(44, 101);
            this.lblRepsText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRepsText.Name = "lblRepsText";
            this.lblRepsText.Size = new System.Drawing.Size(154, 19);
            this.lblRepsText.TabIndex = 20;
            this.lblRepsText.Text = "Number of repetitions";
            this.lblRepsText.UseAccent = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(44, 127);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(738, 13);
            this.materialDivider1.TabIndex = 10;
            this.materialDivider1.Text = "materialDivider1";
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
            this.matcard_Down.Controls.Add(this.btnAddStep);
            this.matcard_Down.Controls.Add(this.btnRemoveStp);
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
            this.btnAddStep.Location = new System.Drawing.Point(277, 12);
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
            this.btnRemoveStp.Location = new System.Drawing.Point(73, 12);
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
            // tabAutoclicker
            // 
            this.tabAutoclicker.Controls.Add(this.materialCard3);
            this.tabAutoclicker.Controls.Add(this.rtbAutoclickerCurrentConfig);
            this.tabAutoclicker.Controls.Add(this.lblAutoclickerSummary);
            this.tabAutoclicker.Controls.Add(this.materialCard1);
            this.tabAutoclicker.ImageKey = "mouse_icon.png";
            this.tabAutoclicker.Location = new System.Drawing.Point(4, 39);
            this.tabAutoclicker.Name = "tabAutoclicker";
            this.tabAutoclicker.Size = new System.Drawing.Size(888, 616);
            this.tabAutoclicker.TabIndex = 2;
            this.tabAutoclicker.Text = "AutoClicker";
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
            this.btnStartManualConfig.Depth = 0;
            this.btnStartManualConfig.DrawShadows = true;
            this.btnStartManualConfig.HighEmphasis = true;
            this.btnStartManualConfig.Icon = ((System.Drawing.Image)(resources.GetObject("btnStartManualConfig.Icon")));
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
            this.btnSaveConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveConfig.Depth = 0;
            this.btnSaveConfig.DrawShadows = true;
            this.btnSaveConfig.HighEmphasis = true;
            this.btnSaveConfig.Icon = ((System.Drawing.Image)(resources.GetObject("btnSaveConfig.Icon")));
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
            this.btnLoadConfig.Depth = 0;
            this.btnLoadConfig.DrawShadows = true;
            this.btnLoadConfig.HighEmphasis = true;
            this.btnLoadConfig.Icon = ((System.Drawing.Image)(resources.GetObject("btnLoadConfig.Icon")));
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
            this.rtbAutoclickerCurrentConfig.Hint = "";
            this.rtbAutoclickerCurrentConfig.Location = new System.Drawing.Point(44, 134);
            this.rtbAutoclickerCurrentConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.rtbAutoclickerCurrentConfig.Name = "rtbAutoclickerCurrentConfig";
            this.rtbAutoclickerCurrentConfig.ReadOnly = true;
            this.rtbAutoclickerCurrentConfig.Size = new System.Drawing.Size(733, 389);
            this.rtbAutoclickerCurrentConfig.TabIndex = 5;
            this.rtbAutoclickerCurrentConfig.Text = "";
            // 
            // lblAutoclickerSummary
            // 
            this.lblAutoclickerSummary.AutoSize = true;
            this.lblAutoclickerSummary.Depth = 0;
            this.lblAutoclickerSummary.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAutoclickerSummary.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblAutoclickerSummary.Location = new System.Drawing.Point(44, 101);
            this.lblAutoclickerSummary.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAutoclickerSummary.Name = "lblAutoclickerSummary";
            this.lblAutoclickerSummary.Size = new System.Drawing.Size(151, 19);
            this.lblAutoclickerSummary.TabIndex = 4;
            this.lblAutoclickerSummary.Text = "Current configuration";
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
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.materialCard2);
            this.tabSettings.Controls.Add(this.txtBoxKeybind);
            this.tabSettings.Controls.Add(this.lblKeyBind);
            this.tabSettings.Controls.Add(this.switchTheme);
            this.tabSettings.ImageKey = "settings_icon.png";
            this.tabSettings.Location = new System.Drawing.Point(4, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(888, 616);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.lblSettings);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(28, 6);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(765, 66);
            this.materialCard2.TabIndex = 9;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Depth = 0;
            this.lblSettings.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSettings.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblSettings.Location = new System.Drawing.Point(9, 16);
            this.lblSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(270, 29);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "Application wide settings";
            // 
            // txtBoxKeybind
            // 
            this.txtBoxKeybind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxKeybind.Depth = 0;
            this.txtBoxKeybind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxKeybind.Location = new System.Drawing.Point(256, 204);
            this.txtBoxKeybind.MaxLength = 50;
            this.txtBoxKeybind.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxKeybind.Multiline = false;
            this.txtBoxKeybind.Name = "txtBoxKeybind";
            this.txtBoxKeybind.Size = new System.Drawing.Size(100, 36);
            this.txtBoxKeybind.TabIndex = 8;
            this.txtBoxKeybind.Text = "";
            this.txtBoxKeybind.UseTallSize = false;
            this.txtBoxKeybind.TextChanged += new System.EventHandler(this.txtBoxKeybind_TextChanged);
            // 
            // lblKeyBind
            // 
            this.lblKeyBind.AutoSize = true;
            this.lblKeyBind.Depth = 0;
            this.lblKeyBind.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblKeyBind.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblKeyBind.Location = new System.Drawing.Point(50, 211);
            this.lblKeyBind.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKeyBind.Name = "lblKeyBind";
            this.lblKeyBind.Size = new System.Drawing.Size(86, 29);
            this.lblKeyBind.TabIndex = 7;
            this.lblKeyBind.Text = "Keybind";
            // 
            // switchTheme
            // 
            this.switchTheme.AutoSize = true;
            this.switchTheme.Checked = true;
            this.switchTheme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.switchTheme.Depth = 0;
            this.switchTheme.Location = new System.Drawing.Point(50, 155);
            this.switchTheme.Margin = new System.Windows.Forms.Padding(0);
            this.switchTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchTheme.Name = "switchTheme";
            this.switchTheme.Ripple = true;
            this.switchTheme.Size = new System.Drawing.Size(185, 37);
            this.switchTheme.TabIndex = 6;
            this.switchTheme.Text = "Enable dark mode";
            this.switchTheme.UseVisualStyleBackColor = true;
            this.switchTheme.CheckedChanged += new System.EventHandler(this.switchTheme_CheckedChanged);
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
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 665);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(616, 0);
            this.Name = "ConfigUIForm";
            this.Text = "Memory steps 2";
            this.materialTabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.matCard_Top.ResumeLayout(false);
            this.matCard_Top.PerformLayout();
            this.matcard_Down.ResumeLayout(false);
            this.tabAutoclicker.ResumeLayout(false);
            this.tabAutoclicker.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

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
            lblTestComp.Visible = true;
        }

        private void btnAddStep_Click(object sender, EventArgs e)
        {
            numberOfSteps++;
            if (numberOfSteps > 5)
            {
                this.Size = new Size(this.Size.Width, this.Size.Height + 70);
                matcard_Down.Location = new Point(matcard_Down.Location.X, matcard_Down.Location.Y + 70);
            }
            StepEntity entity = new StepEntity(numberOfSteps, false);
            foreach (var control in entity.GetControlListForConfig())
            {
                this.tabHome.Controls.Add(control);
            }

            steps.Push(entity);
        }

        private void btnRemoveStp_Click(object sender, EventArgs e)
        {
            if (numberOfSteps == 0)
                return;

            if (numberOfSteps > 5)
            {
                this.Size = new Size(this.Size.Width, this.Size.Height - 70);
                matcard_Down.Location = new Point(matcard_Down.Location.X, matcard_Down.Location.Y - 70);
            }
            numberOfSteps--;

            StepEntity entity = steps.Pop();
            foreach (var control in entity.GetControlListForConfig())
            {
                this.tabHome.Controls.Remove(control);
            }
        }

        private void btnLaunchTest_Click(object sender, EventArgs e)
        {
            ValidateBeforeTestLaunch();
            if (switchAutoclicker.Checked) 
            {
                LaunchAutoclicker();
                return;
            }

            LaunchTest();
        }

        private void ValidateBeforeTestLaunch() 
        {
            if (switchAutoclicker.Checked && string.IsNullOrEmpty(rtbAutoclickerCurrentConfig.Text))
                throw new ApplicationException("Invalid autoclicker configuration");

            if (!switchAutoclicker.Checked && !int.TryParse(tbRepsTextBox.Text, out int _))
                throw new ApplicationException("Invalid number of repetitions value");


            return;

        }

        private void switchTheme_CheckedChanged(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;

            if(switchTheme.Checked)
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            else
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void txtBoxKeybind_TextChanged(object sender, EventArgs e)
        {
            CompleteTestKeyBind = txtBoxKeybind.Text[0];
        }

        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.KeyPress += GlobalHookKeyPress;
            m_GlobalHook.MouseClick += GlobalHook_MouseClick;
        }

        public void Unsubscribe()
        {
            if (m_GlobalHook == null)
                return;

            m_GlobalHook.KeyPress -= GlobalHookKeyPress;
            m_GlobalHook.MouseClick -= GlobalHook_MouseClick;

            cursorRegister.StopLastCursorTimewatch(true);
            m_GlobalHook.Dispose();
            autoclickerF.Hide();
            autoclickerF.Dispose();
            this.Show();
            rtbAutoclickerCurrentConfig.Text = _cursorLoader.GetCurrentConfig(cursorRegister.CursorList);
        }

        private void GlobalHook_MouseClick(object sender, MouseEventArgs e)
        {
           cursorRegister.RegisterMouseButtonClick(e.Location, e.Button);
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==  CompleteTestKeyBind)
            {
                Unsubscribe();
                e.Handled = true;
                return;
            }

            cursorRegister.RegisterKeyPress(e.KeyChar);
            e.Handled = true;
        }

        private AutoclickerForm autoclickerF; 
        private void btnStartManualConfig_Click(object sender, EventArgs e)
        {
            this.Hide();
            cursorRegister.ResetList();
            autoclickerF = new AutoclickerForm(this)
            {
                TopMost = true
            };
            autoclickerF.Show();
            Subscribe();
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            cursorRegister.LoadList(_cursorLoader.LoadConfig());
            rtbAutoclickerCurrentConfig.Text = _cursorLoader.GetCurrentConfig(cursorRegister.CursorList);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            _cursorLoader.SaveConfig(cursorRegister.CursorList);
        }

        private void LaunchAutoclicker()
        {
            Application.DoEvents();
            this.Hide();

            _executor = new CursorExecutorService(cursorRegister);
            Stopwatch timer = new Stopwatch();

            timer.Start();
            _executor.Execute(this);
            timer.Stop();

            CompleteTest(timer.Elapsed.ToString());
        }

        private void LaunchTest() 
        {
            int.TryParse(tbRepsTextBox.Text, out int numberOfReps);
            TestForm testForm = new TestForm(this, numberOfReps, ConvertEntityStackToList(), false)
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
