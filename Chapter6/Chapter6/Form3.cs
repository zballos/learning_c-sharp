using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapter6;
using Zballos.Objects;

namespace Zballos
{
    public partial class Form3 : Form
    {
        Account[] accounts;
        private int accountSize;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            accounts = new Account[10];

            accounts[0] = new SavingsAccount {
                Number = 1,
                Titular = new Client("João lima", 45)
            };

            accounts[1] = new CurrentAccount
            {
                Number = 2,
                Titular = new Client("Maria Carey", 40)
            };

            accounts[2] = new SavingsAccount
            {
                Number = 3,
                Titular = new Client("Marcela Pam", 25)
            };

            foreach(Account acc in accounts)
            {
                comboAccounts.Items.Add(acc.Titular.Name);
                comboTransfer.Items.Add(acc.Titular.Name);
                this.accountSize++;
            }
        }

        private void comboAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account acc = this.GetAccountSelected();

            this.ShowAccount(acc);
        }

        private void ShowAccount(Account acc)
        {
            txtTitular.Text = acc.Titular.Name;
            txtBalance.Text = Convert.ToString(acc.Balance);
            txtNumber.Text = Convert.ToString(acc.Number);
        }

        private Account GetAccountSelected()
        {
            int selectedItem = comboAccounts.SelectedIndex;
            return this.accounts[selectedItem];
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            Account acc = this.GetAccountSelected();
            
            acc.Deposit(Convert.ToDouble(textValue.Text));

            this.ShowAccount(acc);
        }

        private void btnSaq_Click(object sender, EventArgs e)
        {
            Account acc = this.GetAccountSelected();
            acc.Withdraw(Convert.ToDouble(textValue.Text));

            this.ShowAccount(acc);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int dest = comboTransfer.SelectedIndex;

            Account acc = this.GetAccountSelected();

            double value = Convert.ToDouble(textValue.Text);
            acc.Transfer(value, this.accounts[dest]);

            this.ShowAccount(acc);
        }

        private void btnNewAccount_Click(object sender, EventArgs e)
        {
            AccountRegistration accr = new AccountRegistration(this);
            accr.ShowDialog();
        }

        public void NewAccount(Account acc)
        {
            this.accounts[this.accountSize] = acc;
            this.accountSize++;
            comboAccounts.Items.Add(acc.Titular.Name);
        }
    }
}
