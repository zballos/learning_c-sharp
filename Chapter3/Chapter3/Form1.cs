using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnVoto_Click(object sender, EventArgs e)
		{
			int idade = 15;
			bool brasileira = true;

			if (brasileira && idade >= 16)
			{
				MessageBox.Show("Pode votar!");
			}
			else
			{
				MessageBox.Show("Não pode votar!");
			}
		}

		private void btnNfe_Click(object sender, EventArgs e)
		{
			double valorNotaFiscal = 5000.0;
			double imposto;

			if (valorNotaFiscal < 1000)
			{
				imposto = valorNotaFiscal * 0.02;
			}
			else if (valorNotaFiscal >= 1000 && valorNotaFiscal < 3000)
			{
				imposto = valorNotaFiscal * 0.025;
			}
			else if (valorNotaFiscal >= 3000 && valorNotaFiscal < 7000)
			{
				imposto = valorNotaFiscal * 0.028;
			}
			else
			{
				imposto = valorNotaFiscal * 0.03;
			}

			MessageBox.Show("Imposto: " + imposto);
			MessageBox.Show("Valor da NFE com imposto: " + (valorNotaFiscal + imposto));
		}
	}
}
