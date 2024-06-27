using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varianta7.Classes
{
    internal class Utils
    {
        public static void AttachNumericInputEvent(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }
        public static void AttachDecimalInputEvent(TextBox textBox)
        {
            textBox.KeyPress += (sender, e) =>
            {
                bool isDot = e.KeyChar == '.';
                bool containsDot = textBox.Text.Contains('.');
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (!isDot) ||
                    (isDot && containsDot))
                {
                    e.Handled = true;
                }
                if (isDot && containsDot)
                {
                    if (textBox.Text.IndexOf('.') + 3 <= textBox.Text.Length)
                    {
                        e.Handled = true;
                    }
                }
            };
        }
    }
}
