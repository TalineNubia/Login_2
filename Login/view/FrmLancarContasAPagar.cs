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
    public partial class FrmLancarContasAPagar : Form
    {
        int incrementar;

        public FrmLancarContasAPagar()
        {
            InitializeComponent();
        }

        private void LancarContasAPagar_KeyDown(object sender, KeyEventArgs e)
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
            this.Visible = false;
            consultaFornecedor1.ShowDialog();
            this.Visible = false;
            FrmLancarContasAPagar lancarContasAPagar1 = new FrmLancarContasAPagar();
            lancarContasAPagar1.ShowDialog();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            ContasAPagar lançarContasAPagar1 = new ContasAPagar();
            lançarContasAPagar1.Codigo = (txtnCOD.Text);
            lançarContasAPagar1.Nome = (txtnNome.Text);
            lançarContasAPagar1.Despesa = (cbDespesas.Text);
            lançarContasAPagar1.Condominio = (cbCondominio.Text);
            lançarContasAPagar1.DataVencimento = (txtnDataVencimento.Text);
            lançarContasAPagar1.Unidade = (txtnUnidade.Text);
            lançarContasAPagar1.Valor = (txtnValor.Text);
            lançarContasAPagar1.SerieNota = (txtnSerie.Text);
            lançarContasAPagar1.NumeroNota = (txtnNota.Text);


            Mensagem salvar = new Mensagem();
            salvar.salvando();

            txtnCOD.Clear();
            txtnNome.Clear();
            txtnNota.Clear();
            txtnObs.Clear();
            txtnDataVencimento.Clear();
            txtnSerie.Clear();
            txtnUnidade.Clear();
            cbCondominio.Text = "";
            cbDespesas.Text = "";

            LancarFuncionario incremento = new LancarFuncionario();
             incrementar = incremento.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
           
                this.Close();
          
        }

        private void FrmLancarContasAPagar_Load(object sender, EventArgs e)
        {
            ContasAPagar cadContasPagar = new ContasAPagar();
            incrementar = cadContasPagar.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
        }
    }
}
