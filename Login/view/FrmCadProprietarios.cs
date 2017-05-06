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

namespace Login.view
{
    public partial class FrmCadProprietarios : Form
    {
        List<CadastroProprietario> listaproprietario = new List<CadastroProprietario>();
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

            cadastro.Codigo_proprietario = (txtnCOD.Text);
            cadastro.Nome_Proprietario = (txtnNome.Text);
            cadastro.Cpf_Proprietario = (txtnCPF.Text);
            cadastro.Rg_proprietario = (txtnRG.Text);
            cadastro.Fone_proprietario = (txtnFone.Text);
            cadastro.Fone1_proprietario = (txtnFone1.Text);
            cadastro.Email_proprietario = (txtnEmail.Text);
            cadastro.EstadoCivil_proprietario = (cbEstadoCivil.Text);
            cadastro.Cep_proprietario = (txtnCEP.Text);
            cadastro.Municipio_proprietario = (txtnMunicipio.Text);
            cadastro.Uf_proprietario = (cbUF.Text);
            cadastro.Bairro_proprietario = (txtnBairro.Text);
            cadastro.Condominio_proprietario = (cbCondominio.Text);
            cadastro.Morador_proprietario = (clbMorador.Text);



            listaproprietario.Add(cadastro);
            ponteiro = listaproprietario.Count - 1;
            LoadField(true);

            Mensagem salvar = new Mensagem();
            salvar.salvando();

            txtnCOD.Clear();
            txtnNome.Clear();
            txtnCPF.Clear();
            txtnRG.Clear();
            txtnEmail.Clear();
            txtnFone1.Clear();
            txtnFone.Clear();
            txtnEndereco.Clear();
            txtnNumero.Clear();
            txtnMunicipio.Clear();
            txtnCEP.Clear();
            txtnBairro.Clear();
            cbCondominio.Text = "";
            cbUF.Text = "";
            clbMorador.Text = "";
            txtnCOD.Focus();


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
                txtnCOD.Clear();
                txtnNome.Clear();
                txtnCPF.Clear();
                txtnRG.Clear();
                txtnEmail.Clear();
                txtnFone1.Clear();
                txtnFone.Clear();
                txtnEndereco.Clear();
                txtnNumero.Clear();
                txtnMunicipio.Clear();
                txtnCEP.Clear();
                txtnBairro.Clear();
                cbCondominio.Text = "";
                cbUF.Text = "";
                clbMorador.Text = "";
                txtnCOD.Focus();

            }

            else
            {
                txtnCOD.Text = listaproprietario[ponteiro].Codigo_proprietario;
                txtnNome.Text = listaproprietario[ponteiro].Nome_Proprietario;
                txtnCPF.Text = listaproprietario[ponteiro].Cpf_Proprietario;
                txtnFone.Text = listaproprietario[ponteiro].Fone_proprietario;
                txtnFone1.Text = listaproprietario[ponteiro].Fone1_proprietario;
                txtnEmail.Text = listaproprietario[ponteiro].Email_proprietario;
                cbEstadoCivil.Text = listaproprietario[ponteiro].EstadoCivil_proprietario;
                txtnCEP.Text = listaproprietario[ponteiro].Cep_proprietario;
                txtnMunicipio.Text = listaproprietario[ponteiro].Municipio_proprietario;
                cbUF.Text = listaproprietario[ponteiro].Uf_proprietario;
                txtnBairro.Text = listaproprietario[ponteiro].Bairro_proprietario;
                cbCondominio.Text = listaproprietario[ponteiro].Condominio_proprietario;
                clbMorador.Text = listaproprietario[ponteiro].Morador_proprietario;

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (listaproprietario.Count > 0)
                listaproprietario.RemoveAt(ponteiro);

            if (listaproprietario.Count > 0)
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
