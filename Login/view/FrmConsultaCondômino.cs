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
    public partial class FrmConsultaCondômino : Form
    {
        public FrmConsultaCondômino()
        {
            InitializeComponent();
        }

        private void ConsultaCondômino_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
           
                this.Close();
           
        }
    }
}
