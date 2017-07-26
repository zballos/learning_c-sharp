using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Olá Mundinho!");
		}

		private void btnSair_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Saindo...");
		}
	}
}
