using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.view
{
    public partial class FrmConsultarBalancete : Form
    {
        public FrmConsultarBalancete()
        {
            InitializeComponent();
        }

        private void FrmConsultarBalancete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void cbCondominio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnPeriodo1.Focus();

            }
        }

        private void txtnPeriodo1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnPeriodo2.Focus();

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
                this.Close();
           
        }
    }
}
