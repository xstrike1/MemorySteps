using MemoryStepsCore.Config;
using MemoryStepsCore.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStepsUI.Controls
{
    public class MemoryMaterialCard : MaterialSkin.Controls.MaterialCard
    {
        private readonly Color KnownControlColor = Color.FromArgb(53,165,240);
        private readonly Color UndefinedControlColor = Color.FromArgb(77,106,163);
        private bool _hostedControlTypeIsKnown = true;
        public MemoryMaterialCard() 
        {
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            BackColor = _hostedControlTypeIsKnown ? KnownControlColor : UndefinedControlColor;
        }

        public void SetCardColor(CursorEntity cursor)
        {
            _hostedControlTypeIsKnown = cursor.ControlType != AppConfig.Config.Undefined;
            OnBackColorChanged(EventArgs.Empty);
        }
    }
}
