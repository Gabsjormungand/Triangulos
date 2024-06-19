using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triângulos
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            if (a == b && b == c)
            {
                lblResutado.Text = "Triângulo Esquilatero";
                this.equilatero.Visible = true;
                this.escaleno.Visible = false;
                this.isosceles.Visible = false;
            }

            else if (a != b && b != c)
            {
                lblResutado.Text = "Triângulo Escaleno";
                this.escaleno.Visible = true;
                this.equilatero.Visible = false;
                this.isosceles.Visible = false;
            }

            else if (a == b || a == c || b == c)
            {
                lblResutado.Text = "Triângulo Isóceles";
                this.isosceles.Visible = true;
                this.equilatero.Visible = false;
                this.escaleno.Visible = false;
            }
        }
    }
}
