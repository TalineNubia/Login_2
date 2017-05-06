using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class CadBanco
    {
        private string codigo;
        private string razaoSocial;
        private string condominio;
        private string cnpj;
        private string ie;
        private string banco;
        private string agencia;
        private string conta;
        private string emiteBoleto;
        private string nossoNumero;
        private string dataVencimento;
        private string lancaRemessa;
        private string recuperaRemessa;
        

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }
        public string Condominio
        {
            get { return condominio; }
            set { condominio = value; }
        }
        public string CNPJ
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string IE
        {
            get { return ie; }
            set { ie = value; }
        }
        public string Banco
        {
            get { return banco; }
            set { banco = value; }
        }
        public string Agencia
        {
            get { return agencia; }
            set { agencia = value; }
        }
        public string Conta
        {
            get { return conta; }
            set { conta = value; }
        }
        public string EmiteBoleto
        {
            get { return emiteBoleto; }
            set { emiteBoleto = value; }
        }


        public string NossoNumero
        {
            get { return nossoNumero; }
            set { nossoNumero = value; }
        }
        public string DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }
        public string LançaRmessa
        {
            get { return lancaRemessa; }
            set { lancaRemessa = value; }
        }
        public string RecuperaRemessa
        {
            get { return recuperaRemessa; }
            set { recuperaRemessa = value; }
        }

        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }
    }
}
