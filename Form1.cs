using CalculadoraCientifica;
using System.Diagnostics;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Variables
        String operador = "";
        double num1 = 0;
        double num2 = 0;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textScreen.Text = "0";
            num2 = 0;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (textScreen.Text.Length == 1)
            {
                textScreen.Text = "0";
            }
            else
            {
                textScreen.Text = textScreen.Text.Substring(0, textScreen.Text.Length - 1);
            }
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "2";

        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "3";

        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "4";

        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "5";

        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "6";

        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "7";

        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "8";

        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "9";

        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            if (!textScreen.Text.EndsWith("0") || textScreen.Text.Length > 1)
            {
                textScreen.Text = textScreen.Text + "0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!textScreen.Text.EndsWith("."))
            {
                textScreen.Text = textScreen.Text + ".";
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(textScreen.Text);
            textScreen.Text = "0";
            textBox1.Text = num1.ToString() + operador;
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(textScreen.Text);
            textScreen.Text = "0";
            textBox1.Text = num1.ToString() + operador;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "x";
            num1 = Convert.ToDouble(textScreen.Text);
            textScreen.Text = "0";
            textBox1.Text = num1.ToString() + operador;
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(textScreen.Text);
            textScreen.Text = "0";
            textBox1.Text = num1.ToString() + operador;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            switch (operador)
            {
                case "+":
                    Suma sum = new Suma();
                    if (textBox1.Text.EndsWith("="))
                    {
                        textBox1.Text = Convert.ToDouble(textScreen.Text) + operador + num2.ToString() + " =";
                        textScreen.Text = sum.oper_suma(Convert.ToDouble(textScreen.Text), num2).ToString();
                    }
                    else
                    {
                        num2 = Convert.ToDouble(textScreen.Text);
                        textScreen.Text = sum.oper_suma(num1, num2).ToString();
                        textBox1.Text = textBox1.Text + num2.ToString() + " =";
                    }
                    break;
                case "-":
                    Resta res = new Resta();
                    if (textBox1.Text.EndsWith("="))
                    {
                        textBox1.Text = textScreen.Text + operador + num2.ToString() + " =";
                        textScreen.Text = res.oper_resta(Convert.ToDouble(textScreen.Text), num2).ToString();
                    }
                    else
                    {
                        num2 = Convert.ToDouble(textScreen.Text);
                        textScreen.Text = res.oper_resta(num1, num2).ToString();
                        textBox1.Text = textBox1.Text + num2.ToString() + " =";
                    }
                    break;
                case "x":
                    Multi mult = new Multi();
                    if (textBox1.Text.EndsWith("="))
                    {
                        textBox1.Text = Convert.ToDouble(textScreen.Text) + operador + num2.ToString() + " =";
                        textScreen.Text = mult.oper_multi(Convert.ToDouble(textScreen.Text), num2).ToString();
                    }
                    else
                    {
                        num2 = Convert.ToDouble(textScreen.Text);
                        textScreen.Text = mult.oper_multi(num1, num2).ToString();
                        textBox1.Text = textBox1.Text + num2.ToString() + " =";
                    }
                    break;
                case "/":
                    Divi div = new Divi();
                    if (textBox1.Text.EndsWith("="))
                    {
                        textBox1.Text = textScreen.Text + operador + num2.ToString() + " =";
                        textScreen.Text = div.oper_divi(Convert.ToDouble(textScreen.Text), num2).ToString();
                    }
                    else
                    {
                        num2 = Convert.ToDouble(textScreen.Text);
                        textScreen.Text = div.oper_divi(num1, num2).ToString();
                        textBox1.Text = textBox1.Text + num2.ToString() + " =";
                    }
                    break;
                case "√":
                    Raiz rai = new Raiz();
                    textBox1.Text = operador + textScreen.Text + " =";
                    textScreen.Text = rai.oper_raiz(Convert.ToDouble(textScreen.Text)).ToString();

                    break;
                case "^":
                    Potencia poten = new Potencia();
                    if (textBox1.Text.EndsWith("="))
                    {
                        textBox1.Text = Convert.ToDouble(textScreen.Text) + operador + num2.ToString() + " =";
                        textScreen.Text = poten.oper_potencia(Convert.ToDouble(textScreen.Text), num2).ToString();
                    }
                    else
                    {
                        num2 = Convert.ToDouble(textScreen.Text);
                        textScreen.Text = poten.oper_potencia(num1, num2).ToString();
                        textBox1.Text = textBox1.Text + num2.ToString() + " =";
                    }

                    break;
                case "y√x":
                    Potencia raiz = new Potencia();
                    if (textBox1.Text.EndsWith("="))
                    {
                        textBox1.Text = Convert.ToDouble(textScreen.Text) + "√" + num2.ToString() + " =";
                        textScreen.Text = raiz.oper_potencia(Convert.ToDouble(textScreen.Text), 1.0 / Convert.ToDouble(num2)).ToString();
                    }
                    else
                    {
                        num2 = Convert.ToDouble(textScreen.Text);
                        textScreen.Text = raiz.oper_potencia(num1, 1.0 / num2).ToString();
                        textBox1.Text = num2.ToString() + textBox1.Text + " =";
                    }

                    break;
                case "exp":
                    Potencia exp = new Potencia();
                    if (textBox1.Text.EndsWith("="))
                    {
                        textBox1.Text = textScreen.Text + " =";
                    }
                    else
                    {
                        num2 = Convert.ToDouble(textScreen.Text);
                        double exponencial = num1 * exp.oper_potencia(10, num2);
                        textScreen.Text = exponencial.ToString();
                        textBox1.Text = textBox1.Text + num2.ToString() + " =";
                    }
                    break;
            }
        }

        private void btnLimpiarTodo_Click(object sender, EventArgs e)
        {
            num1 = 0; num2 = 0;
            textBox1.Text = "";
            textScreen.Text = "0";
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            operador = "√";
            num1 = Convert.ToDouble(textScreen.Text);
            textBox1.Text = operador + num1.ToString();
        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textScreen.Text);
            if (num1 == 0)
            {
            }
            else
            {
                num1 = -num1;
                textScreen.Text = num1.ToString();
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (operador == "x")
            {
                num2 = Convert.ToDouble(textScreen.Text);
                num2 = num2 * 0.01;
                textBox1.Text = num1 + operador + num2.ToString() + " =";
                Multi mult = new Multi();
                textScreen.Text = mult.oper_multi(num1, num2).ToString();
                operador = "%";
            }
            else if (operador == "%")
            {
                num2 = num2 * 0.01;
                textBox1.Text = num1 + "x" + num2.ToString() + " =";
                Multi mult = new Multi();
                textScreen.Text = mult.oper_multi(num1, num2).ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textScreen.Text);
            textBox1.Text = "sqr(" + num1 + ") = ";
            num1 = Math.Pow(num1, 2);
            textScreen.Text = num1.ToString();

        }

        private void btnThrd_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textScreen.Text);
            textBox1.Text = "thrd(" + num1 + ") = ";
            num1 = Math.Pow(num1, 3);
            textScreen.Text = num1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            operador = "^";
            num1 = Convert.ToDouble(textScreen.Text);
            textScreen.Text = "0";
            textBox1.Text = num1.ToString() + operador;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textScreen.Text);
            double anguloRadianes = num1 * (Math.PI / 180);
            double seno = Math.Sin(anguloRadianes);
            if (Math.Abs(seno) < 1e-15)
            {
                seno = 0;
            }

            textScreen.Text = num1.ToString();
            textBox1.Text = "sin(" + num1 + ") = " + seno;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textScreen.Text);
            double anguloRadianes = num1 * (Math.PI / 180);
            double coseno = Math.Cos(anguloRadianes);
            if (Math.Abs(coseno) < 1e-15)
            {
                coseno = 0;
            }

            textScreen.Text = num1.ToString();
            textBox1.Text = "cos(" + num1 + ") = " + coseno;
        }

        private void btnTan_Click_1(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textScreen.Text);


            if (num1 == 90 || num1 == 270)
            {
                textBox1.Text = "tan(" + num1 + ") = ";
                textScreen.Text = "Entrada no válida";
            }
            else
            {
                double anguloRadianes = num1 * (Math.PI / 180);
                double tangente = Math.Tan(anguloRadianes);
                textScreen.Text = num1.ToString();
                textBox1.Text = "tan(" + num1 + ") = " + tangente;
            }

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textScreen.Text);
            textBox1.Text = "log(" + num1 + ") = ";
            num1 = Math.Log(num1, 10);
            textScreen.Text = num1.ToString();
        }

        private void btn10x_Click_1(object sender, EventArgs e)
        {
            Potencia poten = new Potencia();
            num1 = Convert.ToDouble(textScreen.Text);
            textBox1.Text = "10^(" + num1 + ") = ";
            num1 = poten.oper_potencia(10, num1);
            textScreen.Text = num1.ToString();
        }

        private void btnRaizTercera_Click(object sender, EventArgs e)
        {
            Potencia poten = new Potencia();
            num1 = Convert.ToDouble(textScreen.Text);
            textBox1.Text = "3√" + num1 + " = ";
            num1 = poten.oper_potencia(num1, 1.0 / 3.0);
            textScreen.Text = num1.ToString();
        }

        private void btnRaizY_Click_1(object sender, EventArgs e)
        {
            operador = "y√x";
            num1 = Convert.ToDouble(textScreen.Text);
            textScreen.Text = "0";
            textBox1.Text = "√" + num1.ToString();
        }

        private void btnEXP_Click(object sender, EventArgs e)
        {
            operador = "exp";
            num1 = Convert.ToDouble(textScreen.Text);
            textScreen.Text = "0";
            textBox1.Text = num1.ToString() + ".e + ";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (textScreen.Text == "0") textScreen.Text = "";
            textScreen.Text = textScreen.Text + "3.14159265";
        }
    }
}
