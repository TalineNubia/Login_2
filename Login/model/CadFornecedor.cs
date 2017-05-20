using Login.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class CadFornecedor : Pessoa
    {
        private string codigo;
        private string cnpj;
        private string ie;
        private string webSite;
        private string observacao;
        private string despesa;
        
        


        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
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
     
        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }
    }
}
