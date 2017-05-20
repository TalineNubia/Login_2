using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using MySql.Data.Types;
using System.Data.SqlClient;
using Login.model;

namespace Login.view
{
    public partial class FrmCadPedidos : Form
    {
        List<Pedido> listaCadPedido = new List<Pedido>();
        int ponteiro = 0;
        
        

        public FrmCadPedidos()
        {
            InitializeComponent();
        }

        private void CadPedidos_KeyDown(object sender, KeyEventArgs e)
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
            FrmConsultaPedido consultarPedido1 = new FrmConsultaPedido();
            this.Visible = false;
            consultarPedido1.ShowDialog();
            this.Visible = false;
            FrmCadPedidos cadastroPedido1 = new FrmCadPedidos();
            cadastroPedido1.ShowDialog();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

                //passa a string de conexão 
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306; User Id=root;database=bdcondominio;password=''");
                //Abre o banco de dados
                

                string sql = "insert into pedido (nome,  datapedido, condominio, unidade, prioridade, fone, pedido,resposta) " +
                    "values (@nome, @datapedido, @condominio, @unidade, @prioridade, @fone, @pedido,@resposta)";

            //Parametros do comando

            try
            {
                MySqlCommand objcmd = new MySqlCommand(sql, objcon);

                objcon.Open();                
                objcmd.Parameters.Add(new MySqlParameter("@nome",this.txtnNome.Text));
                objcmd.Parameters.Add(new MySqlParameter("@datapedido", this.txtnDataPedido.Text));
                objcmd.Parameters.Add(new MySqlParameter("@condominio", this.cbCondominio.Text));
                objcmd.Parameters.Add(new MySqlParameter("@unidade", this.cbUnidade.Text));
                objcmd.Parameters.Add(new MySqlParameter("@prioridade", this.cbPrioridade.Text ));
                objcmd.Parameters.Add(new MySqlParameter("@fone", this.txtnFone.Text));
                objcmd.Parameters.Add(new MySqlParameter("@pedido",this.txtnPedido.Text));
                objcmd.Parameters.Add(new MySqlParameter("@resposta", this.txtnResposta.Text));

                objcmd.ExecuteNonQuery();                

            }
            catch (Exception erro)
            {
                MessageBox.Show("Não conectou: "+ erro);
            }
            finally
            {
                objcon.Close();
                Mensagem salvar = new Mensagem();
                salvar.salvando();
                LimparTela limpa = new LimparTela();
                limpa.Limpar(this);
            }


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

            if (ponteiro < listaCadPedido.Count - 1)
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
                txtnFone.Clear();
                txtnPedido.Clear();
                txtnResposta.Clear();
                cbCondominio.Text = "";
                cbPrioridade.Text = "";
                cbUnidade.Text = "";
                txtnNome.Focus();

            }
            else
            {
                txtnCOD.Text = listaCadPedido[ponteiro].Codigo;
                txtnNome.Text = listaCadPedido[ponteiro].Nome;
                txtnPedido.Text = listaCadPedido[ponteiro].Observação;
                txtnResposta.Text = listaCadPedido[ponteiro].Resposta;
                cbPrioridade.Text = listaCadPedido[ponteiro].Prioridade;
                cbCondominio.Text = listaCadPedido[ponteiro].Condominio;
                cbUnidade.Text = listaCadPedido[ponteiro].Unidade;
                txtnFone.Text = listaCadPedido[ponteiro].Fone;
            }

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (listaCadPedido.Count > 0)
                listaCadPedido.RemoveAt(ponteiro);

            if (listaCadPedido.Count > 0)
            {
                ponteiro = listaCadPedido.Count - 1;
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
                txtnDataPedido.Focus();

            }
        }

        private void txtnDataPedido_KeyDown(object sender, KeyEventArgs e)
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
                cbPrioridade.Focus();

            }
        }

        private void cbPrioridade_KeyDown(object sender, KeyEventArgs e)
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
                txtnPedido.Focus();

            }
        }

        private void txtnPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtnResposta.Focus();

            }
        }

        private void txtnResposta_KeyDown(object sender, KeyEventArgs e)
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

        private void FrmCadPedidos_Load(object sender, EventArgs e)
        {
           /* Pedido cadPedido = new Pedido();
            incrementar = cadPedido.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
            */
        }
    }
}

