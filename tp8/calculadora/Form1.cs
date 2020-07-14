using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        entidad NuevaCalculadora = new entidad();
        LinkedList<String> Visor = new LinkedList<string>();

        float num1;
        float num2;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = float.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = float.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = float.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = float.Parse(pantalla.Text);
            pantalla.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(pantalla.Text);
            switch (operador)
            {
                case "+":
                    pantalla.Clear();
                    NuevaCalculadora.Numero1 = num1;
                    NuevaCalculadora.Numero2 = num2;
                    pantalla.Text = Convert.ToString(NuevaCalculadora.Sumar());
                    lbxHistorial.Items.Add(Convert.ToString(DateTime.Now) + " ----> " + num1 + " + " + num2 + " = " + (num1 + num2));
                    break;
                case "-":
                    pantalla.Clear();
                    NuevaCalculadora.Numero1 = num1;
                    NuevaCalculadora.Numero2 = num2;
                    pantalla.Text = Convert.ToString(NuevaCalculadora.Restar());
                    lbxHistorial.Items.Add(Convert.ToString(DateTime.Now) + " ----> " + num1 + " + " + num2 + " = " + (num1 - num2));
                    break;
                case "*":
                    pantalla.Clear();
                    NuevaCalculadora.Numero1 = num1;
                    NuevaCalculadora.Numero2 = num2;
                    pantalla.Text = Convert.ToString(NuevaCalculadora.Multiplicar());
                    lbxHistorial.Items.Add(Convert.ToString(DateTime.Now) + " ----> " + num1 + " + " + num2 + " = " + (num1 * num2));
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        pantalla.Text = "MATH ERROR!!"; break;
                    }
                    pantalla.Clear();
                    NuevaCalculadora.Numero1 = num1;
                    NuevaCalculadora.Numero2 = num2;
                    pantalla.Text = Convert.ToString(NuevaCalculadora.Dividir());
                    lbxHistorial.Items.Add(Convert.ToString(DateTime.Now) + " ----> " + num1 + " + " + num2 + " = " + (num1 * num2));
                    break;
            }
        }

        private void lbxHistorial_MouseDoubleClick(object sender, EventArgs e)
        {
            //lbxHistorial.Items.RemoveAt(lbxHistorial);
        }
    }
}
