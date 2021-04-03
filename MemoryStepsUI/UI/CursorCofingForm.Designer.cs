
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
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.btnLoadConfig = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartConfig
            // 
            this.btnStartConfig.Location = new System.Drawing.Point(244, 119);
            this.btnStartConfig.Name = "btnStartConfig";
            this.btnStartConfig.Size = new System.Drawing.Size(103, 54);
            this.btnStartConfig.TabIndex = 0;
            this.btnStartConfig.Text = "Start manual configuration";
            this.btnStartConfig.UseVisualStyleBackColor = true;
            this.btnStartConfig.Click += new System.EventHandler(this.btnStartConfig_Click);
            // 
            // rtbStatus
            // 
            this.rtbStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rtbStatus.Location = new System.Drawing.Point(30, 11);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(313, 102);
            this.rtbStatus.TabIndex = 3;
            this.rtbStatus.Text = "";
            // 
            // btnLoadConfig
            // 
            this.btnLoadConfig.Location = new System.Drawing.Point(30, 119);
            this.btnLoadConfig.Name = "btnLoadConfig";
            this.btnLoadConfig.Size = new System.Drawing.Size(93, 54);
            this.btnLoadConfig.TabIndex = 4;
            this.btnLoadConfig.Text = "Load configuration";
            this.btnLoadConfig.UseVisualStyleBackColor = true;
            this.btnLoadConfig.Click += new System.EventHandler(this.btnLoadConfig_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(141, 120);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(88, 53);
            this.btnSaveConfig.TabIndex = 5;
            this.btnSaveConfig.Text = "Save configuration";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // CursorCofingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(376, 205);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.btnLoadConfig);
            this.Controls.Add(this.rtbStatus);
            this.Controls.Add(this.btnStartConfig);
            this.Name = "CursorCofingForm";
            this.Text = "Autoclicker config";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartConfig;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Button btnLoadConfig;
        private System.Windows.Forms.Button btnSaveConfig;
    }
}