using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.model
{
    public class Mensalidade
    {
        private string condominio;
        private Decimal valorDesp;
        private Decimal fracao;
        private Decimal valorFatura;
        private int parcela;
        private string banco;
        private string codCliente;
        private string nomeCliente;
        private string status;
        private string datavencimento;
        private string dataMes;


        public string Condominio
        {
            get { return condominio; }
            set { condominio = value; }
        }
        public Decimal ValorDespesa
        {
            get { return valorDesp; }
            set { valorDesp = value; }
        }
        public Decimal FracaoIdeal
        {
            get { return fracao; }
            set { fracao = value; }
        }

        public Decimal ValorFatura
        {
            get { return valorFatura; }
            set { valorFatura = value; }
        }
        public int Parcela
        {
            get { return parcela; }
            set { parcela = value; }
        }
        public string Banco
        {
            get { return banco; }
            set { banco = value; }
        }
        public string Codigo
        {
            get { return codCliente; }
            set { codCliente = value; }
        }
        public string Nome
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string DataPadrao
        {
            get { return datavencimento; }
            set { datavencimento = value; }
        }
        public string DataMes
        {
            get { return dataMes; }
            set { dataMes = value; }
        }
     


    }
}
