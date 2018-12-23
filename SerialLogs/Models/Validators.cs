using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialLogs
{
    /// <summary>
    /// Validators to check entry's on all boxes before saving
    /// </summary>
    public static class Validators
    {

        /// <summary>
        /// Checks Serial number box to make sure it is completed
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsPresentMask(MaskedTextBox textBox)
        {
            if (!textBox.MaskCompleted)
            {
                MessageBox.Show(textBox.Tag + " is a required field",
                    "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        
        /// <summary>
        /// Checks all text box entry's
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsPresent(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(textBox.Tag + " is a required field",
                    "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// checks antenna and customer combo boxes entry's
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsPresentCombo(ComboBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(textBox.Tag + " is required field" +
                    "\n\nPlease Select one or create a new one if need!", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// checks to make sure issue serail numbers box is a int.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsInt32(TextBox textBox)
        {
            if (Int32.TryParse(textBox.Text, out int number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " Is numeric entry only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }

        /// <summary>
        /// Check for valid email address
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsValidEmail(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return true;
            }
            else
            try
            {
                MailAddress mail = new MailAddress(textBox.Text);
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show(textBox.Tag + "  " + textBox.Text + " is not a valid email address " +
                   "\n\nPlease use format name@domain.com!", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;

            }
        }

    }
}
