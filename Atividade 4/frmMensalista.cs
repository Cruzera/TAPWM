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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void FrmMensalista_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalario.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);

            if (rbtnSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            //get
            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" +
                "nome: " + objMensalista.NomeEmpregado + "\n" +
                "Data Entrada: " +
                objMensalista.DataEntradaEmpresa.ToShortDateString() +
                "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2")
                + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() +
                "\n" + objMensalista.VerificaHome());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Mensalista ObjMensalista = new Mensalista(
                Convert.ToInt32(txtMatricula.Text),
                txtNome.Text, Convert.ToDateTime(txtData.Text),
                Convert.ToDouble(txtSalario.Text));

            MessageBox.Show("Nome: " + ObjMensalista.NomeEmpregado + "\n" +
                "Matrícula: " + ObjMensalista.Matricula + "\n" +
                "Tempo de Trabalho: " + ObjMensalista.TempoTrabalho() +
                "\n" + "Salário Final: " +
                ObjMensalista.SalarioBruto().ToString("N2"));

            MessageBox.Show(Mensalista.Empresa);
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
