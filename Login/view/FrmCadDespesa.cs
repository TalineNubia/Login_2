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
    public partial class FrmCadDespesa : Form
    {
        List<CadDespesa> listaCadDespesa1 = new List<CadDespesa>();
        int ponteiro = 0;
        int incrementar;

        public FrmCadDespesa()
        {
            InitializeComponent();
        }

        private void CadDespesa_KeyDown(object sender, KeyEventArgs e)
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
            FrmConsultaDespesa consultaDespesa1 = new FrmConsultaDespesa();
            this.Visible = false;
            consultaDespesa1.ShowDialog();
            this.Visible = false;
            FrmCadDespesa cadastroDespesa1 = new FrmCadDespesa();
            cadastroDespesa1.ShowDialog();

        }

        private void FrmCadDespesa_Load(object sender, EventArgs e)
        {
            CadDespesa cadDespesa = new CadDespesa();
            
            incrementar = cadDespesa.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            CadDespesa cadastroDespesa1 = new CadDespesa();

            cadastroDespesa1.Codigo = (txtnCOD.Text);
            cadastroDespesa1.Despesa = (txtnDespesa.Text);
            cadastroDespesa1.TipoDespesa = (cbTipoDespesa.Text);
            cadastroDespesa1.Valor = (txtnValor.Text);
            cadastroDespesa1.Observação = (txtnObs.Text);
            cadastroDespesa1.Condominio = (cbCondominio.Text);
            listaCadDespesa1.Add(cadastroDespesa1);
            ponteiro = listaCadDespesa1.Count - 1;
            LoadField(true);

            Mensagem salvar = new Mensagem();
            salvar.salvando();

            LimparTela limpa = new LimparTela();
            limpa.Limpar(this);
            txtnDespesa.Focus();

            CadDespesa incremento = new CadDespesa();
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
            if (ponteiro < listaCadDespesa1.Count - 1)
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
                txtnDespesa.Focus();

            }
            else
            {
                txtnCOD.Text = listaCadDespesa1[ponteiro].Codigo;
                txtnDespesa.Text = listaCadDespesa1[ponteiro].Despesa;
               cbTipoDespesa.Text = listaCadDespesa1[ponteiro].TipoDespesa;
                txtnValor.Text = listaCadDespesa1[ponteiro].Valor;
                txtnObs.Text = listaCadDespesa1[ponteiro].Observação;
                cbCondominio.Text = listaCadDespesa1[ponteiro].Condominio;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (listaCadDespesa1.Count > 0)
                listaCadDespesa1.RemoveAt(ponteiro);

            if (listaCadDespesa1.Count > 0)
            {
                ponteiro = listaCadDespesa1.Count - 1;
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

        private void btCancelar_Click(object sender, EventArgs e)
        {
       
                this.Close();
        
        }

        private void txtnCOD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnDespesa.Focus();

            }
        }

        private void txtnDespesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbTipoDespesa.Focus();

            }
        }

        private void cbTipoDespesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnValor.Focus();

            }
        }

        private void txtnValor_KeyDown(object sender, KeyEventArgs e)
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
    }
}
