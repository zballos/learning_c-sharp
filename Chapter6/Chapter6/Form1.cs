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
            acc1.client.name = "Rihanna";
            acc1.balance = 2500000.0;

            Account acc2 = new Account();
            acc2.number = 2;
            acc2.client.name = "Josep of border";
            acc2.balance = 500.0;

            MessageBox.Show("Balance of " + acc1.client.name + ": " + acc1.balance);
            MessageBox.Show("Balance of " + acc2.client.name + ": " + acc2.balance);

            Account acc3 = new Account();
            acc3.number = 3;
            acc3.client.name = "New Guy";
            acc3.balance = 5000.0;
            acc3.client.cpf = "001.002.003-04";
            acc3.agency = 14;

            MessageBox.Show(
                "Number: " + acc3.number +
                "\nName: " + acc3.client.name +
                "\nBalance: " + acc3.balance +
                "\nCPF: " + acc3.client.cpf +
                "\nAgency: " + acc3.agency
                );
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Account joana = new Account();
            joana.number = 1;
            joana.client.name = "Joana D'Arc";
            joana.balance = 2500.0;

            Account harry = new Account();
            harry.number = 2;
            harry.client.name = "Harry Cane";
            harry.balance = 1800.0;

            joana.toTransfer(500.0, harry);

            MessageBox.Show("Balance " + joana.client.name + " : " + joana.balance);
            MessageBox.Show("Balance " + harry.client.name + " : " + harry.balance);
        }

        private void btnAnualBalance_Click(object sender, EventArgs e)
        {
            Account accountWhatever = new Account();
            accountWhatever.number = 1;
            accountWhatever.balance = 2500.0;

            Client joana = new Client();
            joana.name = "Joana D'Arc";
            joana.cpf = "000.000.000-00";

            accountWhatever.client = joana;

            double balanceAnual = accountWhatever.getAnnualIncome();

            MessageBox.Show("Annual Balance of " + accountWhatever.client.name + " is " + balanceAnual);
        }
    }
}
