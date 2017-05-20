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
    public partial class FrmLancarMensalidade : Form
    {
        public FrmLancarMensalidade()
        {
            InitializeComponent();
        }

        private void FrmLancarMensalidade_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
           
                this.Close();
         
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Mensalidade mensalidadeCliente = new Mensalidade();
            mensalidadeCliente.Condominio = (cbCondominio.Text);
            mensalidadeCliente.ValorDespesa = Convert.ToDecimal(txtnValorDespesa.Text);
            mensalidadeCliente.FracaoIdeal = Convert.ToDecimal(txtnFracao.Text);
            mensalidadeCliente.ValorFatura = Convert.ToDecimal(txtnValor.Text);
            mensalidadeCliente.Parcela = Convert.ToInt16(txtnParcela.Text);
            mensalidadeCliente.Banco = (cbBanco.Text);
            
            mensalidadeCliente.Nome = (txtnNome.Text);
            mensalidadeCliente.Status = (cbStatus.Text);
            mensalidadeCliente.DataPadrao = (txtnDataVencimento.Text);
            mensalidadeCliente.DataMes = (txtnData.Text);
            mensalidadeCliente.DataMes = (txtnData2.Text);

            Mensagem salvar = new Mensagem();
            salvar.salvando();

            LimparTela limpa = new LimparTela();
            limpa.Limpar(this);
            txtnNome.Focus();



        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
