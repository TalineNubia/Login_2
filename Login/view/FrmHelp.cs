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
    public partial class FrmHelp : Form
    {
        public FrmHelp()
        {
            InitializeComponent();
        }

        private void FrmHelp_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void FrmHelp_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btMais_Click(object sender, EventArgs e)
        {
            FrmHelp2 help2 = new FrmHelp2();
            this.Visible = false;
            help2.ShowDialog();
           

        }

        private void btSair_Click(object sender, EventArgs e)
        {
           
                this.Close();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
