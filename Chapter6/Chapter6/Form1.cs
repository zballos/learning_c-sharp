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
            Account acc1 = new Account()
            {
                Number = 1,
                Titular = new Client("Rihanna")
            };
            acc1.Deposit(2500000.0);

            Account acc2 = new Account()
            {
                Number = 2,
                Titular = new Client("Josep of border")
            };
            acc2.Deposit(500.0);

            MessageBox.Show("Balance of " + acc1.Titular.Name + ": " + acc1.Balance);
            MessageBox.Show("Balance of " + acc2.Titular.Name + ": " + acc2.Balance);

            Account acc3 = new Account()
            {
                Number = 3,
                Agency = 14,
                Titular = new Client("New Guy")
            };
            acc3.Deposit(5000.0);
            acc3.Titular.Cpf = "001.002.003-04";

            MessageBox.Show(
                "Number: " + acc3.Number +
                "\nName: " + acc3.Titular.Name +
                "\nBalance: " + acc3.Balance +
                "\nCPF: " + acc3.Titular.Cpf +
                "\nAgency: " + acc3.Agency
                );
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Account account1 = new Account()
            {
                Number = 1,
                Titular = new Client("Joana D'Arc")
            };
            account1.Deposit(2500.0);

            Account account2 = new Account()
            {
                Number = 2,
                Titular = new Client("Harry Kane")
            };
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

            MessageBox.Show("Balance " + account1.Titular.Name + " : " + account1.Balance);
            MessageBox.Show("Balance " + account2.Titular.Name + " : " + account2.Balance);
        }

        private void btnAnualBalance_Click(object sender, EventArgs e)
        {
            Client joana = new Client("Joana D'Arc")
            {
                Cpf = "000.000.000-00"
            };

            Account accountWhatever = new Account()
            {
                Number = 1,
                Titular = joana
            };
            accountWhatever.Deposit(2500.0);

            double balanceAnual = accountWhatever.AnnualIncome();

            MessageBox.Show("Annual Balance of " + accountWhatever.Titular.Name + " is " + balanceAnual);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Account acc = new Account()
            {
                Titular = new Client("Edson Zeballos")
            };
            tbTitular.Text = acc.Titular.Name;
        }
    }
}
