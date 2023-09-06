namespace Pclasses
{
    partial class frmMensalista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.rbtnSim = new System.Windows.Forms.RadioButton();
            this.rbtnNao = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.gbHomeOffice = new System.Windows.Forms.GroupBox();
            this.btnInstanciar2 = new System.Windows.Forms.Button();
            this.btnInstanciar1 = new System.Windows.Forms.Button();
            this.gbHomeOffice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(60, 72);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(73, 20);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(282, 72);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(221, 26);
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // rbtnSim
            // 
            this.rbtnSim.AutoSize = true;
            this.rbtnSim.Location = new System.Drawing.Point(6, 51);
            this.rbtnSim.Name = "rbtnSim";
            this.rbtnSim.Size = new System.Drawing.Size(61, 24);
            this.rbtnSim.TabIndex = 2;
            this.rbtnSim.TabStop = true;
            this.rbtnSim.Text = "Sim";
            this.rbtnSim.UseVisualStyleBackColor = true;
            this.rbtnSim.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // rbtnNao
            // 
            this.rbtnNao.AutoSize = true;
            this.rbtnNao.Location = new System.Drawing.Point(6, 90);
            this.rbtnNao.Name = "rbtnNao";
            this.rbtnNao.Size = new System.Drawing.Size(63, 24);
            this.rbtnNao.TabIndex = 3;
            this.rbtnNao.TabStop = true;
            this.rbtnNao.Text = "Não";
            this.rbtnNao.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(60, 116);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.LblNome_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(60, 167);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(113, 20);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salário Mensal";
            this.lblSalario.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(60, 215);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(195, 20);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data Entrada na Empresa";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(282, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 26);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(282, 167);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 26);
            this.txtSalario.TabIndex = 8;
            this.txtSalario.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(282, 215);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 26);
            this.txtData.TabIndex = 9;
            this.txtData.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // gbHomeOffice
            // 
            this.gbHomeOffice.Controls.Add(this.rbtnSim);
            this.gbHomeOffice.Controls.Add(this.rbtnNao);
            this.gbHomeOffice.Location = new System.Drawing.Point(564, 72);
            this.gbHomeOffice.Name = "gbHomeOffice";
            this.gbHomeOffice.Size = new System.Drawing.Size(170, 125);
            this.gbHomeOffice.TabIndex = 10;
            this.gbHomeOffice.TabStop = false;
            this.gbHomeOffice.Text = "Trabalha em Home Office?";
            this.gbHomeOffice.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnInstanciar2
            // 
            this.btnInstanciar2.Location = new System.Drawing.Point(437, 285);
            this.btnInstanciar2.Name = "btnInstanciar2";
            this.btnInstanciar2.Size = new System.Drawing.Size(297, 105);
            this.btnInstanciar2.TabIndex = 11;
            this.btnInstanciar2.Text = "Instanciar Mensalista passando parâmetros";
            this.btnInstanciar2.UseVisualStyleBackColor = true;
            this.btnInstanciar2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnInstanciar1
            // 
            this.btnInstanciar1.Location = new System.Drawing.Point(64, 285);
            this.btnInstanciar1.Name = "btnInstanciar1";
            this.btnInstanciar1.Size = new System.Drawing.Size(297, 105);
            this.btnInstanciar1.TabIndex = 12;
            this.btnInstanciar1.Text = "Instanciar Mensalista";
            this.btnInstanciar1.UseVisualStyleBackColor = true;
            // 
            // frmMensalista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInstanciar1);
            this.Controls.Add(this.btnInstanciar2);
            this.Controls.Add(this.gbHomeOffice);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmMensalista";
            this.Text = "frmMensalista";
            this.Load += new System.EventHandler(this.FrmMensalista_Load);
            this.gbHomeOffice.ResumeLayout(false);
            this.gbHomeOffice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.RadioButton rbtnSim;
        private System.Windows.Forms.RadioButton rbtnNao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox gbHomeOffice;
        private System.Windows.Forms.Button btnInstanciar2;
        private System.Windows.Forms.Button btnInstanciar1;
    }
}