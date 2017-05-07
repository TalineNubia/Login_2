using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
   public class CadFuncionario
    {
        private string codigo;
        private string nome;
        private string cpf;
        private string rg;
        private string fone;
        private string sexo;
        private string email;
        private string estado_civil;
        private string cep;
        private string municipio;
        private string uf;
        private string endereço;
        private string numero;
        private string bairro;
        private string dataNascimento;
        private string despesa;
        private string cargo;
        private string condominio;
        


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
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
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
        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }
      
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string EstadoCivil
        {
            get { return estado_civil; }
            set { estado_civil = value; }
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
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
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
        public string DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }
    }
}
