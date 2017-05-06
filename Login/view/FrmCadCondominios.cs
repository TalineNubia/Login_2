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

            cadastro.Codigo_condominio = (txtnCOD.Text);
            cadastro.Nome_condominio = (txtnNome.Text);
            cadastro.Cnpj_condominio = (txtnCnpj.Text);
            cadastro.Email_condominio = (txtnEmail.Text);
            cadastro.Fone_condominio = (txtnFone1.Text);
            cadastro.Cep_condominio = (txtnCEP.Text);
            cadastro.Municipio_condominio = (txtnMunicipio.Text);
            cadastro.Uf_condominio = (cbUF.Text);
            cadastro.Endereço_condominio = (txtnEndereco.Text);
            cadastro.Numero_condominio = (txtnNumero.Text);
            cadastro.Bairro_condominio = (txtnBairro.Text);
            cadastro.RegistroMatricial_condominio = (txtnRMatricial.Text);
            cadastro.RegistroPredial_condominio = (txtnRPredial.Text);



            listacadastro.Add(cadastro);


            ponteiro = listacadastro.Count - 1;
            LoadField(true);

            Mensagem salvar = new Mensagem();
            salvar.salvando();

            
            txtnNome.Clear();
            txtnCnpj.Clear();
            txtnFone1.Clear();
            txtnIe.Clear();
            txtnEmail.Clear();
            txtnCEP.Clear();
            txtnMunicipio.Clear();
            txtnEndereco.Clear();
            cbUF.Text = "";
            txtnNumero.Clear();
            txtnRMatricial.Clear();
            txtnRPredial.Clear();
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

                
                txtnNome.Clear();
                txtnCnpj.Clear();
                txtnFone1.Clear();
                txtnIe.Clear();
                txtnEmail.Clear();
                txtnCEP.Clear();
                txtnMunicipio.Clear();
                txtnEndereco.Clear();
                cbUF.Text = "";
                txtnNumero.Clear();
                txtnRMatricial.Clear();
                txtnRPredial.Clear();

                txtnNome.Focus();

            }
            else
            {
                txtnCOD.Text = listacadastro[ponteiro].Codigo_condominio;
                txtnNome.Text = listacadastro[ponteiro].Nome_condominio;
                txtnEmail.Text = listacadastro[ponteiro].Email_condominio;
                txtnFone1.Text = listacadastro[ponteiro].Fone_condominio;
                txtnCnpj.Text = listacadastro[ponteiro].Cnpj_condominio;
                txtnIe.Text = listacadastro[ponteiro].Ie_condominio;
                txtnCEP.Text = listacadastro[ponteiro].Cep_condominio;
                txtnMunicipio.Text = listacadastro[ponteiro].Municipio_condominio;
                txtnEndereco.Text = listacadastro[ponteiro].Endereço_condominio;
                cbUF.Text = listacadastro[ponteiro].Uf_condominio;
                txtnNumero.Text = listacadastro[ponteiro].Numero_condominio;
                txtnRMatricial.Text = listacadastro[ponteiro].RegistroMatricial_condominio;
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


