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
    public partial class Form4 : Form
    {
        public string username = "Admin";//admin
        public string usernamefraco = "user";


        public string passAdmin = "AdoroPSI"; //admin
        public string pass = "OdeioPSI";


        public string superadmin = "Paulo Barreira";

        Form2 form2;
        public Form4(Form2 form2Instace)
        {
            InitializeComponent();
            form2 = form2Instace;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == passAdmin && tbUtilizador.Text == username)
            {
                form2.tsf2 = true;
                form2.tsf3 = true;
                this.Close();
            }
            else if (tbPass.Text == pass && tbUtilizador.Text == usernamefraco)
            {
                form2.tsf2 = false;
                form2.tsf3 = false;
                this.Close();
            }
            else if (tbNome.Text == superadmin)
            {
                form2.tsf2 = true;
                this.Close();
            }
            else
            {

            }
        }
    }
}
