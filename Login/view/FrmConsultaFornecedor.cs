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
    public partial class FrmConsultaFornecedor : Form
    {
        public FrmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void ConsultaFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
         
            }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            FrmCadFornecedores cadastroFornecedor1 = new FrmCadFornecedores();
            this.Visible = false;
            cadastroFornecedor1.ShowDialog();
            this.Visible = false;
            FrmConsultaFornecedor consultaFornecedor1 = new FrmConsultaFornecedor();
            consultaFornecedor1.ShowDialog();

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
           
                this.Close();
           
        }
    }
    }

