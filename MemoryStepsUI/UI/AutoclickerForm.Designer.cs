
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
            this.btnStartAutoclicker = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartAutoclicker
            // 
            this.btnStartAutoclicker.Location = new System.Drawing.Point(24, 64);
            this.btnStartAutoclicker.Name = "btnStartAutoclicker";
            this.btnStartAutoclicker.Size = new System.Drawing.Size(75, 23);
            this.btnStartAutoclicker.TabIndex = 0;
            this.btnStartAutoclicker.Text = "Start";
            this.btnStartAutoclicker.UseVisualStyleBackColor = true;
            this.btnStartAutoclicker.Click += new System.EventHandler(this.btnStartAutoclicker_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHint.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHint.Location = new System.Drawing.Point(24, 13);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(91, 21);
            this.lblHint.TabIndex = 1;
            this.lblHint.Text = "Placeholder";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(150, 64);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AutoclickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(378, 119);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnStartAutoclicker);
            this.Name = "AutoclickerForm";
            this.Text = "Autoclicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartAutoclicker;
        private System.Windows.Forms.Label lblHint;
        private System.Windows.Forms.Button btnExit;
    }
}