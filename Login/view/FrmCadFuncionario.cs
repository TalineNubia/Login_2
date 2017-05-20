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
    public partial class FrmCadFuncionario : Form
    {
        List<CadFuncionario> listaCadFuncionario = new List<CadFuncionario>();
        int ponteiro = 0;
        int incrementar;



        public FrmCadFuncionario()
        {
            InitializeComponent();
        }

        private void CadFuncionario_KeyDown(object sender, KeyEventArgs e)
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
                case Keys.F3:
                    btDadosAdcionais_Click(sender, e);
                    break;

            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultaFuncionario consultaFuncionario1 = new FrmConsultaFuncionario();
            this.Visible = false;
            consultaFuncionario1.ShowDialog();
            this.Visible = false;
            FrmCadFuncionario cadastroFuncionario1 = new FrmCadFuncionario();
            cadastroFuncionario1.ShowDialog();
        }

        private void btDadosAdcionais_Click(object sender, EventArgs e)
        {
            FrmDadosFuncionario dadosFuncionario1 = new FrmDadosFuncionario();
            this.Visible = false;
            dadosFuncionario1.ShowDialog();
            this.Visible = false;
            FrmCadFuncionario cadatroFuncionario1 = new FrmCadFuncionario();
            cadatroFuncionario1.ShowDialog();
        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
            CadFuncionario cadFuncionario = new CadFuncionario();
            incrementar = cadFuncionario.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            CadFuncionario cadastro = new CadFuncionario();

            cadastro.Codigo = (txtnCOD.Text);
            cadastro.Nome= (txtnNome.Text);
            cadastro.Cpf = (txtnCPF.Text);
            cadastro.Rg = (txtnRG.Text);
            cadastro.Fone = (txtnFone.Text);
            cadastro.Email = (txtnEmail.Text);
            cadastro.EstadoCivil = (cbEstadoCivil.Text);
            cadastro.Cep = (txtnCEP.Text);
            cadastro.Municipio = (txtnMunicipio.Text);
            cadastro.Uf = (cbUF.Text);
            cadastro.Bairro = (txtnBairro.Text);
            cadastro.Condominio = (cbCondominio.Text);
            cadastro.Despesa = (cbDespesas.Text);
            cadastro.Cargo = (cbCargo.Text);
            cadastro.Sexo = (cbSexo.Text);
            cadastro.DataNascimento = (txtnDataNasc.Text);
            cadastro.Status = (clbAtivoInativo.Text);

            listaCadFuncionario.Add(cadastro);
            ponteiro = listaCadFuncionario.Count - 1;
            LoadField(true);

            Mensagem salvar = new Mensagem();
            salvar.salvando();
            LimparTela limpa = new LimparTela();
            limpa.Limpar(this);

            txtnNome.Focus();

            CadFuncionario incremento = new CadFuncionario();
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
            if (ponteiro < listaCadFuncionario.Count - 1)
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
                txtnCOD.Text = listaCadFuncionario[ponteiro].Codigo;
                txtnNome.Text = listaCadFuncionario[ponteiro].Nome;
                txtnCPF.Text = listaCadFuncionario[ponteiro].Cpf;
                txtnFone.Text = listaCadFuncionario[ponteiro].Fone;
                txtnDataNasc.Text = listaCadFuncionario[ponteiro].DataNascimento;
                txtnEmail.Text = listaCadFuncionario[ponteiro].Email;
                cbEstadoCivil.Text = listaCadFuncionario[ponteiro].EstadoCivil;
                txtnCEP.Text = listaCadFuncionario[ponteiro].Cep;
                txtnMunicipio.Text = listaCadFuncionario[ponteiro].Municipio;
                cbUF.Text = listaCadFuncionario[ponteiro].Uf;
                txtnBairro.Text = listaCadFuncionario[ponteiro].Bairro;
                cbCondominio.Text = listaCadFuncionario[ponteiro].Condominio;
                cbCargo.Text = listaCadFuncionario[ponteiro].Cargo;
                cbDespesas.Text = listaCadFuncionario[ponteiro].Despesa;
                cbSexo.Text = listaCadFuncionario[ponteiro].Sexo;
                clbAtivoInativo.Text = listaCadFuncionario[ponteiro].Status;
                

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (listaCadFuncionario.Count > 0)
                listaCadFuncionario.RemoveAt(ponteiro);

            if (listaCadFuncionario.Count > 0)
            {
                ponteiro = listaCadFuncionario.Count - 1;
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
                txtnCPF.Focus();

            }
        }

        private void txtnCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnRG.Focus();

            }
        }

        private void txtnRG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbSexo.Focus();

            }
        }

        private void cbSexo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbEstadoCivil.Focus();

            }
        }

        private void cbEstadoCivil_KeyDown(object sender, KeyEventArgs e)
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
                txtnDataNasc.Focus();

            }
        }

        private void txtnDataNasc_KeyDown(object sender, KeyEventArgs e)
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
                cbCargo.Focus();

            }
        }

        private void cbCargo_KeyDown(object sender, KeyEventArgs e)
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
                txtnCOD.Focus();

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            
                this.Close();
         
        }
    }
}
