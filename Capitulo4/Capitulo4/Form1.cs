using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDaConta = 2000.0;

            for (int i = 1; i <= 12; i++)
            {
                valorDaConta *= 1.01;
            }

            MessageBox.Show("Valor por ano: " + valorDaConta);

            int j = 1;
            double valorDaConta2 = 3010.0;
            while (j <= 12)
            {
                valorDaConta2 *= 1.01;
                j++;
            }

            MessageBox.Show("Valor da segunda conta: " + valorDaConta2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numeros = "";
            int soma = 0;

            for (int i = 1; i <= 1000; i++)
            {
                numeros += i;

                if (i == 500)
                {
                    numeros += "\n";
                } else
                {
                    numeros += ", ";
                }

                soma += i;
            }

            MessageBox.Show("Soma dos números de 1 a 1000 é: " + soma);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string multiplosDe3 = "";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    multiplosDe3 += i + "\n";
                }
            }
            MessageBox.Show("multiplos de 3 de 1 a 100: " + multiplosDe3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;

                MessageBox.Show("fatorial(" + n + ") = " + fatorial);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int fibonacci = 0;
            int contador = 1;
            string sequencia = "";
            int[] aux = null;

            int valor1 = 0;
            int valor2 = 1;
            while (valor2 <= 100)
            {
                fibonacci = valor2;
                int proximo = valor1 + valor2;
                valor1 = valor2;
                valor2 = proximo;
             
                sequencia += fibonacci + ", ";
            }
            MessageBox.Show("Fibonacci: " + sequencia);

            string serieFibonacci = "";
            int anterior = 0;
            int atual = 1;
            while (atual <= 100)
            {
                serieFibonacci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            MessageBox.Show("A série de Fibonacci até 100: " + serieFibonacci);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string mensagem = "";

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    mensagem += (i * j) + " ";
                }

                mensagem += "\n";
            }

            MessageBox.Show(mensagem);
        }
    }
}
