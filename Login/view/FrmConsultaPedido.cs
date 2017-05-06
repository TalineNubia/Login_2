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
    public partial class FrmConsultaPedido : Form
    {
        public FrmConsultaPedido()
        {
            InitializeComponent();
        }

        private void ConsultaPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            FrmCadPedidos cadastroPedido1 = new FrmCadPedidos();
            this.Visible = false;
            cadastroPedido1.ShowDialog();
            this.Visible = false;
            FrmConsultaPedido consultaPedido1 = new FrmConsultaPedido();
            consultaPedido1.ShowDialog();


        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
