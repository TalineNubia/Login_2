using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.view;
using Login.Properties;

namespace Login
{
    public class Mensagem
    {
        #region " MENSAGEM SAIR DO SISTEMA"
        public void fim()
        {

            string texto = " Deseja realmente sair? ";
            string titulo = "**  FINALIZANDO **";
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
        #endregion

        #region "MENSAGEM SALVAR CADASTRO"
        public void salvando()
        {

            string texto = " Cadastro salvo com sucesso! ";
            string titulo = "**  SALVO **";
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.OK) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region "MENSAGEM SENHA"
        public void senha()
        {
            string texto = " Login ou senha invalidos, Por favor verificar..";
            string titulo = "** ERROR **";
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region "MENSAGEM EXCLUINDO"
        public void excluindo()
        {
            string texto = " Deseja realmente excluir? ";
            string titulo = "**  EXCLUINDO **";
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

            }
        }
        #endregion

        #region "MENSAGEM CANCELANDO"
        public void cancelando()
        {

            string texto = " Deseja realmente sair? ";
            string titulo = "**  FINALIZANDO **";
            if (MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

            }
            #endregion
        }
    }
}
