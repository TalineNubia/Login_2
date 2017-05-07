using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.view;


namespace Login.view
{
    public class CadastroCondominio
    {
        private string codigo;
        private string nome;
        private string email;
        private string fone;
        private string cnpj;
        private string ie;
        private string cep;
        private string municipio;
        private string endereço;
        private string bairro;
        private string numero;
        private string registroMatricial;
        private string registroPredial;
        private string uf;
        

        public string Codigo_condominio
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nome_condominio
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email_condominio
        {
            get { return email; }
            set { email = value; }
        }
        public string Fone_condominio
        {
            get { return fone; }
            set { fone = value; }
        }
        public string Cnpj_condominio
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        public string Ie_condominio
        {
            get { return ie; }
            set { ie = value; }
        }
        public string Cep_condominio
        {
            get { return cep; }
            set { cep = value; }
        }
        public string Municipio_condominio
        {
            get { return municipio; }
            set { municipio = value; }
        }
        public string Endereço_condominio
        {
            get { return endereço; }
            set { endereço = value; }
        }
        public string Numero_condominio
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Bairro_condominio
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Uf_condominio
        {
            get { return uf; }
            set { uf = value; }
        }
        public string RegistroMatricial_condominio
        {
            get { return registroMatricial; }
            set { registroMatricial = value; }
        }
        public string RegistroPredial_condominio
        {
            get { return registroPredial; }
            set { registroPredial = value; }
        }
        public int autoIncremento (int incremento)
        {
             return ++incremento;
         }  
    }

}
