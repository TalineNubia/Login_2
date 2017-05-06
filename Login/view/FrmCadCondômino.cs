using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.view;

namespace Login.view
{
    public partial class FrmCadCondômino : Form
    {
        List<ClassCadastroCondômino> listaCadastroCondômino = new List<ClassCadastroCondômino>();
        int ponteiro = 0;
        int incrementar;

        public FrmCadCondômino()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadCondômino_Click(object sender, EventArgs e)
        {

        }

        private void CadCondômino_KeyDown(object sender, KeyEventArgs e)
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
                    btMaismoradores_Click(sender, e);
                    break;

            }
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultaCondômino consultaCondômino1 = new FrmConsultaCondômino();
            this.Visible = false;
            consultaCondômino1.ShowDialog();
            this.Visible = false;
            FrmCadCondômino cadastroCondômino1 = new FrmCadCondômino();
            cadastroCondômino1.ShowDialog();
        }

        private void btMaismoradores_Click(object sender, EventArgs e)
        {
            FrmCadMaisMorador CadastroMaisMoradores1 = new FrmCadMaisMorador();
            this.Visible = false;
            CadastroMaisMoradores1.ShowDialog();
            this.Visible = false;
            FrmCadCondômino CadastroCondômino1 = new FrmCadCondômino();
            CadastroCondômino1.ShowDialog();

        }

        private void FrmCadCondômino_Load(object sender, EventArgs e)
        {
            ClassCadastroCondômino cadCondomino = new ClassCadastroCondômino();
            
            incrementar = cadCondomino.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            ClassCadastroCondômino cadastroCondômino1 = new ClassCadastroCondômino();
            //Passando dados do usuario

            cadastroCondômino1.Codigo = (txtnCOD.Text);
            cadastroCondômino1.Nome = (txtnNome.Text);
            cadastroCondômino1.Cpf = (txtnCPF.Text);
            cadastroCondômino1.Fone = (txtnFone.Text);
            cadastroCondômino1.CadastroSimNao = (clbAtivoInativo.Text);
            cadastroCondômino1.Email = (txtnEmail.Text);
            cadastroCondômino1.EstadoCivil = (cbEstadoCivil.Text);
            cadastroCondômino1.Condominio = (cbCondominio.Text);
            cadastroCondômino1.Nome_Conjugue = (txtnNomeConjugue.Text);
            cadastroCondômino1.Cpf_Conjugue = (txtnCpfConjugue.Text);
            cadastroCondômino1.Fone_Conjugue = (txtnFoneConjugue.Text);


            listaCadastroCondômino.Add(cadastroCondômino1);

            ponteiro = listaCadastroCondômino.Count - 1;
            LoadField(true);

            Mensagem salvar = new Mensagem();
            salvar.salvando();

            txtnCOD.Clear();
            txtnNome.Clear();
            txtnCPF.Clear();
            txtnFone.Clear();
            clbAtivoInativo.Text = "";
            txtnEmail.Clear();
            cbEstadoCivil.Text = "";
            cbCondominio.Text = "";
            cbUnidade.Text = "";
            txtnNomeConjugue.Clear();
            txtnCpfConjugue.Clear();
            txtnFoneConjugue.Clear();
            txtnNome.Focus();

            ClassCadastroCondômino incremento = new ClassCadastroCondômino();
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
            if (ponteiro < listaCadastroCondômino.Count - 1)
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
                txtnCPF.Clear();
                txtnFone.Clear();
                clbAtivoInativo.Text = "";
                txtnEmail.Clear();
                cbEstadoCivil.Text = "";
                cbCondominio.Text = "";
                cbUnidade.Text = "";
                txtnNomeConjugue.Clear();
                txtnCpfConjugue.Clear();
                txtnFoneConjugue.Clear();
                txtnNome.Focus();

            }

            else
            {
                txtnCOD.Text = listaCadastroCondômino[ponteiro].Codigo;
                txtnNome.Text = listaCadastroCondômino[ponteiro].Nome;
                txtnCPF.Text = listaCadastroCondômino[ponteiro].Cpf;
                txtnFone.Text = listaCadastroCondômino[ponteiro].Fone;
                clbAtivoInativo.Text = listaCadastroCondômino[ponteiro].CadastroSimNao;
                txtnEmail.Text = listaCadastroCondômino[ponteiro].Email;
                cbEstadoCivil.Text = listaCadastroCondômino[ponteiro].EstadoCivil;
                cbCondominio.Text = listaCadastroCondômino[ponteiro].Condominio;
                cbUnidade.Text = listaCadastroCondômino[ponteiro].Unidade;
                txtnNomeConjugue.Text = listaCadastroCondômino[ponteiro].Nome_Conjugue;
                txtnCpfConjugue.Text = listaCadastroCondômino[ponteiro].Cpf_Conjugue;
                txtnFoneConjugue.Text = listaCadastroCondômino[ponteiro].Fone_Conjugue;

            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (listaCadastroCondômino.Count > 0)
                listaCadastroCondômino.RemoveAt(ponteiro);

            if (listaCadastroCondômino.Count > 0)
            {
                ponteiro = listaCadastroCondômino.Count - 1;
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
                txtnFone.Focus();

            }
        }

        private void txtnFone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                clbAtivoInativo.Focus();

            }
        }

        private void clbAtivoInativo_KeyDown(object sender, KeyEventArgs e)
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
                txtnEmail.Focus();

            }
        }

        private void txtnEmail_KeyDown(object sender, KeyEventArgs e)
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
                cbCondominio.Focus();

            }
        }

        private void cbCondominio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbUnidade.Focus();

            }
        }

        private void cbUnidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnNomeConjugue.Focus();

            }
        }

        private void txtnNomeConjugue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCpfConjugue.Focus();

            }
        }

        private void txtnCpfConjugue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnFoneConjugue.Focus();

            }
        }

        private void txtnFoneConjugue_KeyDown(object sender, KeyEventArgs e)
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
    }
}