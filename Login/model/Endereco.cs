using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.model
{
    public class Endereco
    {
        private string endereço;
        private string numero;
        private string cep;
        private string municipio;
        private string uf;
        private string bairro;
        private string complemento;


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

    }
}
