using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.view;

namespace Login.view
{
    class ClassCadastroCondômino
    {
        private string codigo;
        private string nome;
        private string cpf;
        private string fone;
        private string cadastroSimNao;
        private string email;
        private string estado_civil;
        private string condominio;
        private string unidade;
        private string nomeConjugue;
        private string cpfConjugue;
        private string foneConjugue;
        

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
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }
        public string CadastroSimNao
        {
            get { return cadastroSimNao; }
            set { cadastroSimNao = value; }
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



        public string Condominio
        {
            get { return condominio; }
            set { condominio = value; }
        }

        public string Unidade
        {
            get { return unidade; }
            set { unidade = value; }
        }

        public string Nome_Conjugue
        {
            get { return nomeConjugue; }
            set { nomeConjugue = value; }

        }

        public string Cpf_Conjugue
        {
            get { return cpfConjugue; }
            set { cpfConjugue = value; }
        }
        public string Fone_Conjugue
        {
            get { return foneConjugue; }
            set { foneConjugue = value; }
        }
        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }
    }
}
