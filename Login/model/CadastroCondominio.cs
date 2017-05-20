using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.view;
using Login.model;

namespace Login.view
{
    public class CadastroCondominio : Endereco
    {
        private string codigo;
        private string nome;
        private string email;
        private string fone;
        private string cnpj;
        private string ie;
        private string registroMatricial;
        private string registroPredial;
        



        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string Ie
        {
            get { return ie; }
            set { ie = value; }
        }
       
        public string RegistroMatricial
        {
            get { return registroMatricial; }
            set { registroMatricial = value; }
        }
        public string RegistroPredial_condominio
        {
            get { return registroPredial; }
            set { registroPredial = value; }
        }
        public int autoIncremento (int incremento)
        {
             return ++incremento;
         }  
    }

}
