using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.view
{
    public partial class FrmConsultaResidencia : Form
    {
        public FrmConsultaResidencia()
        {
            InitializeComponent();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            FrmCadResidencias cadastroResidencia1 = new FrmCadResidencias();
            this.Visible = false;
            cadastroResidencia1.ShowDialog();
            
        }

        private void ConsultaResidencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
           
          
            }

        private void btCancelar_Click(object sender, EventArgs e)
        {
           
                this.Close();
         
        }
    }
 }

