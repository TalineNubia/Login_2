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
    public partial class FrmConsultaFuncionario : Form
    {
        public FrmConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void ConsultaFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            FrmCadFuncionario cadastroFuncionario1 = new FrmCadFuncionario();
            this.Visible = false;
            cadastroFuncionario1.ShowDialog();
            this.Visible = false;
            FrmConsultaFuncionario consultaFuncionario1 = new FrmConsultaFuncionario();
            consultaFuncionario1.ShowDialog();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
        
                this.Close();
          
        }
    }
}
