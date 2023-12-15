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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            string[] categorias = new string[2];
            categorias[0] = "Software";
            categorias[1] = "Hardware";
            for (int i = 0; i < 2; i++)
            {
                cbcategoria.Items.Add(categorias[i]);
            }
        }

        private void cbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
