using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class ContasAPagar
    {
        private String codigo;
        private String nome;
        private String despesa;
        private String condominio;
        private String dataVencimento;
        private String unidade;
        private String valor;
        private String serieNota;
        private String numeroNota;
        

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
        public string DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }
        public string Unidade
        {
            get { return unidade; }
            set { unidade = value; }
        }
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public string SerieNota
        {
            get { return serieNota; }
            set { serieNota = value; }
        }
        public string NumeroNota
        {
            get { return numeroNota; }
            set { numeroNota = value; }
        }
        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }
    }
}
