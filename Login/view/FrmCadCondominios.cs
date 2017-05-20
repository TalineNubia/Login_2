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
    public partial class FrmCadCondominios : Form
    {
        List<CadastroCondominio> listacadastro = new List<CadastroCondominio>();
        int ponteiro = 0;
        int incrementar ;


        public FrmCadCondominios()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtnCOD_TextChanged(object sender, EventArgs e)
        {




        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            CadastroCondominio cadastro = new CadastroCondominio();
            // passando conteudo digitado pelo usuario

            cadastro.Codigo = (txtnCOD.Text);
            cadastro.Nome = (txtnNome.Text);
            cadastro.Cnpj = (txtnCnpj.Text);
            cadastro.Email = (txtnEmail.Text);
            cadastro.Fone = (txtnFone1.Text);
            cadastro.Cep = (txtnCEP.Text);
            cadastro.Municipio = (txtnMunicipio.Text);
            cadastro.Uf = (cbUF.Text);
            cadastro.Endereço = (txtnEndereco.Text);
            cadastro.Numero = (txtnNumero.Text);
            cadastro.Bairro = (txtnBairro.Text);
            cadastro.RegistroMatricial = (txtnRMatricial.Text);
            cadastro.RegistroPredial_condominio = (txtnRPredial.Text);



            listacadastro.Add(cadastro);


            ponteiro = listacadastro.Count - 1;
            LoadField(true);

            Mensagem salvar = new Mensagem();
            salvar.salvando();


            LimparTela limpa = new LimparTela();
            limpa.Limpar(this);
            txtnNome.Focus();

            CadastroCondominio incremento = new CadastroCondominio();

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

            if (ponteiro < listacadastro.Count - 1)
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
                txtnCOD.Text = listacadastro[ponteiro].Codigo;
                txtnNome.Text = listacadastro[ponteiro].Nome;
                txtnEmail.Text = listacadastro[ponteiro].Email;
                txtnFone1.Text = listacadastro[ponteiro].Fone;
                txtnCnpj.Text = listacadastro[ponteiro].Cnpj;
                txtnIe.Text = listacadastro[ponteiro].Ie;
                txtnCEP.Text = listacadastro[ponteiro].Cep;
                txtnMunicipio.Text = listacadastro[ponteiro].Municipio;
                txtnEndereco.Text = listacadastro[ponteiro].Endereço;
                cbUF.Text = listacadastro[ponteiro].Uf;
                txtnNumero.Text = listacadastro[ponteiro].Numero;
                txtnRMatricial.Text = listacadastro[ponteiro].RegistroMatricial;
                txtnRPredial.Text = listacadastro[ponteiro].RegistroPredial_condominio;
            }

        }
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (listacadastro.Count > 0)
                listacadastro.RemoveAt(ponteiro);

            if (listacadastro.Count > 0)
            {
                ponteiro = listacadastro.Count - 1;
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

        private void txtnCOD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnNome.Focus();

            }
        }

        private void txtnNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnNIF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnIe.Focus();

            }

        }

        private void txtnNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCnpj.Focus();

            }
        }

        private void txtnMunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbUF.Focus();

            }

        }

        private void txtnEndereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnNumero.Focus();

            }
        }

        private void cbUF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnEndereco.Focus();

            }
        }

        private void txtnNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnBairro.Focus();

            }
        }

        private void txtnRMatricial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnRPredial.Focus();

            }
        }

        private void txtnRPredial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btSalvar.Focus();

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
                     
        
                this.Close();
            
          
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            
            
            
          
        }

        private void txtnEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnFone1.Focus();

            }
        }

        private void txtFone1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCEP.Focus();

            }
        }

        private void cbUF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtnCEP_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnMunicipio.Focus();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtnIe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnEmail.Focus();


            }
        }

        private void txtnBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnRMatricial.Focus();


            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultaCondominios consultarCondominio1 = new FrmConsultaCondominios();
            this.Visible = false;
            consultarCondominio1.ShowDialog();
            this.Visible = false;
            FrmCadCondominios CadastroCondominio1 = new FrmCadCondominios();
            CadastroCondominio1.ShowDialog();
        }

        private void btCancelar_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CadCondominios_KeyDown(object sender, KeyEventArgs e)
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
                case Keys.F6:
                    btCadastrarResidencias_Click(sender, e);
                    break;

            }
        }

        private void btCadastrarResidencias_Click(object sender, EventArgs e)
        {
            FrmCadResidencias cadastraResidencia = new FrmCadResidencias();
            this.Visible = false;
            cadastraResidencia.ShowDialog();
            this.Visible = false;
            FrmCadCondominios cadastroCondominio1 = new FrmCadCondominios();
            cadastroCondominio1.ShowDialog();

        }

        private void CadCondominios_Load(object sender, EventArgs e)
        {
            //  CadastroCondominio cadCondominio = new CadastroCondominio();
            //txtnCOD.Text = Convert.ToString(cadCondominio.autoIncremento());

            CadastroCondominio cadCondominio = new CadastroCondominio();
            incrementar = cadCondominio.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);


        }

        private void CadCondominios_Click(object sender, EventArgs e)
        {

        }

        private void txtnNome_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void txtnCnpj_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnIe.Focus();


            }
        }
    }
}


