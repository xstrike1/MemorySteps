
namespace MemoryStepsUI.Controls
{
    partial class CursorEditorControl
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
            this.memoryMaterialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tbCharacters = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPOsY = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPosX = new MaterialSkin.Controls.MaterialTextBox();
            this.cBDoubleClick = new MaterialSkin.Controls.MaterialCheckbox();
            this.cbMouseButton = new MaterialSkin.Controls.MaterialComboBox();
            this.tbCtrlName = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCtrlType = new MaterialSkin.Controls.MaterialTextBox();
            this.btnApply = new MaterialSkin.Controls.MaterialButton();
            this.lblChars = new MaterialSkin.Controls.MaterialLabel();
            this.lblCtrlName = new MaterialSkin.Controls.MaterialLabel();
            this.lblCtrlType = new MaterialSkin.Controls.MaterialLabel();
            this.lblDoubleClick = new MaterialSkin.Controls.MaterialLabel();
            this.lblMouseButton = new MaterialSkin.Controls.MaterialLabel();
            this.lblPosY = new MaterialSkin.Controls.MaterialLabel();
            this.lblPosX = new MaterialSkin.Controls.MaterialLabel();
            this.lblTimeToNext = new MaterialSkin.Controls.MaterialLabel();
            this.tBTimeToNext = new MaterialSkin.Controls.MaterialTextBox();
            this.lblCursorActionNumber = new MaterialSkin.Controls.MaterialLabel();
            this.lblCursorTitle = new MaterialSkin.Controls.MaterialLabel();
            this.memoryMaterialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // memoryMaterialCard1
            // 
            this.memoryMaterialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.memoryMaterialCard1.Controls.Add(this.tbCharacters);
            this.memoryMaterialCard1.Controls.Add(this.tbPOsY);
            this.memoryMaterialCard1.Controls.Add(this.tbPosX);
            this.memoryMaterialCard1.Controls.Add(this.cBDoubleClick);
            this.memoryMaterialCard1.Controls.Add(this.cbMouseButton);
            this.memoryMaterialCard1.Controls.Add(this.tbCtrlName);
            this.memoryMaterialCard1.Controls.Add(this.tbCtrlType);
            this.memoryMaterialCard1.Controls.Add(this.btnApply);
            this.memoryMaterialCard1.Controls.Add(this.lblChars);
            this.memoryMaterialCard1.Controls.Add(this.lblCtrlName);
            this.memoryMaterialCard1.Controls.Add(this.lblCtrlType);
            this.memoryMaterialCard1.Controls.Add(this.lblDoubleClick);
            this.memoryMaterialCard1.Controls.Add(this.lblMouseButton);
            this.memoryMaterialCard1.Controls.Add(this.lblPosY);
            this.memoryMaterialCard1.Controls.Add(this.lblPosX);
            this.memoryMaterialCard1.Controls.Add(this.lblTimeToNext);
            this.memoryMaterialCard1.Controls.Add(this.tBTimeToNext);
            this.memoryMaterialCard1.Controls.Add(this.lblCursorActionNumber);
            this.memoryMaterialCard1.Controls.Add(this.lblCursorTitle);
            this.memoryMaterialCard1.Depth = 0;
            this.memoryMaterialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.memoryMaterialCard1.Location = new System.Drawing.Point(4, 3);
            this.memoryMaterialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.memoryMaterialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.memoryMaterialCard1.Name = "memoryMaterialCard1";
            this.memoryMaterialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.memoryMaterialCard1.Size = new System.Drawing.Size(398, 464);
            this.memoryMaterialCard1.TabIndex = 0;
            // 
            // tbCharacters
            // 
            this.tbCharacters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCharacters.Depth = 0;
            this.tbCharacters.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCharacters.LeadingIcon = null;
            this.tbCharacters.Location = new System.Drawing.Point(159, 362);
            this.tbCharacters.MaxLength = 50;
            this.tbCharacters.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCharacters.Multiline = false;
            this.tbCharacters.Name = "tbCharacters";
            this.tbCharacters.Size = new System.Drawing.Size(226, 50);
            this.tbCharacters.TabIndex = 18;
            this.tbCharacters.Text = "";
            this.tbCharacters.TrailingIcon = null;
            this.tbCharacters.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tbPOsY
            // 
            this.tbPOsY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPOsY.Depth = 0;
            this.tbPOsY.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPOsY.LeadingIcon = null;
            this.tbPOsY.Location = new System.Drawing.Point(303, 302);
            this.tbPOsY.MaxLength = 50;
            this.tbPOsY.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPOsY.Multiline = false;
            this.tbPOsY.Name = "tbPOsY";
            this.tbPOsY.Size = new System.Drawing.Size(82, 50);
            this.tbPOsY.TabIndex = 17;
            this.tbPOsY.Text = "";
            this.tbPOsY.TrailingIcon = null;
            this.tbPOsY.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tbPosX
            // 
            this.tbPosX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPosX.Depth = 0;
            this.tbPosX.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPosX.LeadingIcon = null;
            this.tbPosX.Location = new System.Drawing.Point(159, 302);
            this.tbPosX.MaxLength = 50;
            this.tbPosX.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPosX.Multiline = false;
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(83, 50);
            this.tbPosX.TabIndex = 16;
            this.tbPosX.Text = "";
            this.tbPosX.TrailingIcon = null;
            this.tbPosX.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // cBDoubleClick
            // 
            this.cBDoubleClick.AutoSize = true;
            this.cBDoubleClick.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cBDoubleClick.Depth = 0;
            this.cBDoubleClick.Location = new System.Drawing.Point(152, 262);
            this.cBDoubleClick.Margin = new System.Windows.Forms.Padding(0);
            this.cBDoubleClick.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cBDoubleClick.MouseState = MaterialSkin.MouseState.HOVER;
            this.cBDoubleClick.Name = "cBDoubleClick";
            this.cBDoubleClick.Ripple = true;
            this.cBDoubleClick.Size = new System.Drawing.Size(35, 37);
            this.cBDoubleClick.TabIndex = 15;
            this.cBDoubleClick.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cBDoubleClick.UseVisualStyleBackColor = true;
            this.cBDoubleClick.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // cbMouseButton
            // 
            this.cbMouseButton.AutoResize = false;
            this.cbMouseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbMouseButton.Depth = 0;
            this.cbMouseButton.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbMouseButton.DropDownHeight = 174;
            this.cbMouseButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMouseButton.DropDownWidth = 121;
            this.cbMouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbMouseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbMouseButton.FormattingEnabled = true;
            this.cbMouseButton.IntegralHeight = false;
            this.cbMouseButton.ItemHeight = 43;
            this.cbMouseButton.Items.AddRange(new object[] {
            "Left mouse button",
            "Middle mouse button",
            "Right mouse button",
            "XButton1",
            "XButton2"});
            this.cbMouseButton.Location = new System.Drawing.Point(159, 209);
            this.cbMouseButton.MaxDropDownItems = 4;
            this.cbMouseButton.MouseState = MaterialSkin.MouseState.OUT;
            this.cbMouseButton.Name = "cbMouseButton";
            this.cbMouseButton.Size = new System.Drawing.Size(226, 49);
            this.cbMouseButton.StartIndex = 0;
            this.cbMouseButton.TabIndex = 14;
            this.cbMouseButton.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tbCtrlName
            // 
            this.tbCtrlName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCtrlName.Depth = 0;
            this.tbCtrlName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCtrlName.LeadingIcon = null;
            this.tbCtrlName.Location = new System.Drawing.Point(159, 149);
            this.tbCtrlName.MaxLength = 50;
            this.tbCtrlName.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCtrlName.Multiline = false;
            this.tbCtrlName.Name = "tbCtrlName";
            this.tbCtrlName.Size = new System.Drawing.Size(226, 50);
            this.tbCtrlName.TabIndex = 13;
            this.tbCtrlName.Text = "";
            this.tbCtrlName.TrailingIcon = null;
            this.tbCtrlName.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tbCtrlType
            // 
            this.tbCtrlType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCtrlType.Depth = 0;
            this.tbCtrlType.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCtrlType.LeadingIcon = null;
            this.tbCtrlType.Location = new System.Drawing.Point(159, 89);
            this.tbCtrlType.MaxLength = 50;
            this.tbCtrlType.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCtrlType.Multiline = false;
            this.tbCtrlType.Name = "tbCtrlType";
            this.tbCtrlType.Size = new System.Drawing.Size(226, 50);
            this.tbCtrlType.TabIndex = 12;
            this.tbCtrlType.Text = "";
            this.tbCtrlType.TrailingIcon = null;
            this.tbCtrlType.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // btnApply
            // 
            this.btnApply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApply.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnApply.Depth = 0;
            this.btnApply.HighEmphasis = true;
            this.btnApply.Icon = null;
            this.btnApply.Location = new System.Drawing.Point(321, 421);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnApply.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(67, 36);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply";
            this.btnApply.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnApply.UseAccentColor = false;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lblChars
            // 
            this.lblChars.AutoSize = true;
            this.lblChars.Depth = 0;
            this.lblChars.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblChars.Location = new System.Drawing.Point(10, 389);
            this.lblChars.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblChars.Name = "lblChars";
            this.lblChars.Size = new System.Drawing.Size(77, 19);
            this.lblChars.TabIndex = 10;
            this.lblChars.Text = "Characters";
            // 
            // lblCtrlName
            // 
            this.lblCtrlName.AutoSize = true;
            this.lblCtrlName.Depth = 0;
            this.lblCtrlName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCtrlName.Location = new System.Drawing.Point(10, 176);
            this.lblCtrlName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCtrlName.Name = "lblCtrlName";
            this.lblCtrlName.Size = new System.Drawing.Size(96, 19);
            this.lblCtrlName.TabIndex = 9;
            this.lblCtrlName.Text = "Control name";
            // 
            // lblCtrlType
            // 
            this.lblCtrlType.AutoSize = true;
            this.lblCtrlType.Depth = 0;
            this.lblCtrlType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCtrlType.Location = new System.Drawing.Point(10, 118);
            this.lblCtrlType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCtrlType.Name = "lblCtrlType";
            this.lblCtrlType.Size = new System.Drawing.Size(86, 19);
            this.lblCtrlType.TabIndex = 8;
            this.lblCtrlType.Text = "Control type";
            // 
            // lblDoubleClick
            // 
            this.lblDoubleClick.AutoSize = true;
            this.lblDoubleClick.Depth = 0;
            this.lblDoubleClick.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDoubleClick.Location = new System.Drawing.Point(9, 280);
            this.lblDoubleClick.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDoubleClick.Name = "lblDoubleClick";
            this.lblDoubleClick.Size = new System.Drawing.Size(87, 19);
            this.lblDoubleClick.TabIndex = 7;
            this.lblDoubleClick.Text = "Double click";
            // 
            // lblMouseButton
            // 
            this.lblMouseButton.AutoSize = true;
            this.lblMouseButton.Depth = 0;
            this.lblMouseButton.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMouseButton.Location = new System.Drawing.Point(10, 235);
            this.lblMouseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMouseButton.Name = "lblMouseButton";
            this.lblMouseButton.Size = new System.Drawing.Size(99, 19);
            this.lblMouseButton.TabIndex = 6;
            this.lblMouseButton.Text = "Mouse button";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Depth = 0;
            this.lblPosY.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPosY.Location = new System.Drawing.Point(9, 325);
            this.lblPosY.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(137, 19);
            this.lblPosY.TabIndex = 5;
            this.lblPosY.Text = "Position                 X";
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Depth = 0;
            this.lblPosX.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPosX.Location = new System.Drawing.Point(277, 325);
            this.lblPosX.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(11, 19);
            this.lblPosX.TabIndex = 4;
            this.lblPosX.Text = "Y";
            // 
            // lblTimeToNext
            // 
            this.lblTimeToNext.AutoSize = true;
            this.lblTimeToNext.Depth = 0;
            this.lblTimeToNext.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTimeToNext.Location = new System.Drawing.Point(9, 56);
            this.lblTimeToNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTimeToNext.Name = "lblTimeToNext";
            this.lblTimeToNext.Size = new System.Drawing.Size(141, 19);
            this.lblTimeToNext.TabIndex = 3;
            this.lblTimeToNext.Text = "Delay to next action";
            // 
            // tBTimeToNext
            // 
            this.tBTimeToNext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBTimeToNext.Depth = 0;
            this.tBTimeToNext.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tBTimeToNext.LeadingIcon = null;
            this.tBTimeToNext.Location = new System.Drawing.Point(159, 29);
            this.tBTimeToNext.MaxLength = 50;
            this.tBTimeToNext.MouseState = MaterialSkin.MouseState.OUT;
            this.tBTimeToNext.Multiline = false;
            this.tBTimeToNext.Name = "tBTimeToNext";
            this.tBTimeToNext.Size = new System.Drawing.Size(226, 50);
            this.tBTimeToNext.TabIndex = 2;
            this.tBTimeToNext.Text = "";
            this.tBTimeToNext.TrailingIcon = null;
            this.tBTimeToNext.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // lblCursorActionNumber
            // 
            this.lblCursorActionNumber.AutoSize = true;
            this.lblCursorActionNumber.Depth = 0;
            this.lblCursorActionNumber.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCursorActionNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCursorActionNumber.Location = new System.Drawing.Point(357, 3);
            this.lblCursorActionNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCursorActionNumber.Name = "lblCursorActionNumber";
            this.lblCursorActionNumber.Size = new System.Drawing.Size(13, 24);
            this.lblCursorActionNumber.TabIndex = 1;
            this.lblCursorActionNumber.Text = "#";
            // 
            // lblCursorTitle
            // 
            this.lblCursorTitle.AutoSize = true;
            this.lblCursorTitle.Depth = 0;
            this.lblCursorTitle.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblCursorTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblCursorTitle.Location = new System.Drawing.Point(8, 6);
            this.lblCursorTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCursorTitle.Name = "lblCursorTitle";
            this.lblCursorTitle.Size = new System.Drawing.Size(120, 24);
            this.lblCursorTitle.TabIndex = 0;
            this.lblCursorTitle.Text = "Cursor action";
            // 
            // CursorEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memoryMaterialCard1);
            this.Name = "CursorEditorControl";
            this.Size = new System.Drawing.Size(417, 478);
            this.memoryMaterialCard1.ResumeLayout(false);
            this.memoryMaterialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard memoryMaterialCard1;
        private MaterialSkin.Controls.MaterialLabel lblCursorTitle;
        private MaterialSkin.Controls.MaterialLabel lblPosY;
        private MaterialSkin.Controls.MaterialLabel lblPosX;
        private MaterialSkin.Controls.MaterialLabel lblTimeToNext;
        private MaterialSkin.Controls.MaterialTextBox tBTimeToNext;
        private MaterialSkin.Controls.MaterialLabel lblCursorActionNumber;
        private MaterialSkin.Controls.MaterialButton btnApply;
        private MaterialSkin.Controls.MaterialLabel lblChars;
        private MaterialSkin.Controls.MaterialLabel lblCtrlName;
        private MaterialSkin.Controls.MaterialLabel lblCtrlType;
        private MaterialSkin.Controls.MaterialLabel lblDoubleClick;
        private MaterialSkin.Controls.MaterialLabel lblMouseButton;
        private MaterialSkin.Controls.MaterialTextBox tbCtrlName;
        private MaterialSkin.Controls.MaterialTextBox tbCtrlType;
        private MaterialSkin.Controls.MaterialComboBox cbMouseButton;
        private MaterialSkin.Controls.MaterialTextBox tbPOsY;
        private MaterialSkin.Controls.MaterialTextBox tbPosX;
        private MaterialSkin.Controls.MaterialCheckbox cBDoubleClick;
        private MaterialSkin.Controls.MaterialTextBox tbCharacters;
    }
}
