﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasses
{
    abstract class Empregado
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public Empregado()
        {
            System.Windows.Forms.MessageBox.Show("PASSEI POR AQUI");
        }

        public Empregado(int mat, string nome, DateTime datax)
        {
            matricula = mat;
            nomeEmpregado = nome;
            dataEntradaEmpresa = datax;
        }

        public int Matricula //propriedade
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string NomeEmpregado //propriedade
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa //propriedade
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public char HomeOffice //propriedade
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        //métodos

        public string VerificaHome() //método
        {
            if (homeOffice == 'S')
                return "Empregado trabalha em home office";
            else
                return "Empregado não trabalha em home office";
        }

        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days);
        }

        public abstract double SalarioBruto();

    }
}
