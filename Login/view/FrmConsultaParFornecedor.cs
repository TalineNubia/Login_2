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
    public partial class FrmConsultaParFornecedor : Form
    {
        public FrmConsultaParFornecedor()
        {
            InitializeComponent();
        }

        private void ConsultaFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void ConsultaParFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {// alterar contas a pagar
            FrmLancarContasAPagar alterarContasApagar1 = new FrmLancarContasAPagar();
            this.Visible = false;
            alterarContasApagar1.ShowDialog();
            this.Visible = false;
            FrmConsultaParFornecedor consultaContasParFornecedor1 = new FrmConsultaParFornecedor();
            consultaContasParFornecedor1.ShowDialog();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            
                this.Close();
          
        }
    }
}
