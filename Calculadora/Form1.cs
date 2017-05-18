using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double result = 0, valor1 = 0, valor2 = 0;
        String texto = "";
        int op = 0;
        bool novo_calculo = true;

        private void digito(String s)
        {
            if (novo_calculo)
            {
                limparCampo();
                resultado.AppendText(s);
                texto += s;
                novo_calculo = false;
            }
            else
            {
                resultado.AppendText(s);
                texto += s;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            digito("1");        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            digito("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            digito("3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            digito("4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            digito("5");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            digito("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            digito("7");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            digito("8");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            digito("9");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            limparCampo();
        }

        private void limparCampo()
        {
            resultado.Clear();
            texto = "";
            result = 0;
            valor1 = 0;
            valor2 = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            digito("0");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operacao(" + ", 1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            operacao(" - ", 2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacao(" * ", 3);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operacao(" / ", 4);
        }

        private void operacao(String s, int op)
        {
            if (texto != "")
            {
                if (this.op == 0)
                {
                    valor1 = Convert.ToDouble(texto);
                    texto = "";
                    resultado.AppendText(s);
                    this.op = op;
                }
                else if (op != 0)
                {
                    valor2 = Convert.ToDouble(texto);
                    calcular();

                    resultado.AppendText(s);
                    this.op = op;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            calcular();
            valor1 = 0;
            valor2 = 0;
            op = 0;
            novo_calculo = true;
        }

        private void calcular()
        {
            switch (op)
            {
                case 1:
                    valor2 = Convert.ToDouble(texto);
                    result = valor1 + valor2;
                    valor2 = 0;
                    break;
                case 2:
                    valor2 = Convert.ToDouble(texto);
                    result = valor1 - valor2;
                    valor2 = 0;
                    break;
                case 3:
                    valor2 = Convert.ToDouble(texto);
                    result = valor1 * valor2;
                    valor2 = 0;
                    break;
                case 4:
                    valor2 = Convert.ToDouble(texto);
                    result = valor1 / valor2;
                    valor2 = 0;
                    break;
                default:
                    break;
            }
            resultado.Text = Convert.ToString(result);

            valor1 = result;
            texto = "";
        }
    }
}
