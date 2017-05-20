using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class LancarFuncionario
    {
        private string codigo;
        private String nome;
        private String despesa;
        private String condominio;
        private String refenteMes2;
        private String valor;
        private String referenteMes;
        private String vencimento;
        private String observacao;
        


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


        public string Despesa
        {
            get { return despesa; }
            set { despesa = value; }
        }

        public string Condominio
        {
            get { return condominio; }
            set { condominio = value; }

        }

        public string ReferenteMes2
        {
            get { return refenteMes2; }
            set { refenteMes2 = value; }

        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string ReferenteMes
        {
            get { return referenteMes; }
            set { referenteMes = value; }

        }

        public string Vencimento
        {
            get { return vencimento; }
            set { vencimento = value; }
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
