using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int numeroDaConta = 1;

			double saldo = 200.0;
			double valorDoSaque = 15.0;
			double pagamento = 31.59;

			double saldoAtualizado = saldo - pagamento;

			MessageBox.Show("Saldo da minha conta é: R$ " + saldoAtualizado);

			bool podeSacar = (valorDoSaque <= saldo) && (valorDoSaque > 0);

			if (podeSacar)
			{
				saldoAtualizado -= valorDoSaque;
				MessageBox.Show("Saque realizado!\nSaldo atual: R$ " + saldoAtualizado);
			}
			else
			{
				MessageBox.Show("Saldo insuficiente!");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int idadeJoao = 10;
			int idadeMaria = 25;
			int idadeJose = 45;

			double mediaIdade = (idadeJoao + idadeJose + idadeMaria) / 3;

			MessageBox.Show(
				"- João possui " + idadeJoao + " anos \n" +
				"- Maria possui " + idadeMaria + " anos \n" +
				"- José possui " + idadeJose + " anos \n" +
				"Média de idade de João, Maria e José é de " + mediaIdade + " anos"
				);
		}

		private void btnCast_Click(object sender, EventArgs e)
		{
			double pi = 3.14;
			int piQuebrado = (int)pi;
			MessageBox.Show("piQuebrado = " + piQuebrado);
		}

		private void btnFormula_Click(object sender, EventArgs e)
		{
			double delta, a1, a2;
			int a = 2, b = 5, c = 2;
	
			delta = b * b - 4 * a * c;
			a1 = (-b + Math.Sqrt(delta)) / (2 * a);
			a2 = (-b - Math.Sqrt(delta)) / (2 * a);

			MessageBox.Show(
				"Valor a1 = " + a1 + "\n" +
				"Valor a2 = " + a2
			);
		}
	}
}
