using Login.model;
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
    public partial class FrmCadMaisMorador : Form
    {
        List<Morador> listaCadMorador = new List<Morador>();
        int ponteiro = 0;
        int incrementar;

        public FrmCadMaisMorador()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Morador cadastro = new Morador();
            cadastro.Codigo = (txtnCOD.Text);
            cadastro.Nome = (txtnNome.Text);
            cadastro.Cpf = (txtnCPF.Text);

            listaCadMorador.Add(cadastro);
            ponteiro = listaCadMorador.Count - 1;
            LoadField(true);

            Mensagem salvar = new Mensagem();
            salvar.salvando();

            LimparTela limpa = new LimparTela();
            limpa.Limpar(this);
            txtnNome.Focus();


            Morador incremento = new Morador();
            incrementar = incremento.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);


        }
        public void LoadField(bool newValues)
        {
            if (newValues)
            {
                LimparTela limpa = new LimparTela();
                limpa.Limpar(this);

                txtnNome.Focus();

            }
            else
            {
                txtnCOD.Text = listaCadMorador[ponteiro].Codigo;
                txtnNome.Text = listaCadMorador[ponteiro].Nome;
                txtnCPF.Text = listaCadMorador[ponteiro].Cpf;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (listaCadMorador.Count > 0)
                listaCadMorador.RemoveAt(ponteiro);

            if (listaCadMorador.Count > 0)
            {
                ponteiro = listaCadMorador.Count - 1;
                LoadField(false);

            }
            else
            {

                ponteiro = 0;
                LoadField(true);
            }

            Mensagem excluir = new Mensagem();
            excluir.excluindo();
        }

        private void txtnCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btSalvar.Focus();

            }
        }

        private void txtnCOD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnNome.Focus();

            }
        }

        private void txtnNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCPF.Focus();

            }
        }

        private void btSalvar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCOD.Focus();

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
           
                this.Close();
           
        }

        private void FrmCadMaisMorador_Load(object sender, EventArgs e)
        {
            Morador cadMorador = new Morador();
            incrementar = cadMorador.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
        }
    }
}

