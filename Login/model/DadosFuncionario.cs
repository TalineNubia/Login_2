using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class DadosFuncionario
    {
        
        private String nome;
        private String operaSistema;
        private String senha;
        private String cargo;
        private String dataAdmissao;
        private String periodo;
        private String periodo1;
        private String dataDemissao;
        private String salarioMensal;
        private String contato;
        private String observacao;


        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string OperaSistema
        {
            get { return operaSistema; }
            set { operaSistema = value; }

        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }

        }

        public string DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }

        public string Perido
        {
            get { return periodo; }
            set { periodo = value; }

        }

        public string Periodo1
        {
            get { return periodo1; }
            set { periodo1 = value; }
        }

        public string DataDemissao
        {
            get { return dataDemissao; }
            set { dataDemissao = value; }

        }

        public string SalarioMensal
        {
            get { return salarioMensal; }
            set { salarioMensal = value; }
        }

        public string Contato
        {
            get { return contato; }
            set { contato = value; }

        }

        public string Observação
        {
            get { return observacao; }
            set { observacao = value; }
        }


    }
}
