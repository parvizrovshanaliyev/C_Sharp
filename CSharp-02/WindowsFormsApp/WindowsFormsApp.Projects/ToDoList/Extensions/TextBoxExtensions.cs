using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.Extensions
{
    public static class TextBoxExtensions
    {
        /// <summary>
        /// Extension method to validate that input text is a number.
        /// </summary>
        /// <param name="e">Key Press Event Initialization.</param>
        /// <param name="isCalculation">if true then decimal point (.) is allowed, if false then decimal point (.) is not allowed</param>
        public static void ValidateNumber(this TextBox txt, KeyPressEventArgs e, bool isCalculation)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                if (e.KeyChar == '.' && isCalculation)
                    if (txt.Text.IndexOf('.') > -1)
                        e.Handled = true;
                    else e.Handled = false;
                else e.Handled = true;
        }

        public static void EnterEvent(this TextBox txt)
        {
            txt.BackColor = Color.DarkGray;
        }

        public static void LeaveEvent(this TextBox txt)
        {
            txt.BackColor = Color.White;
        }
    }
}
