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
    public partial class FrmCadBanco : Form
    {
        List<CadBanco> listaCadBanco = new List<CadBanco>();
        int ponteiro = 0;
        int incrementar;
        public FrmCadBanco()
        {
            InitializeComponent();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultaBanco consultaBanco1 = new FrmConsultaBanco();
            this.Visible = false;
            consultaBanco1.ShowDialog();
            FrmCadBanco cadastrarBanco1 = new FrmCadBanco();
            cadastrarBanco1.ShowDialog();

        }

        private void CadBanco_KeyDown(object sender, KeyEventArgs e)
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

        private void txtnCOD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnRazãoSocial.Focus();

            }
        }

        private void txtnRazãoSocial_KeyDown(object sender, KeyEventArgs e)
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
                txtnCNPJ.Focus();

            }
        }

        private void txtnCNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnIe.Focus();

            }
        }

        private void txtnIe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnBanco.Focus();

            }
        }

        private void txtnBanco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnAgencia.Focus();

            }
        }

        private void txtnAgencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnConta.Focus();

            }
        }

        private void txtnConta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbEmiteBoleto.Focus();

            }

        }

        private void cbEmiteBoleto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnNossoNumero.Focus();

            }
        }

        private void txtnNossoNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnData.Focus();

            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            CadBanco cadastroBanco1 = new CadBanco();
            cadastroBanco1.Codigo = (txtnCOD.Text);
            cadastroBanco1.RazaoSocial = (txtnRazãoSocial.Text);
            cadastroBanco1.Condominio = (cbCondominio.Text);
            cadastroBanco1.CNPJ = (txtnCNPJ.Text);
            cadastroBanco1.IE = (txtnIe.Text);
            cadastroBanco1.Banco = (txtnBanco.Text);
            cadastroBanco1.Agencia = (txtnAgencia.Text);
            cadastroBanco1.Conta = (txtnConta.Text);
            cadastroBanco1.EmiteBoleto = (cbEmiteBoleto.Text);
            cadastroBanco1.NossoNumero = (txtnNossoNumero.Text);
            cadastroBanco1.DataVencimento = (txtnData.Text);
            cadastroBanco1.LançaRmessa = (txtnLançaRemessa.Text);
            cadastroBanco1.RecuperaRemessa = (txtnRecuperaRemessa.Text);

            listaCadBanco.Add(cadastroBanco1);
            ponteiro = listaCadBanco.Count - 1;
            LoadField(true);

            Mensagem salvar = new Mensagem();
            salvar.salvando();


            txtnCOD.Clear();
            txtnRazãoSocial.Clear();
            cbCondominio.Text = "";
            txtnCNPJ.Clear();
            txtnIe.Clear();
            txtnBanco.Clear();
            txtnAgencia.Clear();
            txtnConta.Clear();
            cbEmiteBoleto.Text = "";
            txtnNossoNumero.Clear();
            txtnData.Clear();
            txtnLançaRemessa.Clear();
            txtnRecuperaRemessa.Clear();
            txtnRazãoSocial.Focus();

            CadBanco incremento = new CadBanco();
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
            if (ponteiro < listaCadBanco.Count - 1)
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
                txtnRazãoSocial.Clear();
                cbCondominio.Text = "";
                txtnCNPJ.Clear();
                txtnIe.Clear();
                txtnBanco.Clear();
                txtnAgencia.Clear();
                txtnConta.Clear();
                cbEmiteBoleto.Text = "";
                txtnNossoNumero.Clear();
                txtnData.Clear();
                txtnLançaRemessa.Clear();
                txtnRecuperaRemessa.Clear();
                txtnRazãoSocial.Focus();

            }
            else
            {

                txtnCOD.Text = listaCadBanco[ponteiro].Codigo;
                txtnRazãoSocial.Text = listaCadBanco[ponteiro].RazaoSocial;
                txtnCNPJ.Text = listaCadBanco[ponteiro].CNPJ;
                txtnIe.Text = listaCadBanco[ponteiro].IE;
                txtnBanco.Text = listaCadBanco[ponteiro].Banco;
                txtnAgencia.Text = listaCadBanco[ponteiro].Agencia;
                txtnConta.Text = listaCadBanco[ponteiro].Conta;
                cbEmiteBoleto.Text = listaCadBanco[ponteiro].EmiteBoleto;
                txtnNossoNumero.Text = listaCadBanco[ponteiro].NossoNumero;
                txtnData.Text = listaCadBanco[ponteiro].DataVencimento;
                txtnLançaRemessa.Text = listaCadBanco[ponteiro].LançaRmessa;
                txtnRecuperaRemessa.Text = listaCadBanco[ponteiro].RecuperaRemessa;



            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            if (listaCadBanco.Count > 0)
                listaCadBanco.RemoveAt(ponteiro);

            if (listaCadBanco.Count > 0)
            {
                ponteiro = listaCadBanco.Count - 1;
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

        private void txtnCNPJ_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnIe.Focus();

            }
        }

        private void txtnData_KeyDown(object sender, KeyEventArgs e)
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

        private void FrmCadBanco_Load(object sender, EventArgs e)
        {
            CadBanco cadBanco = new CadBanco();
            incrementar = cadBanco.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
        }
    }
}