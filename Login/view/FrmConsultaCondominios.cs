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
    public partial class FrmConsultaCondominios : Form
    {
        public FrmConsultaCondominios()
        {
            InitializeComponent();
        }

        private void ConsultaCondominios_KeyDown(object sender, KeyEventArgs e)
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
           
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void ConsultaCondominios_Load(object sender, EventArgs e)
        {

        }

        private void txtnCOD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnNome.Focus();

            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FrmCadCondominios cadastroCondominio1 = new FrmCadCondominios();
            this.Visible = false;
            cadastroCondominio1.ShowDialog();
            this.Visible = false;
            FrmConsultaCondominios consultaCondominio1 = new FrmConsultaCondominios();
            consultaCondominio1.ShowDialog();
        }
    }
}
