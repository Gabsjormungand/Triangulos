namespace Triângulos
{
    partial class form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResutado = new System.Windows.Forms.Label();
            this.equilatero = new System.Windows.Forms.PictureBox();
            this.isosceles = new System.Windows.Forms.PictureBox();
            this.escaleno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.equilatero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isosceles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escaleno)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descubra qual Triângulo é !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1° Lado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2° Lado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "3° Lado";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 181);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Descrubra!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResutado
            // 
            this.lblResutado.AutoSize = true;
            this.lblResutado.Location = new System.Drawing.Point(230, 259);
            this.lblResutado.Name = "lblResutado";
            this.lblResutado.Size = new System.Drawing.Size(0, 13);
            this.lblResutado.TabIndex = 8;
            // 
            // equilatero
            // 
            this.equilatero.Image = global::Triângulos.Properties.Resources.MicrosoftTeams_image__2_;
            this.equilatero.Location = new System.Drawing.Point(224, 88);
            this.equilatero.Name = "equilatero";
            this.equilatero.Size = new System.Drawing.Size(268, 146);
            this.equilatero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equilatero.TabIndex = 11;
            this.equilatero.TabStop = false;
            this.equilatero.Visible = false;
            this.equilatero.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // isosceles
            // 
            this.isosceles.Image = global::Triângulos.Properties.Resources.MicrosoftTeams_image__1_;
            this.isosceles.Location = new System.Drawing.Point(224, 88);
            this.isosceles.Name = "isosceles";
            this.isosceles.Size = new System.Drawing.Size(268, 146);
            this.isosceles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.isosceles.TabIndex = 10;
            this.isosceles.TabStop = false;
            this.isosceles.Visible = false;
            // 
            // escaleno
            // 
            this.escaleno.Image = global::Triângulos.Properties.Resources.MicrosoftTeams_image;
            this.escaleno.Location = new System.Drawing.Point(224, 88);
            this.escaleno.Name = "escaleno";
            this.escaleno.Size = new System.Drawing.Size(268, 146);
            this.escaleno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.escaleno.TabIndex = 9;
            this.escaleno.TabStop = false;
            this.escaleno.Visible = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(501, 339);
            this.Controls.Add(this.equilatero);
            this.Controls.Add(this.isosceles);
            this.Controls.Add(this.escaleno);
            this.Controls.Add(this.lblResutado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.equilatero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isosceles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escaleno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResutado;
        private System.Windows.Forms.PictureBox escaleno;
        private System.Windows.Forms.PictureBox isosceles;
        private System.Windows.Forms.PictureBox equilatero;
    }
}

