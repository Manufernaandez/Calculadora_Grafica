using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class btnRaiz : Form
    {
        double primero;
        double segundo;
        string operador;
        double resultado;
        public btnRaiz()
        {
            InitializeComponent();
        }

        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultimplicacion obj3 = new Clases.ClsMultimplicacion();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();

        private void button3_Click_1(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(pantalla.Text);
            pantalla_previa.Text = pantalla_previa.Text + pantalla.Text + "+";
            pantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(pantalla.Text);
            pantalla_previa.Text = pantalla_previa.Text + pantalla.Text + "-";
            pantalla.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(pantalla.Text);
            pantalla_previa.Text = pantalla_previa.Text + pantalla.Text + "*";
            pantalla.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(pantalla.Text);
            pantalla_previa.Text = pantalla_previa.Text + pantalla.Text + "÷";
            pantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(pantalla.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;
            double Por;

            switch (operador)
            {
                case "+":
                    Sum = obj.Sumar((primero), (segundo));
                    pantalla_previa.Text = pantalla_previa.Text + pantalla.Text;
                    pantalla.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    pantalla_previa.Text = pantalla_previa.Text + pantalla.Text;
                    pantalla.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicar((primero), (segundo));
                    pantalla_previa.Text = pantalla_previa.Text + pantalla.Text;
                    pantalla.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Dividir((primero), (segundo));
                    pantalla_previa.Text = pantalla_previa.Text + pantalla.Text;
                    pantalla.Text = Div.ToString();
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
            pantalla_previa.Clear();

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (pantalla.Text.Length == 1)
                pantalla.Text = "";
            else
                pantalla.Text = pantalla.Text.Substring(0, pantalla.Text.Length - 1);

        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla_previa.Text = "√" + pantalla_previa.Text + pantalla.Text;
            pantalla.Text = Math.Sqrt(primero).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ",";
        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla_previa.Text = "sin (" + pantalla_previa.Text + pantalla.Text + ")";
            pantalla.Text = Math.Sin(primero).ToString();
        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla_previa.Text = "cos (" + pantalla_previa.Text + pantalla.Text + ")";
            pantalla.Text = Math.Cos(primero).ToString();
        }

        private void btnTangente_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla_previa.Text = "tan (" + pantalla_previa.Text + pantalla.Text + ")";
            pantalla.Text = Math.Tan(primero).ToString();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla_previa.Text = pantalla_previa.Text + pantalla.Text + "^2";
            pantalla.Text = Math.Pow(primero, 2).ToString();
        }

        private void btnCubo_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla_previa.Text = pantalla_previa.Text + pantalla.Text + "^3";
            pantalla.Text = Math.Pow(primero, 3).ToString();
        }

        private void pantalla_previa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogaritmo_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla_previa.Text = "log (" + pantalla_previa.Text + pantalla.Text + ")";
            pantalla.Text = Math.Log(primero).ToString();
        }

        private void btnExponencial_Click(object sender, EventArgs e)
        {
            primero = double.Parse(pantalla.Text);
            resultado = primero;
            pantalla_previa.Text = "exp (" + pantalla_previa.Text + pantalla.Text + ")";
            pantalla.Text = Math.Exp(primero).ToString();
        }
    }
}
