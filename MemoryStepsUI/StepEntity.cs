using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStepsUI
{
    public class StepEntity
    {
        private int _stepNumber;
        public int StepNumber { get {return _stepNumber; } }
        public string StepDescription { get; set; }

        private TextBox _stepDescriptionTxt;
        public TextBox StepDescriptionTxt
        {
            get { return _stepDescriptionTxt; }
            set {  _stepDescriptionTxt = value; }
        }

        private CheckBox _stepIsReccursive;
        public CheckBox StepIsReccursive
        {
            get { return _stepIsReccursive; }
            set { _stepIsReccursive = value; }
        }
        private Label _stepLabel;
        public Label StepLabel
        {
            get { return _stepLabel; }
            set { _stepLabel = value; }
        }
        private StepEntity() { }
        public StepEntity(int stepNumber) 
        {
            _stepNumber = stepNumber;
            InitStyle();
        }

        private void InitStyle() 
        {
            _stepDescriptionTxt = new TextBox();
            _stepDescriptionTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            _stepDescriptionTxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            _stepDescriptionTxt.Location = new System.Drawing.Point(91, 49 + (StepNumber * 50));
            _stepDescriptionTxt.Name = "stepDesc" + StepNumber;
            _stepDescriptionTxt.Size = new System.Drawing.Size(228, 23);
            _stepDescriptionTxt.TabIndex = 2;
            _stepDescriptionTxt.Text = "";

            _stepLabel = new Label();
           _stepLabel.AutoSize = true;
           _stepLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
           _stepLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
           _stepLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
           _stepLabel.Location = new System.Drawing.Point(12, 51 + (StepNumber * 50));
            _stepLabel.Name = "labelS"+StepNumber;
           _stepLabel.Size = new System.Drawing.Size(54, 21);
           _stepLabel.TabIndex = 0;
           _stepLabel.Text = "Step "+ StepNumber;

            _stepIsReccursive = new CheckBox();
           _stepIsReccursive.AutoSize = true;
           _stepIsReccursive.ForeColor = System.Drawing.SystemColors.ButtonFace;
           _stepIsReccursive.Location = new System.Drawing.Point(339, 51 + (StepNumber * 50));
           _stepIsReccursive.Name = "ckbS"+StepNumber;
           _stepIsReccursive.Size = new System.Drawing.Size(82, 19);
           _stepIsReccursive.TabIndex = 3;
           _stepIsReccursive.Text = "Repeat";
           _stepIsReccursive.TextAlign = System.Drawing.ContentAlignment.TopLeft;
           _stepIsReccursive.UseVisualStyleBackColor = true;
            _stepIsReccursive.Checked = true;

        }
    }

}
