using Login.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Morador : Pessoa
    {
        private string codigo;
        private string cpf;
        

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
        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }

    }
}
