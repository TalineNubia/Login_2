using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.model
{
    public abstract class Pessoa : Endereco
    {
        private string codigo;
        private string nome;
        private string fone;
        private string fone1;
        private string cadastroSimNao;
        private string email;
        private string estado_civil;
        private string dataNascimento;
        private string sexo;
        private string status;


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

        public string Fone
        {
            get { return fone; }
            set { fone = value; }
        }

        public string DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public string Fone1
        {
            get { return fone1; }
            set { fone1 = value; }
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
        public string Status
        {
            get { return status; }
            set { status = value; }
        }


    }
}
