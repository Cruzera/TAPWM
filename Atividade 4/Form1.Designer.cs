﻿namespace Pclasses
{
    partial class Form1
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
            this.mensalista = new System.Windows.Forms.Button();
            this.horista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mensalista
            // 
            this.mensalista.Location = new System.Drawing.Point(54, 78);
            this.mensalista.Name = "mensalista";
            this.mensalista.Size = new System.Drawing.Size(215, 128);
            this.mensalista.TabIndex = 0;
            this.mensalista.Text = "Mensalista";
            this.mensalista.UseVisualStyleBackColor = true;
            this.mensalista.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // horista
            // 
            this.horista.Location = new System.Drawing.Point(328, 78);
            this.horista.Name = "horista";
            this.horista.Size = new System.Drawing.Size(215, 128);
            this.horista.TabIndex = 1;
            this.horista.Text = "Horista";
            this.horista.UseVisualStyleBackColor = true;
            this.horista.Click += new System.EventHandler(this.Horista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 277);
            this.Controls.Add(this.horista);
            this.Controls.Add(this.mensalista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mensalista;
        private System.Windows.Forms.Button horista;
    }
}

