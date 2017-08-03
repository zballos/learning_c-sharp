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
            acc1.Number = 1;
            acc1.Titular.name = "Rihanna";
            acc1.Deposit(2500000.0);

            Account acc2 = new Account();
            acc2.Number = 2;
            acc2.Titular.name = "Josep of border";
            acc2.Deposit(500.0);

            MessageBox.Show("Balance of " + acc1.Titular.name + ": " + acc1.Balance);
            MessageBox.Show("Balance of " + acc2.Titular.name + ": " + acc2.Balance);

            Account acc3 = new Account();
            acc3.Number = 3;
            acc3.Titular.name = "New Guy";
            acc3.Deposit(5000.0);
            acc3.Titular.cpf = "001.002.003-04";
            acc3.Agency = 14;

            MessageBox.Show(
                "Number: " + acc3.Number +
                "\nName: " + acc3.Titular.name +
                "\nBalance: " + acc3.Balance +
                "\nCPF: " + acc3.Titular.cpf +
                "\nAgency: " + acc3.Agency
                );
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Account account1 = new Account();
            account1.Number = 1;
            account1.Titular.name = "Joana D'Arc";
            account1.Deposit(2500.0);

            Account account2 = new Account();
            account2.Number = 2;
            account2.Titular.name = "Harry Cane";
            account2.Deposit(1800.0);

            if (account1.Withdraw(100.0))
            {
                MessageBox.Show("Saque efetuado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel sacar!");
            }

            account1.Transfer(500.0, account2);

            MessageBox.Show("Balance " + account1.Titular.name + " : " + account1.Balance);
            MessageBox.Show("Balance " + account2.Titular.name + " : " + account2.Balance);
        }

        private void btnAnualBalance_Click(object sender, EventArgs e)
        {
            Account accountWhatever = new Account();
            accountWhatever.Number = 1;
            accountWhatever.Deposit(2500.0);

            Client joana = new Client();
            joana.name = "Joana D'Arc";
            joana.cpf = "000.000.000-00";

            accountWhatever.Titular = joana;

            double balanceAnual = accountWhatever.AnnualIncome();

            MessageBox.Show("Annual Balance of " + accountWhatever.Titular.name + " is " + balanceAnual);
        }
    }
}
