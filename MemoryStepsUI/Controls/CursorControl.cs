using MemoryStepsCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryStepsUI.Controls
{
    public partial class CursorControl : UserControl
    {
        public CursorEntity CursorEntity;
        public event Action<CursorControl> CardClicked;
        public CursorControl()
        {
            InitializeComponent();
            HideAllArrows();

            pBRightArrow.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
        }

        public void InitCursorAction(CursorEntity cursor, bool verticalDisplay = false, bool isLastElement = false) 
        {
            CursorEntity = cursor;
            RefreshDisplayValues();

            if (isLastElement)
            {
                HideAllArrows();
                return;
            }
            if (verticalDisplay)
            {
                lblRightDuration.Visible = true;
                pBRightArrow.Visible = true;
            }
            else
            {
                lblDownDuration.Visible = true;
                pBDownArrow.Visible = true;
            }
        }

        public void RefreshDisplayValues() 
        {
            cardCursor.SetCardColor(CursorEntity);
            cardCursor.Refresh();

            lblCursorActionNumber.Text = "#"+CursorEntity.CursorNumber.ToString();
            lblCursorActionType.Text = CursorEntity.ControlType;
            lblCursorActionName.Text = CursorEntity.ControlName;
            lblRightDuration.Text =  lblDownDuration.Text = CursorEntity.MilisecondsToNextCursor.ToString() + " ms";
        }

        private void Card_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this);
        }

        private void HideAllArrows() 
        {
            lblRightDuration.Visible = false;
            pBRightArrow.Visible = false;
            lblDownDuration.Visible = false;
            pBDownArrow.Visible = false;
        }
    }
}
