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
    public partial class FrmHelp2 : Form
    {
        public FrmHelp2()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            string texto = " Deseja realmente sair? ";
            string titulo = "**  FINALIZANDO **";
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            FrmHelp help1 = new FrmHelp();
            this.Visible = false;

            help1.ShowDialog();
            

        }

        private void FrmHelp2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
    }
}
