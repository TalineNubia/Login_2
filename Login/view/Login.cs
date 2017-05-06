using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.view;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((txtnUsuario.Text == "Admin") && (txtnSenha.Text == "123"))
            {
                FrmTelaPrincipal TelaInicial = new FrmTelaPrincipal();
                
                TelaInicial.Show();
                this.Visible = false;
            }
            else
            {
                Mensagem erro = new Mensagem();
                erro.senha();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                txtnSenha.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnSenha.Focus();

            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtnSenha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            { // botao ok
                button1.Focus();

            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Login login1 = new Login();
            txtnUsuario.Clear();
            txtnSenha.Clear();
            txtnUsuario.Focus();
        }
    }
}
