using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.view;
using Login.model;

namespace Login.view
{
    class CadastroCondômino : Pessoa
    {
        private string codigo;
        private string cpf { get; set; }
        private string rg;
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

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
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
