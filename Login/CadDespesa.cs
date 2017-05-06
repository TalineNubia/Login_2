using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class CadDespesa
    {
        private String codigo;
        private String despesa;
        private String tipoDespesa;
        private String valorDespesa;
        private String observacao;
        


      public string Codigo
        { 
            get { return codigo; }
            set { codigo = value; }

        }

        public string Despesa
        {
            get { return despesa; }
            set { despesa = value; }
        }
        public string TipoDespesa
        {
            get { return tipoDespesa; }
            set { tipoDespesa = value; }
        }

        public String Valor
        {
            get { return valorDespesa; }
            set { valorDespesa = value; }
        }
        public string Observação
        {
            get { return observacao; }
            set { observacao = value; }
        }
        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }
    }
}
