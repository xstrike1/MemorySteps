
namespace MemoryStepsUI.Controls
{
    partial class CursorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardCursor = new MemoryStepsUI.Controls.MemoryMaterialCard();
            this.lblCursorActionName = new MaterialSkin.Controls.MaterialLabel();
            this.lblCursorActionNumber = new MaterialSkin.Controls.MaterialLabel();
            this.lblCursorActionType = new MaterialSkin.Controls.MaterialLabel();
            this.lblCursorActionTitle = new MaterialSkin.Controls.MaterialLabel();
            this.pBDownArrow = new System.Windows.Forms.PictureBox();
            this.lblDownDuration = new MaterialSkin.Controls.MaterialLabel();
            this.pBRightArrow = new System.Windows.Forms.PictureBox();
            this.lblRightDuration = new MaterialSkin.Controls.MaterialLabel();
            this.cardCursor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDownArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRightArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // cardCursor
            // 
            this.cardCursor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            this.cardCursor.Controls.Add(this.lblCursorActionName);
            this.cardCursor.Controls.Add(this.lblCursorActionNumber);
            this.cardCursor.Controls.Add(this.lblCursorActionType);
            this.cardCursor.Controls.Add(this.lblCursorActionTitle);
            this.cardCursor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardCursor.Depth = 0;
            this.cardCursor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardCursor.Location = new System.Drawing.Point(11, 2);
            this.cardCursor.Margin = new System.Windows.Forms.Padding(14);
            this.cardCursor.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardCursor.Name = "cardCursor";
            this.cardCursor.Padding = new System.Windows.Forms.Padding(14);
            this.cardCursor.Size = new System.Drawing.Size(198, 66);
            this.cardCursor.TabIndex = 0;
            this.cardCursor.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblCursorActionName
            // 
            this.lblCursorActionName.AutoSize = true;
            this.lblCursorActionName.Depth = 0;
            this.lblCursorActionName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCursorActionName.Location = new System.Drawing.Point(7, 44);
            this.lblCursorActionName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCursorActionName.Name = "lblCursorActionName";
            this.lblCursorActionName.Size = new System.Drawing.Size(96, 19);
            this.lblCursorActionName.TabIndex = 3;
            this.lblCursorActionName.Text = "Control name";
            // 
            // lblCursorActionNumber
            // 
            this.lblCursorActionNumber.AutoSize = true;
            this.lblCursorActionNumber.Depth = 0;
            this.lblCursorActionNumber.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCursorActionNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCursorActionNumber.Location = new System.Drawing.Point(168, 2);
            this.lblCursorActionNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCursorActionNumber.Name = "lblCursorActionNumber";
            this.lblCursorActionNumber.Size = new System.Drawing.Size(13, 24);
            this.lblCursorActionNumber.TabIndex = 2;
            this.lblCursorActionNumber.Text = "#";
            // 
            // lblCursorActionType
            // 
            this.lblCursorActionType.AutoSize = true;
            this.lblCursorActionType.Depth = 0;
            this.lblCursorActionType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCursorActionType.Location = new System.Drawing.Point(7, 25);
            this.lblCursorActionType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCursorActionType.Name = "lblCursorActionType";
            this.lblCursorActionType.Size = new System.Drawing.Size(86, 19);
            this.lblCursorActionType.TabIndex = 1;
            this.lblCursorActionType.Text = "Control type";
            // 
            // lblCursorActionTitle
            // 
            this.lblCursorActionTitle.AutoSize = true;
            this.lblCursorActionTitle.Depth = 0;
            this.lblCursorActionTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCursorActionTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCursorActionTitle.Location = new System.Drawing.Point(7, 2);
            this.lblCursorActionTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCursorActionTitle.Name = "lblCursorActionTitle";
            this.lblCursorActionTitle.Size = new System.Drawing.Size(120, 24);
            this.lblCursorActionTitle.TabIndex = 0;
            this.lblCursorActionTitle.Text = "Cursor action";
            // 
            // pBDownArrow
            // 
            this.pBDownArrow.Image = global::MemoryStepsUI.Properties.Resources.arrow_Next;
            this.pBDownArrow.Location = new System.Drawing.Point(70, 89);
            this.pBDownArrow.Name = "pBDownArrow";
            this.pBDownArrow.Size = new System.Drawing.Size(71, 58);
            this.pBDownArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBDownArrow.TabIndex = 1;
            this.pBDownArrow.TabStop = false;
            // 
            // lblDownDuration
            // 
            this.lblDownDuration.AutoSize = true;
            this.lblDownDuration.Depth = 0;
            this.lblDownDuration.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDownDuration.Location = new System.Drawing.Point(82, 71);
            this.lblDownDuration.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDownDuration.Name = "lblDownDuration";
            this.lblDownDuration.Size = new System.Drawing.Size(67, 19);
            this.lblDownDuration.TabIndex = 2;
            this.lblDownDuration.Text = "#### ms";
            // 
            // pBRightArrow
            // 
            this.pBRightArrow.Image = global::MemoryStepsUI.Properties.Resources.arrow_Next;
            this.pBRightArrow.Location = new System.Drawing.Point(266, 10);
            this.pBRightArrow.Name = "pBRightArrow";
            this.pBRightArrow.Size = new System.Drawing.Size(71, 58);
            this.pBRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBRightArrow.TabIndex = 1;
            this.pBRightArrow.TabStop = false;
            // 
            // lblRightDuration
            // 
            this.lblRightDuration.AutoSize = true;
            this.lblRightDuration.Depth = 0;
            this.lblRightDuration.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRightDuration.Location = new System.Drawing.Point(213, 30);
            this.lblRightDuration.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRightDuration.Name = "lblRightDuration";
            this.lblRightDuration.Size = new System.Drawing.Size(67, 19);
            this.lblRightDuration.TabIndex = 3;
            this.lblRightDuration.Text = "#### ms";
            // 
            // CursorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRightDuration);
            this.Controls.Add(this.lblDownDuration);
            this.Controls.Add(this.pBRightArrow);
            this.Controls.Add(this.pBDownArrow);
            this.Controls.Add(this.cardCursor);
            this.Name = "CursorControl";
            this.Size = new System.Drawing.Size(342, 150);
            this.cardCursor.ResumeLayout(false);
            this.cardCursor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBDownArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRightArrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MemoryMaterialCard cardCursor;
        private MaterialSkin.Controls.MaterialLabel lblCursorActionTitle;
        private MaterialSkin.Controls.MaterialLabel lblCursorActionType;
        private MaterialSkin.Controls.MaterialLabel lblCursorActionName;
        private MaterialSkin.Controls.MaterialLabel lblCursorActionNumber;
        private System.Windows.Forms.PictureBox pBDownArrow;
        private MaterialSkin.Controls.MaterialLabel lblDownDuration;
        private System.Windows.Forms.PictureBox pBRightArrow;
        private MaterialSkin.Controls.MaterialLabel lblRightDuration;
    }
}
