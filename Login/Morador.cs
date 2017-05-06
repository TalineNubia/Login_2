using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Morador
    {
        private string codigo;
        private string nome;
        private string cpf;
        

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
