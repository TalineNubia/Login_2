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
    public partial class FrmDadosFuncionario : Form
    {
        List<DadosFuncionario> listaDadosFuncionario = new List<DadosFuncionario>();
        

        public FrmDadosFuncionario()
        {
            InitializeComponent();
        }

        private void DadosFuncionario_KeyDown(object sender, KeyEventArgs e)
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
            FrmConsultaFuncionario consultaFuncionario = new FrmConsultaFuncionario();
            this.Visible = false;
            consultaFuncionario.ShowDialog();
            this.Visible = false;
            FrmDadosFuncionario dadosFuncionario = new FrmDadosFuncionario();
            dadosFuncionario.ShowDialog();


        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            DadosFuncionario dadosFuncionario1 = new DadosFuncionario();

            dadosFuncionario1.Nome = (txtnNome.Text);
            dadosFuncionario1.OperaSistema = (cbOperaSistema.Text);
            dadosFuncionario1.Senha = (txtnSenha.Text);
            dadosFuncionario1.Cargo = (cbCargo.Text);
            dadosFuncionario1.DataAdmissao = (txtnDataAdmissao.Text);
            dadosFuncionario1.DataDemissao = (txtnDataDemissao.Text);
            dadosFuncionario1.Perido = (txtnPeriodo.Text);
            dadosFuncionario1.Periodo1 = (txtnPeriodo2.Text);
            dadosFuncionario1.SalarioMensal = (txtnSalarioMensal.Text);
            dadosFuncionario1.Contato = (txtnContato.Text);
            dadosFuncionario1.Observação = (txtnObs.Text);

            listaDadosFuncionario.Add(dadosFuncionario1);
            

            Mensagem salvar = new Mensagem();
            salvar.salvando();

        }

        public void LoadField(bool newValues)
        {
            if (newValues)
            {

                txtnNome.Clear();
                txtnDataAdmissao.Clear();
                cbOperaSistema.Text = "";
                txtnSenha.Clear();
                cbCargo.Text = "";
                txtnDataDemissao.Clear();
                txtnPeriodo.Clear();
                txtnPeriodo2.Clear();
                txtnSalarioMensal.Clear();
                txtnObs.Clear();
                txtnContato.Clear();


            }
        }

        private void txtnNome_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                cbOperaSistema.Focus();

            }
        }

        private void cbOperaSistema_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnSenha.Focus();

            }
        }

        private void txtnSenha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                cbCargo.Focus();

            }
        }

        private void cbCargo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnDataAdmissao.Focus();

            }
        }

        private void txtnDataAdmissao_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnPeriodo.Focus();

            }
        }

        private void txtnPeriodo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnPeriodo2.Focus();

            }
        }

        private void txtnPeriodo2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnDataDemissao.Focus();

            }
        }

        private void txtnDataDemissao_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnSalarioMensal.Focus();

            }
        }

        private void txtnSalarioMensal_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnContato.Focus();

            }
        }

        private void txtnContato_KeyDown(object sender, KeyEventArgs e)
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

        private void btSalvar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                txtnNome.Focus();

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {

            this.Close();
        }

    }
}
