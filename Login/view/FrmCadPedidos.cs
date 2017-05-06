﻿using System;
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
    public partial class FrmCadPedidos : Form
    {
        List<Pedido> listaCadPedido = new List<Pedido>();
        int ponteiro = 0;
        int incrementar;

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
            Pedido cadastro = new Pedido();

            cadastro.Codigo = (txtnCOD.Text);
            cadastro.Nome = (txtnNome.Text);
            cadastro.Data = (txtnDataPedido.Text);
            cadastro.Condominio = (cbCondominio.Text);
            cadastro.Observação = (txtnPedido.Text);
            cadastro.Prioridade = (cbPrioridade.Text);
            cadastro.Resposta = (txtnResposta.Text);
            cadastro.Fone = (txtnFone.Text);

            listaCadPedido.Add(cadastro);
            ponteiro = listaCadPedido.Count - 1;
            LoadField(true);

            Mensagem salvar = new Mensagem();
            salvar.salvando();
            txtnCOD.Clear();
            txtnNome.Clear();
            txtnFone.Clear();
            txtnPedido.Clear();
            txtnResposta.Clear();
            cbCondominio.Text = "";
            cbPrioridade.Text = "";
            cbUnidade.Text = "";
            txtnNome.Focus();

            Pedido incremento = new Pedido();
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
            Pedido cadPedido = new Pedido();
            incrementar = cadPedido.autoIncremento(incrementar);
            txtnCOD.Text = Convert.ToString(incrementar);
        }
    }
}
