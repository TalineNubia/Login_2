using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Pedido
    {
        private String codigo;
        private String nome;
        private String data;
        private String condominio;
        private String unidade;
        private String prioridade;
        private String fone;
        private String observacao;
        private String resposta;
        

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

        public string Data
        {
            get { return data; }
            set { data = value; }
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
        public string Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }
        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }
        public string Observação
        {
            get { return observacao; }
            set { observacao = value; }
        }

        public string Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }
        public int autoIncremento(int incremento)
        {
            return ++incremento;
        }
    }
}
