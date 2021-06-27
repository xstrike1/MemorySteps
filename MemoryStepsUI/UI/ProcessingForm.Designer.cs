
namespace MemoryStepsUI.UI
{
    partial class ProcessingForm
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
            this.progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.lblHint = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentProgress = new MaterialSkin.Controls.MaterialLabel();
            this.lblProgressVal = new MaterialSkin.Controls.MaterialLabel();
            this.cursorControlCurrent = new MemoryStepsUI.Controls.CursorControl();
            this.cursorControlNext = new MemoryStepsUI.Controls.CursorControl();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Depth = 0;
            this.progressBar.Location = new System.Drawing.Point(14, 139);
            this.progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(597, 5);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            this.progressBar.Visible = false;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Depth = 0;
            this.lblHint.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHint.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblHint.Location = new System.Drawing.Point(10, 4);
            this.lblHint.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(317, 24);
            this.lblHint.TabIndex = 2;
            this.lblHint.Text = "To cancel current execution press x";
            // 
            // lblCurrentProgress
            // 
            this.lblCurrentProgress.AutoSize = true;
            this.lblCurrentProgress.Depth = 0;
            this.lblCurrentProgress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentProgress.Location = new System.Drawing.Point(14, 117);
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
            this.lblProgressVal.Location = new System.Drawing.Point(589, 117);
            this.lblProgressVal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProgressVal.Name = "lblProgressVal";
            this.lblProgressVal.Size = new System.Drawing.Size(22, 19);
            this.lblProgressVal.TabIndex = 4;
            this.lblProgressVal.Text = "0%";
            this.lblProgressVal.Visible = false;
            // 
            // cursorControlCurrent
            // 
            this.cursorControlCurrent.Location = new System.Drawing.Point(2, 34);
            this.cursorControlCurrent.Name = "cursorControlCurrent";
            this.cursorControlCurrent.Size = new System.Drawing.Size(396, 79);
            this.cursorControlCurrent.TabIndex = 5;
            this.cursorControlCurrent.Visible = false;
            // 
            // cursorControlNext
            // 
            this.cursorControlNext.Location = new System.Drawing.Point(376, 34);
            this.cursorControlNext.Name = "cursorControlNext";
            this.cursorControlNext.Size = new System.Drawing.Size(248, 84);
            this.cursorControlNext.TabIndex = 6;
            this.cursorControlNext.Visible = false;
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 157);
            this.Controls.Add(this.cursorControlNext);
            this.Controls.Add(this.cursorControlCurrent);
            this.Controls.Add(this.lblProgressVal);
            this.Controls.Add(this.lblCurrentProgress);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.progressBar);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "ProcessingForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "Autoclicker execution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
        private MaterialSkin.Controls.MaterialLabel lblHint;
        private MaterialSkin.Controls.MaterialLabel lblCurrentProgress;
        private MaterialSkin.Controls.MaterialLabel lblProgressVal;
        private MaterialSkin.Controls.MaterialLabel n;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblCurrentCt;
        private MaterialSkin.Controls.MaterialLabel r;
        private Controls.CursorControl cursorControlCurrent;
        private Controls.CursorControl cursorControlNext;
    }
}