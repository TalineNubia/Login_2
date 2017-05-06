using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.view;


namespace Login.view
{
    public class CadastroProprietario 
    {
        private string codigo;
        private string nome;
        private string cpf;
        private string rg;
        private string fone;
        private string fone1;
        private string email;
        private string estado_civil;
        private string cep;
        private string municipio;
        private string uf;
        private string endereço;
        private string numero;
        private string bairro;
        private string condominio;
        private string morador;
        private string complemento;
        


        public string Codigo_proprietario
        {
            get { return codigo; }
            set { codigo = value; }

        }

        public string Nome_Proprietario
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cpf_Proprietario
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Rg_proprietario
        {
            get { return cpf; }
            set { rg = value; }
        }
        public string Fone_proprietario
        {
            get { return fone; }
            set { fone = value; } 
        }
        public string Fone1_proprietario
        {
            get { return fone1; }
            set { fone1 = value; }
        }
        public string Email_proprietario
        {
            get { return email; }
            set { email = value; }
        }
        public string EstadoCivil_proprietario
        {
            get { return estado_civil; }
            set { estado_civil = value; }
        }
        public string Cep_proprietario
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Municipio_proprietario
        {
            get { return municipio; }
            set { municipio = value; }
        }
        public string Uf_proprietario
        {
            get { return uf; }
            set { uf = value; }
        }
        public string Endereço_proprietario
        {
            get { return endereço; }
            set { endereço = value; }
        }
        public string Numero_proprietario
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Bairro_proprietario
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Condominio_proprietario
        {
            get { return condominio; }
            set { condominio = value; }
        }

        public string Morador_proprietario
        {
            get { return morador; }
            set { morador = value; }

        }

        public string Complemento_proprietario
        {
            get { return complemento; }
            set { complemento = value; }
        }
        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }
    }

}
