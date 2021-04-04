using MaterialSkin.Controls;
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

        public MaterialLabel lblStep;
        public MaterialTextBox txtStepDesc;
        public MaterialCheckbox btnRepeat;
        public MaterialButton btnRoute;

        public string StepDescription 
        {
            get { return txtStepDesc.Text; }
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
            controlList.Add(lblStep);
            controlList.Add(txtStepDesc);
            controlList.Add(btnRepeat);
            controlList.Add(btnRoute);
            return controlList;
        }
 
        private void InitStyle(bool mouseCheck) 
        {
            InitTextBoxDescription();
            InitLabelStep();
            InitRepeatCheckBox();
            InitRouteButton();

        }

        private void InitTextBoxDescription()
        {
            txtStepDesc = new MaterialSkin.Controls.MaterialTextBox();
            txtStepDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtStepDesc.Depth = 0;
            txtStepDesc.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtStepDesc.Location = new System.Drawing.Point(145, 106 + (StepNumber * 70));
            txtStepDesc.MaxLength = 50;
            txtStepDesc.MouseState = MaterialSkin.MouseState.OUT;
            txtStepDesc.Multiline = false;
            txtStepDesc.Name = "txtStepDesc"+ StepNumber;
            txtStepDesc.Size = new System.Drawing.Size(360, 36);
            txtStepDesc.TabIndex = 17;
            txtStepDesc.Text = "";
            txtStepDesc.UseTallSize = false;
        }

        private void InitLabelStep() 
        {
            lblStep = new MaterialSkin.Controls.MaterialLabel();
            lblStep.AutoSize = true;
            lblStep.Depth = 0;
            lblStep.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            lblStep.Location = new System.Drawing.Point(44, 120 + (StepNumber * 70));
            lblStep.MouseState = MaterialSkin.MouseState.HOVER;
            lblStep.Name = "lblStep"+StepNumber;
            lblStep.Size = new System.Drawing.Size(46, 19);
            lblStep.TabIndex = 15;
            lblStep.Text = "Step "+ StepNumber;
        }

        private void InitRepeatCheckBox() 
        {
            btnRepeat = new MaterialSkin.Controls.MaterialCheckbox();
            btnRepeat.AutoSize = true;
            btnRepeat.Depth = 0;
            btnRepeat.Location = new System.Drawing.Point(526, 106 + (StepNumber * 70));
            btnRepeat.Margin = new System.Windows.Forms.Padding(0);
            btnRepeat.MouseLocation = new System.Drawing.Point(-1, -1);
            btnRepeat.MouseState = MaterialSkin.MouseState.HOVER;
            btnRepeat.Name = "btnRepeat"+StepNumber;
            btnRepeat.Ripple = true;
            btnRepeat.Size = new System.Drawing.Size(84, 37);
            btnRepeat.TabIndex = 18;
            btnRepeat.Text = "Repeat";
            btnRepeat.UseVisualStyleBackColor = true;
        }

        private void InitRouteButton()
        {
            btnRoute = new MaterialSkin.Controls.MaterialButton();
            btnRoute.AutoSize = false;
            btnRoute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnRoute.Depth = 0;
            btnRoute.DrawShadows = true;
            btnRoute.HighEmphasis = true;
            btnRoute.Icon = null;
            btnRoute.Location = new System.Drawing.Point(650, 108 + (StepNumber * 70));
            btnRoute.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnRoute.MouseState = MaterialSkin.MouseState.HOVER;
            btnRoute.Name = "btnRoute"+StepNumber;
            btnRoute.Size = new System.Drawing.Size(132, 37);
            btnRoute.TabIndex = 19;
            btnRoute.Text = "Route";
            btnRoute.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRoute.UseAccentColor = false;
            btnRoute.UseVisualStyleBackColor = true;
        }
    }
}
