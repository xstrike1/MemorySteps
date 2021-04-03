
namespace MemoryStepsUI.UI
{
    partial class CursorCofingForm
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
            this.btnStartConfig = new System.Windows.Forms.Button();
            this.btnStartClick = new System.Windows.Forms.Button();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnStartConfig
            // 
            this.btnStartConfig.Location = new System.Drawing.Point(39, 120);
            this.btnStartConfig.Name = "btnStartConfig";
            this.btnStartConfig.Size = new System.Drawing.Size(104, 54);
            this.btnStartConfig.TabIndex = 0;
            this.btnStartConfig.Text = "Start manual configuration";
            this.btnStartConfig.UseVisualStyleBackColor = true;
            this.btnStartConfig.Click += new System.EventHandler(this.btnStartConfig_Click);
            // 
            // btnStartClick
            // 
            this.btnStartClick.Location = new System.Drawing.Point(258, 125);
            this.btnStartClick.Name = "btnStartClick";
            this.btnStartClick.Size = new System.Drawing.Size(94, 49);
            this.btnStartClick.TabIndex = 1;
            this.btnStartClick.Text = "Start Autoclicker";
            this.btnStartClick.UseVisualStyleBackColor = true;
            this.btnStartClick.Click += new System.EventHandler(this.btnStartClick_Click);
            // 
            // rtbStatus
            // 
            this.rtbStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rtbStatus.Location = new System.Drawing.Point(39, 12);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(313, 102);
            this.rtbStatus.TabIndex = 3;
            this.rtbStatus.Text = "";
            // 
            // CursorCofingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(386, 211);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.btnStartClick);
            this.Controls.Add(this.btnStartConfig);
            this.Name = "CursorCofingForm";
            this.Text = "Autoclicker config";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartConfig;
        private System.Windows.Forms.Button btnStartClick;
        private System.Windows.Forms.RichTextBox rtbStatus;
    }
}