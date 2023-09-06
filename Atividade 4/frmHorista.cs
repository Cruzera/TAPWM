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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void FrmHorista_Load(object sender, EventArgs e)
        {

        }

        private void BtnInstanciar_Click(object sender, EventArgs e)
        {
            // criando o objeto, instanciando o objeto
            Horista ObjHorista = new Horista();

            ObjHorista.NomeEmpregado = txtNome.Text;
            ObjHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            ObjHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            ObjHorista.NumeroHora = Convert.ToDouble(txtHoras.Text);
            ObjHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            ObjHorista.DiasFalta = Convert.ToInt32(txtFaltas.Text);

            MessageBox.Show("Nome: " + ObjHorista.NomeEmpregado +
                "\n" + "Matrícula: " + ObjHorista.Matricula + "\n" +
                "Tempo de Trabalho: " + ObjHorista.TempoTrabalho().ToString()
                + "\n" + "Salário: " + ObjHorista.SalarioBruto().ToString("N2"));
        }
    }
}
