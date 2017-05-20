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
using Login.model;

namespace Login.view
{
    public partial class FrmCadResidencias : Form
    {
        

        public FrmCadResidencias()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            CadastroResidencia cadastroResidencia1 = new CadastroResidencia();
            // passando conteudo digitado pelo usuario

            cadastroResidencia1.Codigo_Residencia = (txtnCod1.Text);
            cadastroResidencia1.Codigo_Residencia = (txtnCod2.Text);
            cadastroResidencia1.Codigo_Residencia = (txtnCod3.Text);
            cadastroResidencia1.Nome_Condominio = (cbCondominio.Text);
            cadastroResidencia1.AreaTotalTerreno = Convert.ToDecimal(txtnAreaTotalTerreno);
            cadastroResidencia1.AreaTotalConstruida = Convert.ToDecimal(txtnAreaTotalConstruida);
            cadastroResidencia1.Nome_Residencia = (txtnNomeResidencia1.Text);
            cadastroResidencia1.Nome_Residencia = (txtnNomeResidencia2.Text);
            cadastroResidencia1.Nome_Residencia = (txtnNomeResidencia3.Text);
            cadastroResidencia1.Bloco = (txtnBloco1.Text);
            cadastroResidencia1.Bloco = (txtnBloco2.Text);
            cadastroResidencia1.Bloco = (txtnBloco3.Text);


            Mensagem salvar = new Mensagem();
            salvar.salvando();

            LimparTela limpa = new LimparTela();
            limpa.Limpar(this);

            txtnCod1.Focus();



        }

        private void btNovoCadastro_Click(object sender, EventArgs e)
        {

            LimparTela limpa = new LimparTela();
            limpa.Limpar(this);

            txtnCod1.Focus();


        }

        private void CadResidencias_Load(object sender, EventArgs e)
        {

        }

        private void btConsultar_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultaResidencia consultaResidencia = new FrmConsultaResidencia();
            this.Visible = false;
            consultaResidencia.ShowDialog();
            this.Visible = false;
            FrmCadResidencias cadastroResidencia1 = new FrmCadResidencias();
            cadastroResidencia1.ShowDialog();


        }

        private void CadResidencias_KeyDown(object sender, KeyEventArgs e)
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
                    btNovoCadastro_Click(sender, e);
                    break;

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
           
                this.Close();
         
        }

        private void cbCondominio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnAreaTotalTerreno.Focus();

            }
        }

        private void txtnAreaTotalTerreno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnAreaTotalConstruida.Focus();

            }
        }

        private void txtnAreaTotalConstruida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCod1.Focus();

            }
        }

        private void txtnCod1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnNomeResidencia1.Focus();

            }
        }

        private void txtnNomeResidencia1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnBloco1.Focus();

            }
        }

        private void txtnBloco1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbTipo1.Focus();

            }
        }

        private void cbTipo1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCod2.Focus();

            }
        }

        private void txtnCod2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnNomeResidencia2.Focus();

            }
        }

        private void txtnNomeResidencia2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnBloco2.Focus();

            }
        }

        private void txtnBloco2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbTipo2.Focus();

            }
        }

        private void cbTipo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnCod3.Focus();

            }
        }

        private void txtnCod3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnNomeResidencia3.Focus();

            }
        }

        private void txtnNomeResidencia3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnBloco3.Focus();

            }
        }

        private void txtnBloco3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                cbTipo3.Focus();

            }
        }

        private void cbTipo3_KeyDown(object sender, KeyEventArgs e)
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
                cbCondominio.Focus();

            }
        }

        private void FrmCadResidencias_Load(object sender, EventArgs e)
        {
            CadastroResidencia cadResidencia = new CadastroResidencia();
            txtnCod1.Text = Convert.ToString(cadResidencia.autoIncremento());
            txtnCod2.Text = Convert.ToString(cadResidencia.autoIncremento());
            txtnCod3.Text = Convert.ToString(cadResidencia.autoIncremento());
        }

        private void txtnFraçãoIdeal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
