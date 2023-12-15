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
    public partial class Form2 : Form
    {
        Form4 form4;
        Form3 form3;
        Form2 form2;
        Form1 form1;


        public bool tsf2;
        public bool msf2;
        public bool tsf3;
        private Timer timer;
        public Form2()
        {
            InitializeComponent();
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();

            toolStripBtnGuardar.Enabled = false;
            toolStripBtnGuardarComo.Enabled = false;
            menuStrip1.Enabled = false;

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            AtualizarHoras();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void registoDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form2 form2Instance = new Form2();
            Form4 form4 = new Form4(form2Instance);
            form4.MdiParent = this;
            form4.Show();
            verificarperm();
        }

        private void toolStripBtnLogin_Click(object sender, EventArgs e)
        {
            Form2 form2Instance = new Form2();
            Form4 form4 = new Form4(form2Instance);
            form4.MdiParent = this;
            form4.Show();
            verificarperm();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void verificarperm()
        {
            if (tsf2 == false)
            {
                toolStripBtnGuardar.Enabled = false;
                toolStripBtnGuardarComo.Enabled = false;
                menuStrip1.Enabled = false;

            }
            else if (tsf2 == true)
            {
                menuStrip1.Enabled = true;
                toolStripBtnGuardar.Enabled = true;
                toolStripBtnGuardarComo.Enabled = true;
            }
        }

        private void toolStripBtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripBtnGuardarComo_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AtualizarHoras();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void AtualizarHoras()
        {
            DateTime horaAtual = DateTime.Now;
            toolStripStatusLabel1.Text =  horaAtual.ToString("HH:mm");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
