using Login.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
   public class CadFuncionario : Pessoa
    {
        private string codigo;
        private string cpf;
        private string rg;
        private string despesa;
        private string cargo;
        private string condominio;
        


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

        public string Despesa
        {
            get { return despesa; }
            set { despesa = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
      
        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }
    }
}
