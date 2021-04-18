
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
            this.materialTabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
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
            this.materialTabControl1.Controls.Add(this.tabHome);
            this.materialTabControl1.Controls.Add(this.tabAutoclicker);
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
            this.btnLaunchTest.Depth = 0;
            this.btnLaunchTest.DrawShadows = true;
            this.btnLaunchTest.HighEmphasis = true;
            this.btnLaunchTest.Icon = null;
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
            this.tabAutoclicker.ImageKey = "mouse_icon.png";
            this.tabAutoclicker.Location = new System.Drawing.Point(4, 74);
            this.tabAutoclicker.Name = "tabAutoclicker";
            this.tabAutoclicker.Size = new System.Drawing.Size(888, 0);
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
            this.btnStartManualConfig.Icon = null;
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
            this.btnSaveConfig.Icon = null;
            this.btnSaveConfig.Location = new System.Drawing.Point(671, 12);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(177, 36);
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
            this.btnLoadConfig.Icon = null;
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
            this.Text = "Memory steps 3";
            this.materialTabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.matCard_Top.ResumeLayout(false);
            this.matCard_Top.PerformLayout();
            this.matcard_Down.ResumeLayout(false);
            this.tabAutoclicker.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
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
    }
}