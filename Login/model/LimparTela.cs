using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.model
{
    public class LimparTela
    {
        public void Limpar(System.Windows.Forms.Control controles)
        {
            foreach (System.Windows.Forms.Control ctrl in controles.Controls)
            {
                if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    ((System.Windows.Forms.TextBox)ctrl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.MaskedTextBox)))
                {
                    ((System.Windows.Forms.MaskedTextBox)ctrl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.RichTextBox)))
                {
                    ((System.Windows.Forms.RichTextBox)ctrl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    ((System.Windows.Forms.ComboBox)ctrl).SelectedIndex = -1;
                }
                else if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    ((System.Windows.Forms.CheckBox)ctrl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    ((System.Windows.Forms.RadioButton)ctrl).Checked = false;
                }
                if (ctrl.Controls.Count > 0)
                {
                    Limpar(ctrl);
                }
            }
        }
    }
}