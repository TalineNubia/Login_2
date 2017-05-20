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
using Login.model;

namespace Login.view
{
    public partial class FrmCadProprietarios : Form
    {
        List<CadastroProprietario> listaproprietario = new List <CadastroProprietario>();
        
        
        int ponteiro = 0;
        int incrementar;

        public FrmCadProprietarios()
        {
            InitializeComponent();
        }

        private void txtnNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCPF.Focus();

            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            CadastroProprietario cadastro = new CadastroProprietario();
            // passando o conteudo digitado pelo usuario

            cadastro.Codigo = (txtnCOD.Text);
            cadastro.Nome = (txtnNome.Text);
            cadastro.Cpf = (txtnCPF.Text);
            cadastro.Rg = (txtnRG.Text);
            cadastro.Fone = (txtnFone.Text);
            cadastro.Fone1 = (txtnFone1.Text);
            cadastro.Email = (txtnEmail.Text);
            cadastro.EstadoCivil = (cbEstadoCivil.Text);
            cadastro.Cep = (txtnCEP.Text);
            cadastro.Endereço = (txtnEndereco.Text);
            cadastro.Numero = (txtnNumero.Text);
            cadastro.Municipio = (txtnMunicipio.Text);
            cadastro.Uf = (cbUF.Text);
            cadastro.Bairro = (txtnBairro.Text);
            cadastro.Condominio = (cbCondominio.Text);
            cadastro.Morador = (clbMorador.Text);
            cadastro.Status = (clbAtivoInativo.Text);



            listaproprietario.Add(cadastro);
            ponteiro = listaproprietario.Count - 1;
            LoadField(true);

            Mensagem salvar = new Mensagem();
            salvar.salvando();

            LimparTela limpa = new LimparTela();
            limpa.Limpar(this);
            txtnNome.Focus();


            CadastroProprietario incremento = new CadastroProprietario();
            
            incrementar = incremento.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);

        }

        private void btAnterior_Click(object sender, EventArgs e)
        {
            if (ponteiro > 0)
            {
                ponteiro--;
                LoadField(false);

            }
        }

        private void btProximo_Click(object sender, EventArgs e)
        {
            if (ponteiro < listaproprietario.Count - 1)
            {
                ponteiro++;
                LoadField(false);


            }
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

                txtnCOD.Text = listaproprietario[ponteiro].Codigo;
                txtnNome.Text = listaproprietario[ponteiro].Nome;
                txtnCPF.Text = listaproprietario[ponteiro].Cpf;
                txtnFone.Text = listaproprietario[ponteiro].Fone;
                txtnFone1.Text = listaproprietario[ponteiro].Fone1;
                txtnEmail.Text = listaproprietario[ponteiro].Email;
                cbEstadoCivil.Text = listaproprietario[ponteiro].EstadoCivil;
                txtnEndereco.Text = listaproprietario[ponteiro].Endereço;
                txtnNumero.Text = listaproprietario[ponteiro].Numero;
                txtnCEP.Text = listaproprietario[ponteiro].Cep;
                txtnMunicipio.Text = listaproprietario[ponteiro].Municipio;
                cbUF.Text = listaproprietario[ponteiro].Uf;
                txtnBairro.Text = listaproprietario[ponteiro].Bairro;
                cbCondominio.Text = listaproprietario[ponteiro].Condominio;
                clbMorador.Text = listaproprietario[ponteiro].Morador;
                clbAtivoInativo.Text = listaproprietario[ponteiro].Status;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (listaproprietario.Count > 0 )
                listaproprietario.RemoveAt(ponteiro);

            if (listaproprietario.Count > 0 )
            {
                ponteiro = listaproprietario.Count - 1;
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

        private void button1_Click(object sender, EventArgs e)
        { // Cadastrar Condômino = Morador

            FrmCadCondômino cadastroCondomino1 = new FrmCadCondômino();
            this.Visible = false;
            cadastroCondomino1.ShowDialog();
            this.Visible = false;
            FrmCadProprietarios cadastroProprietario1 = new FrmCadProprietarios();
            cadastroCondomino1.ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultaProprietario ConsultaProprietario1 = new FrmConsultaProprietario();
            this.Visible = false;
            ConsultaProprietario1.ShowDialog();
            this.Visible = false;
            FrmCadProprietarios CadastroProprietario1 = new FrmCadProprietarios();
            CadastroProprietario1.ShowDialog();


        }

        private void txtnCOD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnNome.Focus();

            }
        }

        private void txtnRG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbSexo.Focus();

            }
        }

        private void txtnFone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCEP.Focus();

            }
        }

        private void txtnEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnFone1.Focus();

            }
        }

        private void cbEstadoCivil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnEmail.Focus();

            }
        }

        private void txtnCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnMunicipio.Focus();

            }
        }

        private void txtnMunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbUF.Focus();

            }
        }

        private void cbUF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnEndereco.Focus();

            }
        }

        private void txtnEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnNumero.Focus();

            }
        }

        private void txtnNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnBairro.Focus();

            }
        }

        private void txtnBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbCondominio.Focus();

            }
        }

        private void cbCondominio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                clbMorador.Focus();

            }
        }

        private void CadProprietarios_Click(object sender, EventArgs e)
        {

        }

        private void CadProprietarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
            switch (e.KeyCode)
            {

                case Keys.F4:
                    btConsultar_Click(sender, e);
                    break;
                case Keys.F6: // CADASTRAR MORADOR
                    button1_Click(sender, e);
                    break;
            }
        }

        private void FrmCadProprietarios_Load(object sender, EventArgs e)
        {
            CadastroProprietario cadProprietario = new CadastroProprietario();
            incrementar = cadProprietario.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
        }

        private void btSalvar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCOD.Focus();

            }
        }

        private void txtnFone1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnFone.Focus();

            }
        }

        private void txtnCPF_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnRG.Focus();

            }
        }

        private void cbSexo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                cbEstadoCivil.Focus();

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
