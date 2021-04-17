
namespace MemoryStepsUI.UI
{
    partial class AutoclickerForm
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
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.lblHint = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentProgress = new MaterialSkin.Controls.MaterialLabel();
            this.lblProgressVal = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Depth = 0;
            this.btnExit.DrawShadows = true;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(730, 149);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Depth = 0;
            this.progressBar.Location = new System.Drawing.Point(28, 135);
            this.progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(754, 5);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            this.progressBar.Visible = false;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Depth = 0;
            this.lblHint.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblHint.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblHint.Location = new System.Drawing.Point(28, 71);
            this.lblHint.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(249, 19);
            this.lblHint.TabIndex = 2;
            this.lblHint.Text = "To cancel current execution press x";
            // 
            // lblCurrentProgress
            // 
            this.lblCurrentProgress.AutoSize = true;
            this.lblCurrentProgress.Depth = 0;
            this.lblCurrentProgress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentProgress.Location = new System.Drawing.Point(28, 110);
            this.lblCurrentProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentProgress.Name = "lblCurrentProgress";
            this.lblCurrentProgress.Size = new System.Drawing.Size(117, 19);
            this.lblCurrentProgress.TabIndex = 3;
            this.lblCurrentProgress.Text = "Current progress";
            this.lblCurrentProgress.Visible = false;
            // 
            // lblProgressVal
            // 
            this.lblProgressVal.AutoSize = true;
            this.lblProgressVal.Depth = 0;
            this.lblProgressVal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProgressVal.Location = new System.Drawing.Point(750, 110);
            this.lblProgressVal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProgressVal.Name = "lblProgressVal";
            this.lblProgressVal.Size = new System.Drawing.Size(22, 19);
            this.lblProgressVal.TabIndex = 4;
            this.lblProgressVal.Text = "0%";
            this.lblProgressVal.Visible = false;
            // 
            // AutoclickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 193);
            this.Controls.Add(this.lblProgressVal);
            this.Controls.Add(this.lblCurrentProgress);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnExit);
            this.Name = "AutoclickerForm";
            this.Text = "Autoclicker execution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
        private MaterialSkin.Controls.MaterialLabel lblHint;
        private MaterialSkin.Controls.MaterialLabel lblCurrentProgress;
        private MaterialSkin.Controls.MaterialLabel lblProgressVal;
    }
}