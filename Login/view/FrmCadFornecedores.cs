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
    public partial class FrmCadFornecedores : Form
    {
        int incrementar;
        List<CadFornecedor> listaCadFornecedor = new List<CadFornecedor>();
        int ponteiro = 0;
        public FrmCadFornecedores()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            // passando o conteudo digitado pelo usuario

            CadFornecedor CadFornecedor1 = new CadFornecedor();

            CadFornecedor1.Codigo = (txtnCOD.Text);
            CadFornecedor1.Nome = (txtnNome.Text);
            CadFornecedor1.Email = (txtnEmail.Text);
            CadFornecedor1.Fone = (txtnFone1.Text);
            CadFornecedor1.Fone = (txtnFone.Text);
            CadFornecedor1.Cnpj = (txtnCNPJ.Text);
            CadFornecedor1.Ie = (txtnIE.Text);
            CadFornecedor1.Cep = (txtnCEP.Text);
            CadFornecedor1.Municipio = (txtnMunicipio.Text);
            CadFornecedor1.Endereço = (txtnEndereco.Text);
            CadFornecedor1.Bairro = (txtnBairro.Text);
            CadFornecedor1.Uf = (cbUF.Text);
            CadFornecedor1.Numero = (txtnNumero.Text);
            CadFornecedor1.Complemento = (txtnComplemento.Text);
            CadFornecedor1.WebSite = (txtnWebSite.Text);
            CadFornecedor1.Observação = (txtnObs.Text);
            CadFornecedor1.Despesa = (cbDespesas.Text);
            CadFornecedor1.Status = (cbStatus.Text);


            listaCadFornecedor.Add(CadFornecedor1);
            ponteiro = listaCadFornecedor.Count - 1;
            LoadField(true);

            Mensagem salvar = new Mensagem();
            salvar.salvando();


            txtnCOD.Clear();
            txtnNome.Clear();
            txtnCNPJ.Clear();
            txtnIE.Clear();
            txtnEmail.Clear();
            txtnFone1.Clear();
            txtnFone.Clear();
            txtnEndereco.Clear();
            txtnNumero.Clear();
            txtnMunicipio.Clear();
            txtnCEP.Clear();
            txtnBairro.Clear();
            cbStatus.Text = "";
            cbDespesas.Text = "";
            txtnObs.Clear();
            txtnWebSite.Clear();
            cbUF.Text = "";

            txtnNome.Focus();

            CadFornecedor incremento = new CadFornecedor();
            incrementar = incremento.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);



        }

        private void CadFornecedores_KeyDown(object sender, KeyEventArgs e)
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

            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor consultaFornecedor1 = new FrmConsultaFornecedor();
            consultaFornecedor1.ShowDialog();
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
            if (ponteiro < listaCadFornecedor.Count - 1)
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
                txtnCNPJ.Clear();
                txtnIE.Clear();
                txtnEmail.Clear();
                txtnFone1.Clear();
                txtnFone.Clear();
                txtnEndereco.Clear();
                txtnNumero.Clear();
                txtnMunicipio.Clear();
                txtnCEP.Clear();
                txtnBairro.Clear();
                cbStatus.Text = "";
                cbDespesas.Text = "";
                txtnObs.Clear();
                txtnWebSite.Clear();
                cbUF.Text = "";

                txtnNome.Focus();

            }
            else
            {
                txtnCOD.Text = listaCadFornecedor[ponteiro].Codigo;
                txtnNome.Text = listaCadFornecedor[ponteiro].Nome;
                txtnCNPJ.Text = listaCadFornecedor[ponteiro].Cnpj;
                txtnFone.Text = listaCadFornecedor[ponteiro].Fone;
                txtnFone1.Text = listaCadFornecedor[ponteiro].Fone1;
                txtnEmail.Text = listaCadFornecedor[ponteiro].Email;
                txtnObs.Text = listaCadFornecedor[ponteiro].Observação;
                txtnCEP.Text = listaCadFornecedor[ponteiro].Cep;
                txtnMunicipio.Text = listaCadFornecedor[ponteiro].Municipio;
                cbUF.Text = listaCadFornecedor[ponteiro].Uf;
                txtnBairro.Text = listaCadFornecedor[ponteiro].Bairro;
                cbDespesas.Text = listaCadFornecedor[ponteiro].Despesa;
                cbStatus.Text = listaCadFornecedor[ponteiro].Status;
                cbUF.Text = listaCadFornecedor[ponteiro].Status;
                txtnComplemento.Text = listaCadFornecedor[ponteiro].Complemento;



            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (listaCadFornecedor.Count > 0)
                listaCadFornecedor.RemoveAt(ponteiro);

            if (listaCadFornecedor.Count > 0)
            {
                ponteiro = listaCadFornecedor.Count - 1;
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

        private void txtnNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbStatus.Focus();

            }
        }

        private void cbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCNPJ.Focus();

            }
        }

        private void txtnCNPJ_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnIE.Focus();

            }
        }

        private void txtnIE_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnFone1.Focus();

            }
        }

        private void txtnFone1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnFone.Focus();

            }
        }

        private void txtnFone_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnEmail.Focus();

            }
        }

        private void txtnEmail_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnWebSite.Focus();

            }
        }

        private void txtnWebSite_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnCEP.Focus();

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
                txtnComplemento.Focus();

            }
        }

        private void txtnComplemento_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                cbDespesas.Focus();

            }
        }

        private void cbDespesas_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnObs.Focus();

            }
        }

        private void txtnObs_KeyDown(object sender, KeyEventArgs e)
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

        private void FrmCadFornecedores_Load(object sender, EventArgs e)
        {
            CadFornecedor cadFornecedor = new CadFornecedor();

            incrementar = cadFornecedor.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
        }
    }
}
