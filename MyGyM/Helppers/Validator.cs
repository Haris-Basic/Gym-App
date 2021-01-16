using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGyM
{
    public class Validator
    {
        public const string message = "Required";
        public static bool RequiredField(Control control, ErrorProvider err)
        {
            bool valid = true;

            if (control is TextBox && string.IsNullOrEmpty((control as TextBox).Text))
                valid = false;
            else if (control is ComboBox && (control as ComboBox).SelectedIndex == -1)
                valid = false;

            if (!valid)
            {
                err.SetError(control, message);
                return false;
            }
            else
            {
                err.Clear();
                return true;
            }

        }
    }
}
