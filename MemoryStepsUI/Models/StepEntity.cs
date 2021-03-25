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

        private TextBox _stepDescriptionTxt;
        private Label _stepLabel;
        private TextBox _mouseClicksTxt;
        public string StepDescription 
        {
            get { return _stepDescriptionTxt.Text; }
        }

        public string MouseClicks 
        {
            get { return _mouseClicksTxt.Text; }
        }

        private StepEntity() { }

        public StepEntity(int stepNumber, bool mouseCheck) 
        {
            _stepNumber = stepNumber;
            InitStyle(mouseCheck);
        }

        public List<Control>  GetControlListForConfig()
        {
            List<Control> controlList = new List<Control>();
            controlList.Add(_stepDescriptionTxt);
            controlList.Add(_stepLabel);
            controlList.Add(_mouseClicksTxt);

            return controlList;
        }

        public void MouseClicksChanged(bool check) 
        {
            _mouseClicksTxt.Enabled = check;
        }

        private void InitStyle(bool mouseCheck) 
        {
            InitTextBoxDescription();
            InitLabelStep();
            InitTextBoxMouseCLicks(mouseCheck);
        }

        private void InitTextBoxDescription()
        {
            _stepDescriptionTxt = new TextBox();
            _stepDescriptionTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            _stepDescriptionTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            _stepDescriptionTxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            _stepDescriptionTxt.Location = new System.Drawing.Point(91, 69 + (StepNumber * 50));
            _stepDescriptionTxt.Name = "stepDesc" + StepNumber;
            _stepDescriptionTxt.Size = new System.Drawing.Size(314, 23);
            _stepDescriptionTxt.TabIndex = 2;
            _stepDescriptionTxt.Text = "";
        }

        private void InitLabelStep() 
        {
            _stepLabel = new Label();
            _stepLabel.AutoSize = true;
            _stepLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            _stepLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            _stepLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            _stepLabel.Location = new System.Drawing.Point(12, 71 + (StepNumber * 50));
            _stepLabel.Name = "labelS" + StepNumber;
            _stepLabel.Size = new System.Drawing.Size(54, 21);
            _stepLabel.TabIndex = 0;
            _stepLabel.Text = "Step " + StepNumber;
        }

        private void InitTextBoxMouseCLicks(bool mouseCheck)
        {
            _mouseClicksTxt = new TextBox();
            _mouseClicksTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            _mouseClicksTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            _mouseClicksTxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            _mouseClicksTxt.Location = new System.Drawing.Point(450, 71 + (StepNumber * 50));
            _mouseClicksTxt.MaxLength = 2;
            _mouseClicksTxt.Name = "txtClicks"+ StepNumber;
            _mouseClicksTxt.Size = new System.Drawing.Size(97, 27);
            _mouseClicksTxt.TabIndex = 2;
            _mouseClicksTxt.Text = "1";
            _mouseClicksTxt.Enabled = mouseCheck;
        }
    }
}
