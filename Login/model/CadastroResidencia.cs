using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.view;


namespace Login.view
{
    public class CadastroResidencia
    {
        private String codigo;
        private String condominio;
        private Decimal area_total_terreno;
        private String nome_residencia;
        private String bloco;
        private String tipo;
        private Decimal area_total_construida;
        private int contador;
        
        


        public string Codigo_Residencia
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nome_Condominio
        {
            get { return condominio; }
            set { condominio = value; }
        }
        //calculo fraçao

        public Decimal AreaTotalTerreno
        {
            get { return area_total_terreno; }
            set { area_total_terreno = value; }
        }


        public Decimal AreaTotalConstruida
        {
            get { return area_total_construida; }
            set { area_total_construida = value; }
        }


        public Decimal FraçaoIdeal()
        {
            return area_total_terreno / area_total_construida;

        }


        public string Nome_Residencia
        {
            get { return nome_residencia; }
            set { nome_residencia = value; }
        }
        public string Bloco
        {
            get { return bloco; }
            set { bloco = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int autoIncremento()
        {
            return contador++;
        }
    }
}
