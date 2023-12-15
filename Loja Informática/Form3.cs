using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_Informática
{
    public partial class Form3 : Form
    {
        Form4 form4;
        Form2 form2;

        private bool tsf3ssssss;
        public Form3()
        {
            InitializeComponent();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            verificarperm();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void verificarperm()
        {
            if (form2.tsf3 == false)
            {
                toolStrip1.Enabled = false;
                MessageBox.Show("Não tem Permissão para fazer Alterações!", "Aviso");

            } else if (form2.tsf3 == true)
            {
                toolStrip1.Enabled = true; 
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        public void logout()
        {

        }
    }
}
