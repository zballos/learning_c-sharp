using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int numero = 0; numero <= 30; numero ++)
            {
                if (numero % 3 == 0)
                {
                    MessageBox.Show(numero + " é divisível por 3!");
                }
                else if (numero % 4 == 0)
                {
                    MessageBox.Show(numero + " é divisível por 4!");
                }
                else
                {
                    MessageBox.Show(numero + " Não é divisível por 3 nem por 4!");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 != 0)
                {
                    soma += numero;
                }
            }

            MessageBox.Show("Total é " + soma);
        }
    }
}
