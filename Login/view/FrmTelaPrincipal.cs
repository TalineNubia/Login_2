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
    public partial class FrmTelaPrincipal : Form
    {
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void condominiosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void lançarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmCadCondominios CadastroCondominio1 = new FrmCadCondominios();
            CadastroCondominio1.ShowDialog();
            
            
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {


        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
          switch (e.KeyCode)
            {
                case Keys.H:
                    sistemaToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.A:
                    lançarToolStripMenuItem2_Click(sender, e);
                    break;
                case Keys.I:
                    consultarMToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.C:
                    lançarToolStripMenuItem3_Click(sender, e);

                    break;
                case Keys.F1:
                    consultarToolStripMenuItem12_Click(sender, e);
                    break;
                case Keys.F2:
                    consultarResidenciasToolStripMenuItem4_Click(sender, e);
                    break;
                case Keys.P:
                    lançarToolStripMenuItem4_Click(sender, e);
                    break;
                case Keys.F3:
                    consultarToolStripMenuItem5_Click(sender, e);
                    break;
                case Keys.F4:
                    consultarToolStripMenuItem2_Click(sender, e);
                    break;
                
                case Keys.O:
                    cadastrarToolStripMenuItem1_Click(sender, e);
                    break;

                case Keys.F5:
                    consultarFornecedorToolStripMenuItem6_Click(sender, e);
                    break;

                case Keys.F:
                    cadastrarFornecedorToolStripMenuItem2_Click(sender, e);
                    break;
                case Keys.F6:
                    consultarContasAPagarToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.B:
                    consultarBalanceteToolStripMenuItem7_Click(sender, e);
                    break;
                case Keys.N:
                    cadastrarFuncionarioToolStripMenuItem3_Click(sender, e);
                    break;

                case Keys.U:
                    ajudaToolStripMenuItem1_Click(sender, e);
                    break;


                case Keys.F7:
                    consultarFuncionarioToolStripMenuItem8_Click(sender, e);
                    break;


                case Keys.F8:
                    lançarFuncionarioToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F9:
                    consultarToolStripMenuItem1_Click(sender, e);
                    break;

                case Keys.T:
                    lançarLContasAPagarToolStripMenuItem_Click(sender, e);
                    break;


                case Keys.F10:
                    consultarToolStripMenuItem_Click_1(sender, e);
                    break;

                case Keys.M:
                    lançarToolStripMenuItem_Click(sender, e);

                    break;

                case Keys.D:
                    cadastrarToolStripMenuItem_Click_1(sender, e);
                    break;



                case Keys.F11:
                    consultasToolStripMenuItem_Click(sender, e);
                    break;

                case Keys.F12:
                    Mensagem sair = new Mensagem();                                                         
                    sair.fim();
                    tsbSair_Click(sender, e);
                    break;
            }

        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
                
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {

        }

        private void tsdCondominio_Click(object sender, EventArgs e)
        {

        }

        private void tsbProprietario_ButtonClick(object sender, EventArgs e)
        {

        }

        private void lançarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            // Abri tela para cadastrar proprietario

            FrmCadProprietarios CadastroProprietario1 = new FrmCadProprietarios();
            CadastroProprietario1.ShowDialog();
        }

        private void CadastrarToolStripMenuItem7_Click(object sender, EventArgs e)
        { // Abrir tela para Cadastrar Fornecedor

        }

        private void ConsultarPedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem12_Click(object sender, EventArgs e)
        { // abrir tela para consultar condominios
            FrmConsultaCondominios consultarCondominio1 = new FrmConsultaCondominios();
            consultarCondominio1.ShowDialog();
            

        }

        private void consultarResidenciasToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmConsultaResidencia consultaResidencia1 = new FrmConsultaResidencia();
            consultaResidencia1.ShowDialog();
            
        }

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmConsultaProprietario ConsultaProprietario1 = new FrmConsultaProprietario();
            ConsultaProprietario1.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaMensalidade consultaMensalidade1 = new FrmConsultaMensalidade();
            consultaMensalidade1.ShowDialog();

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadPedidos cadastrarPedido1 = new FrmCadPedidos();
            cadastrarPedido1.ShowDialog();
            
            
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultaPedido consultaPedido1 = new FrmConsultaPedido();
            consultaPedido1.ShowDialog();
        }

        private void cadastrarFornecedorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCadFornecedores cadastroFornecedor1 = new FrmCadFornecedores();
            cadastroFornecedor1.ShowDialog();
        }

        private void consultarFornecedorToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor consultaFornecedor1 = new FrmConsultaFornecedor();
            consultaFornecedor1.ShowDialog();
        }

        private void consultarBalanceteToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            FrmConsultarBalancete consultarBalancete1 = new FrmConsultarBalancete();
            consultarBalancete1.ShowDialog();
        }

        private void cadastrarFuncionarioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmCadFuncionario cadastroFuncionario1 = new FrmCadFuncionario();
            cadastroFuncionario1.ShowDialog();
        }

        private void consultarFuncionarioToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            FrmConsultaFuncionario consultaFuncionario1 = new FrmConsultaFuncionario();
            consultaFuncionario1.ShowDialog();
        }

        private void tsbBackup_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaParFornecedor consultaParFornecedor1 = new FrmConsultaParFornecedor();
            consultaParFornecedor1.ShowDialog();
        }

        private void lançarLContasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLancarContasAPagar lancarContasApagar1 = new FrmLancarContasAPagar();
            lancarContasApagar1.ShowDialog();
        }

        private void consultarF9ContasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaParFornecedor consultaParFornecedor1 = new FrmConsultaParFornecedor();
            consultaParFornecedor1.ShowDialog();
        }

        private void lançarF9FuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLancaFuncionario lancarFuncionario1 = new FrmLancaFuncionario();
            lancarFuncionario1.ShowDialog();
        }

        private void consultarMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCondômino consultaCondômino1 = new FrmConsultaCondômino();
            consultaCondômino1.ShowDialog();
        }

        private void lançarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCadBanco cadastrarBanco1 = new FrmCadBanco();
            cadastrarBanco1.ShowDialog();

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaBanco consultaBanco1 = new FrmConsultaBanco();
            consultaBanco1.ShowDialog();

        }

        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCadDespesa cadastrarDespesa1 = new FrmCadDespesa();
            cadastrarDespesa1.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmConsultaDespesa consultarDespesa1 = new FrmConsultaDespesa();
            consultarDespesa1.ShowDialog();

        }

        private void lançarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLancarMensalidade lancarMensalidade1 = new FrmLancarMensalidade();
            lancarMensalidade1.ShowDialog();
        }

        private void consultarContasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaParFornecedor consultaParFornecedor1 = new FrmConsultaParFornecedor();
            consultaParFornecedor1.ShowDialog();
        }

        private void lançarFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLancaFuncionario lancarFuncionario1 = new FrmLancaFuncionario();
            lancarFuncionario1.ShowDialog();

        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHelp help1 = new FrmHelp();
            this.Visible = false;
            help1.ShowDialog();
            this.Visible = false;
            FrmTelaPrincipal telaPrincipal = new FrmTelaPrincipal();
            telaPrincipal.ShowDialog();

        }
    }
}

