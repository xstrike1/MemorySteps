using MemoryStepsCore.Models;
using Microsoft.Test.Input;
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
    public partial class CursorEditorControl : UserControl
    {
        private CursorControl _target;

        private static IReadOnlyDictionary<char, string> s_KnownControls = new Dictionary<char, string>() {
                { '\0', "\\0"},
                { '\a', "\\a"},
                { '\b', "\\b"},
                { '\n', "\\n"},
                { '\v', "\\v"},
                { '\t', "\\t"},
                { '\f', "\\f"},
                { '\r', "\\r"},
              };

        public CursorEditorControl()
        {
            InitializeComponent();
        }


        public void EditCursor(CursorControl cc)
        {
            CursorEntity cursor = cc.CursorEntity;
            _target = cc;

            lblCursorActionNumber.Text = "#" + cursor.CursorNumber;
            tBTimeToNext.Text = cursor.MilisecondsToNextCursor.ToString();
            tbCtrlType.Text = cursor.ControlType;
            tbCtrlName.Text = cursor.ControlName;
            cbMouseButton.SelectedIndex = (int)cursor.ButtonPressed;
            cbMouseButton.Refresh();
            cBDoubleClick.Checked = cursor.DoubleClick;
            tbPOsY.Text = cursor.Position.Y.ToString();
            tbPosX.Text = cursor.Position.X.ToString();

            StringBuilder sb = new();

            foreach (var c in cursor.PressedCharacters.Values)
            {
                if (char.IsControl(c))
                    sb.Append(s_KnownControls.TryGetValue(c, out var s)
                      ? s
                      : $"\\u{((int)c):x4}");
                else
                {
                    if (c == '"' || c == '\\')
                        sb.Append('\\');

                    sb.Append(c);
                }
            }
            tbCharacters.Text = sb.ToString();

            btnApply.Enabled = false;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            CursorEntity cursor = _target.CursorEntity;
            bool resultIsValid = Int64.TryParse(tBTimeToNext.Text, out long result);
            if (resultIsValid)
                cursor.MilisecondsToNextCursor = result;
            cursor.ControlType = tbCtrlType.Text;
            cursor.ControlName = tbCtrlName.Text;
            cursor.ButtonPressed = (MouseButton)cbMouseButton.SelectedIndex;
            cursor.DoubleClick = cBDoubleClick.Checked;
            cursor.Position = new Point(TryConvertToInt(cursor.Position.X, tbPosX.Text), TryConvertToInt(cursor.Position.Y, tbPOsY.Text));
            try
            {
                var firstCharacter = cursor.PressedCharacters.Keys.FirstOrDefault();
                if (firstCharacter == 0)
                    firstCharacter = cursor.MilisecondsToNextCursor / 2;

                char[] arr = tbCharacters.Text.ToCharArray();
                cursor.PressedCharacters = new Dictionary<long, char>();
                foreach (var c in arr) 
                {
                    cursor.PressedCharacters.Add(firstCharacter, c);
                    firstCharacter++;
                }
            }
            catch { }

            btnApply.Enabled = false;
            _target.RefreshDisplayValues();
        }

        private static int TryConvertToInt(int initialValue, string text) 
        {
            if (Int32.TryParse(text, out int result))
                return result;

            return initialValue;
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }
    }
}
