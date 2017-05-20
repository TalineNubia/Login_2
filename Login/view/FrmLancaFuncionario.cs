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
    public partial class FrmLancaFuncionario : Form
    {
        int incrementar;
        public FrmLancaFuncionario()
        {
            InitializeComponent();
        }

        private void txtnCOD_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnFuncionario.Focus();

            }
        }

        private void txtnFuncionario_KeyDown(object sender, KeyEventArgs e)
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
                cbCondominio.Focus();

            }
        }

        private void cbCondominio_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
              

            }
        }

        private void cbCodvd_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnData.Focus();

            }
        }

        private void cbUnidade_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                
            }
        }

        private void txtnValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
               txtnObs.Focus();

            }
        }

        private void txtnVencimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnValor.Focus();
            }
        }

        private void txtnData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {

                txtnData2.Focus();

            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            LancarFuncionario lancarFuncionario1 = new LancarFuncionario();
            lancarFuncionario1.Codigo = (txtnCOD.Text);
            lancarFuncionario1.Nome = (txtnFuncionario.Text);
            lancarFuncionario1.Despesa = (cbDespesas.Text);
            lancarFuncionario1.Condominio = (cbCondominio.Text);
            lancarFuncionario1.ReferenteMes2 = (txtnData2.Text);
            lancarFuncionario1.Valor = (txtnValor.Text);
            lancarFuncionario1.ReferenteMes = (txtnData.Text);
            lancarFuncionario1.Vencimento = (txtnVencimento.Text);
            lancarFuncionario1.Observação = (txtnObs.Text);

            Mensagem salvar = new Mensagem();
            salvar.salvando();
                               
            LimparTela limpa = new LimparTela();
            limpa.Limpar(this);
            txtnFuncionario.Focus();

            LancarFuncionario incremento = new LancarFuncionario();
            incrementar = incremento.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);

        }

        private void FrmLancaFuncionario_KeyDown(object sender, KeyEventArgs e)
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
            FrmConsultaFuncionario consultaFuncionario1 = new FrmConsultaFuncionario();
            this.Visible = false;
            consultaFuncionario1.ShowDialog();
            this.Visible = false;
            FrmLancaFuncionario lancaFuncionario1 = new FrmLancaFuncionario();
            lancaFuncionario1.ShowDialog();
        }

        private void txtnData2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                txtnVencimento.Focus();

            }
        }

        private void txtnObs_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {

                btSalvar.Focus();

            }
        }

        private void FrmLancaFuncionario_Load(object sender, EventArgs e)
        {
            LancarFuncionario cadFuncionario = new LancarFuncionario();
            incrementar = cadFuncionario.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
