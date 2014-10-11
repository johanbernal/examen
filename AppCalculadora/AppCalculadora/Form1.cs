using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class Calculadora : Form
    {
        float primero;
        float segundo;
        float resultado;
        string operacion;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length != 12)
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }
            else
            {
                txtPantalla.MaxLength = 12;
            }
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length != 12)
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
            else
            {
                txtPantalla.MaxLength = 12;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length != 12)
            {
                txtPantalla.Text = txtPantalla.Text + "3";
            }
            else
            {
                txtPantalla.MaxLength = 12;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length != 12)
            {
                txtPantalla.Text = txtPantalla.Text + "4";
            }
            else
            {
                txtPantalla.MaxLength = 12;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length != 12)
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
            else
            {
                txtPantalla.MaxLength = 12;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length != 12)
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
            else
            {
                txtPantalla.MaxLength = 12;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length != 12)
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
            else
            {
                txtPantalla.MaxLength = 12;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length != 12)
            {
                txtPantalla.Text = txtPantalla.Text + "8";
            }
            else
            {
                txtPantalla.MaxLength = 12;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length != 12)
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }
            else
            {
                txtPantalla.MaxLength = 12;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = txtPantalla.Text + ",";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = float.Parse(txtPantalla.Text);
            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    txtPantalla.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = primero - segundo;
                    txtPantalla.Text = resultado.ToString();
                    break;
                case "*":
                    resultado = primero * segundo;
                    txtPantalla.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = primero / segundo;
                    txtPantalla.Text = resultado.ToString();
                    break;               
                    
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = float.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = float.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnPor_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = float.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = float.Parse(txtPantalla.Text);
            txtPantalla.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
