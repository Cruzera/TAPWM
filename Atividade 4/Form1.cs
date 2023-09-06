using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("butao");
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            frmMensalista frmMens = new frmMensalista();
            frmMens.Show();
        }

        private void Horista_Click(object sender, EventArgs e)
        {
            frmHorista frmH = new frmHorista();
            frmH.Show();
        }
    }
}