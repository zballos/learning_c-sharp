using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Account acc1 = new Account();
            acc1.number = 1;
            acc1.name = "Rihanna";
            acc1.balance = 2500000.0;

            Account acc2 = new Account();
            acc2.number = 2;
            acc2.name = "Josep of border";
            acc2.balance = 500.0;

            MessageBox.Show("Balance of " + acc1.name + ": " + acc1.balance);
            MessageBox.Show("Balance of " + acc2.name + ": " + acc2.balance);

            Account acc3 = new Account();
            acc3.number = 3;
            acc3.name = "New Guy";
            acc3.balance = 5000.0;
            acc3.cpf = "001.002.003-04";
            acc3.agency = 14;

            MessageBox.Show(
                "Number: " + acc3.number +
                "\nName: " + acc3.name +
                "\nBalance: " + acc3.balance +
                "\nCPF: " + acc3.cpf +
                "\nAgency: " + acc3.agency
                );
        }
    }
}
