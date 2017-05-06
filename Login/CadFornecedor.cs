using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class CadFornecedor
    {
        private string codigo;
        private string nome;
        private string email;
        private string fone;
        private string fone1;
        private string cnpj;
        private string ie;
        private string cep;
        private string municipio;
        private string endereço;
        private string bairro;
        private string uf;
        private string numero;
        private string complemento;
        private string webSite;
        private string observacao;
        private string despesa;
        private string status;
        


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
        public string Fone1
        {
            get { return fone1; }
            set { fone1 = value; }
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
        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Municipio
        {
            get { return municipio; }
            set { municipio = value; }
        }
        public string Endereço
        {
            get { return endereço; }
            set { endereço = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        public string WebSite
        {
            get { return webSite; }
            set { webSite = value; }
        }
        public string Observação
        {
            get { return observacao; }
            set { observacao = value; }
        }
        public string Despesa
        {
            get { return despesa; }
            set { despesa = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }
    }
}
