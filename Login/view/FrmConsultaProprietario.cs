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
    public partial class FrmConsultaProprietario : Form
    {
        public FrmConsultaProprietario()
        {
            InitializeComponent();
        }

        private void ConsultaProprietario_KeyDown(object sender, KeyEventArgs e)
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            FrmCadProprietarios cadastroProprietario1 = new FrmCadProprietarios();
            this.Visible = false;
            cadastroProprietario1.ShowDialog();
            this.Visible = false;
            FrmConsultaProprietario consultaProprietario1 = new FrmConsultaProprietario();
            consultaProprietario1.ShowDialog();
            
        }
    }
}
