
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
            this.lblCurrentCursorTitle = new MaterialSkin.Controls.MaterialLabel();
            this.lblNextCursorTitle = new MaterialSkin.Controls.MaterialLabel();
            this.cardNext = new MaterialSkin.Controls.MaterialCard();
            this.lblNextDuration = new MaterialSkin.Controls.MaterialLabel();
            this.lblNextPos = new MaterialSkin.Controls.MaterialLabel();
            this.lblNextName = new MaterialSkin.Controls.MaterialLabel();
            this.lblNextType = new MaterialSkin.Controls.MaterialLabel();
            this.cardCurrent = new MaterialSkin.Controls.MaterialCard();
            this.lblCurrentDuration = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentPos = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentName = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentType = new MaterialSkin.Controls.MaterialLabel();
            this.cardNext.SuspendLayout();
            this.cardCurrent.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Depth = 0;
            this.progressBar.Location = new System.Drawing.Point(467, 96);
            this.progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(323, 5);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            this.progressBar.Visible = false;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Depth = 0;
            this.lblHint.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHint.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblHint.Location = new System.Drawing.Point(28, 7);
            this.lblHint.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(381, 29);
            this.lblHint.TabIndex = 2;
            this.lblHint.Text = "To cancel current execution press x";
            // 
            // lblCurrentProgress
            // 
            this.lblCurrentProgress.AutoSize = true;
            this.lblCurrentProgress.Depth = 0;
            this.lblCurrentProgress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentProgress.Location = new System.Drawing.Point(467, 55);
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
            this.lblProgressVal.Location = new System.Drawing.Point(771, 55);
            this.lblProgressVal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProgressVal.Name = "lblProgressVal";
            this.lblProgressVal.Size = new System.Drawing.Size(22, 19);
            this.lblProgressVal.TabIndex = 4;
            this.lblProgressVal.Text = "0%";
            this.lblProgressVal.Visible = false;
            // 
            // lblCurrentCursorTitle
            // 
            this.lblCurrentCursorTitle.AutoSize = true;
            this.lblCurrentCursorTitle.Depth = 0;
            this.lblCurrentCursorTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentCursorTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentCursorTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCurrentCursorTitle.Location = new System.Drawing.Point(4, 3);
            this.lblCurrentCursorTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentCursorTitle.Name = "lblCurrentCursorTitle";
            this.lblCurrentCursorTitle.Size = new System.Drawing.Size(100, 19);
            this.lblCurrentCursorTitle.TabIndex = 5;
            this.lblCurrentCursorTitle.Text = "Current action";
            // 
            // lblNextCursorTitle
            // 
            this.lblNextCursorTitle.AutoSize = true;
            this.lblNextCursorTitle.Depth = 0;
            this.lblNextCursorTitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNextCursorTitle.Location = new System.Drawing.Point(3, 5);
            this.lblNextCursorTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNextCursorTitle.Name = "lblNextCursorTitle";
            this.lblNextCursorTitle.Size = new System.Drawing.Size(81, 19);
            this.lblNextCursorTitle.TabIndex = 6;
            this.lblNextCursorTitle.Text = "Next action";
            // 
            // cardNext
            // 
            this.cardNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardNext.Controls.Add(this.lblNextDuration);
            this.cardNext.Controls.Add(this.lblNextPos);
            this.cardNext.Controls.Add(this.lblNextName);
            this.cardNext.Controls.Add(this.lblNextType);
            this.cardNext.Controls.Add(this.lblNextCursorTitle);
            this.cardNext.Depth = 0;
            this.cardNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardNext.Location = new System.Drawing.Point(244, 46);
            this.cardNext.Margin = new System.Windows.Forms.Padding(14);
            this.cardNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardNext.Name = "cardNext";
            this.cardNext.Padding = new System.Windows.Forms.Padding(14);
            this.cardNext.Size = new System.Drawing.Size(188, 111);
            this.cardNext.TabIndex = 7;
            this.cardNext.Visible = false;
            // 
            // lblNextDuration
            // 
            this.lblNextDuration.AutoSize = true;
            this.lblNextDuration.Depth = 0;
            this.lblNextDuration.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNextDuration.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblNextDuration.Location = new System.Drawing.Point(4, 85);
            this.lblNextDuration.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNextDuration.Name = "lblNextDuration";
            this.lblNextDuration.Size = new System.Drawing.Size(55, 17);
            this.lblNextDuration.TabIndex = 13;
            this.lblNextDuration.Text = "Duration";
            // 
            // lblNextPos
            // 
            this.lblNextPos.AutoSize = true;
            this.lblNextPos.Depth = 0;
            this.lblNextPos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNextPos.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblNextPos.Location = new System.Drawing.Point(4, 68);
            this.lblNextPos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNextPos.Name = "lblNextPos";
            this.lblNextPos.Size = new System.Drawing.Size(52, 17);
            this.lblNextPos.TabIndex = 12;
            this.lblNextPos.Text = "Position";
            // 
            // lblNextName
            // 
            this.lblNextName.AutoSize = true;
            this.lblNextName.Depth = 0;
            this.lblNextName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNextName.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblNextName.Location = new System.Drawing.Point(4, 51);
            this.lblNextName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNextName.Name = "lblNextName";
            this.lblNextName.Size = new System.Drawing.Size(85, 17);
            this.lblNextName.TabIndex = 11;
            this.lblNextName.Text = "Control name";
            // 
            // lblNextType
            // 
            this.lblNextType.AutoSize = true;
            this.lblNextType.Depth = 0;
            this.lblNextType.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNextType.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblNextType.Location = new System.Drawing.Point(4, 34);
            this.lblNextType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNextType.Name = "lblNextType";
            this.lblNextType.Size = new System.Drawing.Size(77, 17);
            this.lblNextType.TabIndex = 10;
            this.lblNextType.Text = "Control type";
            // 
            // cardCurrent
            // 
            this.cardCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardCurrent.Controls.Add(this.lblCurrentDuration);
            this.cardCurrent.Controls.Add(this.lblCurrentPos);
            this.cardCurrent.Controls.Add(this.lblCurrentName);
            this.cardCurrent.Controls.Add(this.lblCurrentType);
            this.cardCurrent.Controls.Add(this.lblCurrentCursorTitle);
            this.cardCurrent.Depth = 0;
            this.cardCurrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardCurrent.Location = new System.Drawing.Point(30, 46);
            this.cardCurrent.Margin = new System.Windows.Forms.Padding(14);
            this.cardCurrent.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardCurrent.Name = "cardCurrent";
            this.cardCurrent.Padding = new System.Windows.Forms.Padding(14);
            this.cardCurrent.Size = new System.Drawing.Size(188, 111);
            this.cardCurrent.TabIndex = 7;
            this.cardCurrent.Visible = false;
            // 
            // lblCurrentDuration
            // 
            this.lblCurrentDuration.AutoSize = true;
            this.lblCurrentDuration.Depth = 0;
            this.lblCurrentDuration.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentDuration.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblCurrentDuration.Location = new System.Drawing.Point(4, 83);
            this.lblCurrentDuration.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentDuration.Name = "lblCurrentDuration";
            this.lblCurrentDuration.Size = new System.Drawing.Size(55, 17);
            this.lblCurrentDuration.TabIndex = 9;
            this.lblCurrentDuration.Text = "Duration";
            // 
            // lblCurrentPos
            // 
            this.lblCurrentPos.AutoSize = true;
            this.lblCurrentPos.Depth = 0;
            this.lblCurrentPos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentPos.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblCurrentPos.Location = new System.Drawing.Point(4, 66);
            this.lblCurrentPos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentPos.Name = "lblCurrentPos";
            this.lblCurrentPos.Size = new System.Drawing.Size(52, 17);
            this.lblCurrentPos.TabIndex = 8;
            this.lblCurrentPos.Text = "Position";
            // 
            // lblCurrentName
            // 
            this.lblCurrentName.AutoSize = true;
            this.lblCurrentName.Depth = 0;
            this.lblCurrentName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentName.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblCurrentName.Location = new System.Drawing.Point(4, 49);
            this.lblCurrentName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentName.Name = "lblCurrentName";
            this.lblCurrentName.Size = new System.Drawing.Size(85, 17);
            this.lblCurrentName.TabIndex = 7;
            this.lblCurrentName.Text = "Control name";
            // 
            // lblCurrentType
            // 
            this.lblCurrentType.AutoSize = true;
            this.lblCurrentType.Depth = 0;
            this.lblCurrentType.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurrentType.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblCurrentType.Location = new System.Drawing.Point(4, 32);
            this.lblCurrentType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentType.Name = "lblCurrentType";
            this.lblCurrentType.Size = new System.Drawing.Size(77, 17);
            this.lblCurrentType.TabIndex = 6;
            this.lblCurrentType.Text = "Control type";
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 161);
            this.Controls.Add(this.cardCurrent);
            this.Controls.Add(this.cardNext);
            this.Controls.Add(this.lblProgressVal);
            this.Controls.Add(this.lblCurrentProgress);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.progressBar);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "ProcessingForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "Autoclicker execution";
            this.cardNext.ResumeLayout(false);
            this.cardNext.PerformLayout();
            this.cardCurrent.ResumeLayout(false);
            this.cardCurrent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
        private MaterialSkin.Controls.MaterialLabel lblHint;
        private MaterialSkin.Controls.MaterialLabel lblCurrentProgress;
        private MaterialSkin.Controls.MaterialLabel lblProgressVal;
        private MaterialSkin.Controls.MaterialLabel lblCurrentCursorTitle;
        private MaterialSkin.Controls.MaterialLabel lblNextCursorTitle;
        private MaterialSkin.Controls.MaterialCard cardNext;
        private MaterialSkin.Controls.MaterialCard cardCurrent;
        private MaterialSkin.Controls.MaterialLabel n;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblCurrentName;
        private MaterialSkin.Controls.MaterialLabel lblCurrentCt;
        private MaterialSkin.Controls.MaterialLabel lblCurrentType;
        private MaterialSkin.Controls.MaterialLabel lblCurrentDuration;
        private MaterialSkin.Controls.MaterialLabel lblCurrentPos;
        private MaterialSkin.Controls.MaterialLabel lblNextDuration;
        private MaterialSkin.Controls.MaterialLabel lblNextPos;
        private MaterialSkin.Controls.MaterialLabel lblNextName;
        private MaterialSkin.Controls.MaterialLabel lblNextType;
        private MaterialSkin.Controls.MaterialLabel r;
    }
}