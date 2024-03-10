namespace Ejercicio1
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
            this.Connectar = new System.Windows.Forms.Button();
            this.Desconnectar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.Alto = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Connectar
            // 
            this.Connectar.Location = new System.Drawing.Point(256, 23);
            this.Connectar.Name = "Connectar";
            this.Connectar.Size = new System.Drawing.Size(214, 76);
            this.Connectar.TabIndex = 0;
            this.Connectar.Text = "Connectar";
            this.Connectar.UseVisualStyleBackColor = true;
            this.Connectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Desconnectar
            // 
            this.Desconnectar.Location = new System.Drawing.Point(256, 311);
            this.Desconnectar.Name = "Desconnectar";
            this.Desconnectar.Size = new System.Drawing.Size(214, 74);
            this.Desconnectar.TabIndex = 1;
            this.Desconnectar.Text = "Desconnectar";
            this.Desconnectar.UseVisualStyleBackColor = true;
            this.Desconnectar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(298, 157);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(96, 24);
            this.Longitud.TabIndex = 5;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Longitud";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(298, 187);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(110, 24);
            this.Bonito.TabIndex = 6;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Es bonito?";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // Alto
            // 
            this.Alto.AutoSize = true;
            this.Alto.Location = new System.Drawing.Point(298, 217);
            this.Alto.Name = "Alto";
            this.Alto.Size = new System.Drawing.Size(100, 24);
            this.Alto.TabIndex = 7;
            this.Alto.TabStop = true;
            this.Alto.Text = "Soy alto?";
            this.Alto.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(549, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(211, 26);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Altura:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Alto);
            this.Controls.Add(this.Bonito);
            this.Controls.Add(this.Longitud);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Desconnectar);
            this.Controls.Add(this.Connectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connectar;
        private System.Windows.Forms.Button Desconnectar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.RadioButton Alto;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}