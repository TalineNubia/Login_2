using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.view;
using Login.model;

namespace Login.view
{
    public class CadastroProprietario : Pessoa 
    {
        private string codigo;
        private string cpf;
        private string rg;
        private string condominio;
        private string morador;
              


        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }

        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Rg
        {
            get { return cpf; }
            set { rg = value; }
        }

      
        public string Condominio
        {
            get { return condominio; }
            set { condominio = value; }
        }

        public string Morador
        {
            get { return morador; }
            set { morador = value; }

        }

        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }
    }

}
