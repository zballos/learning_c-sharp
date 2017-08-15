using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zballos.Exceptions;
using Zballos.Objects;

namespace Zballos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            Account acc1 = new CurrentAccount()
            {
                Number = 1,
                Titular = new Client("Rihanna", 17)
            };
            acc1.Deposit(2500000.0);

            Account acc2 = new CurrentAccount()
            {
                Number = 2,
                Titular = new Client("Josep of border", 31)
            };
            acc2.Deposit(500.0);

            MessageBox.Show("Balance of " + acc1.Titular.Name + ": " + acc1.Balance);
            MessageBox.Show("Balance of " + acc2.Titular.Name + ": " + acc2.Balance);

            Account acc3 = new CurrentAccount()
            {
                Number = 3,
                Agency = 14,
                Titular = new Client("New Guy", 31)
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
            Account account1 = new SavingsAccount()
            {
                Number = 1,
                Titular = new Client("Joana D'Arc", 40)
            };
            account1.Deposit(500.0);

            Account account2 = new CurrentAccount()
            {
                Number = 2,
                Titular = new Client("Harry Kane", 23)
            };
            account2.Deposit(1800.0);

            try
            {
                account1.Withdraw(-110.0);
                MessageBox.Show("Saque efetuado com sucesso!");
            }           
            catch(InsufficientBalanceException exception)
            {
                MessageBox.Show("Saldo insuficiente! Não foi possivel sacar. " + exception.Message);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show("Argumento inválido! Não foi possivel sacar. " + exception.Message);
            }

            account1.Transfer(500.0, account2);

            MessageBox.Show("Balance " + account1.Titular.Name + " : " + account1.Balance);
            MessageBox.Show("Balance " + account2.Titular.Name + " : " + account2.Balance);
        }

        private void btnAnualBalance_Click(object sender, EventArgs e)
        {
            Client joana = new Client("Joana D'Arc", 40)
            {
                Cpf = "000.000.000-00"
            };

            Account accountWhatever = new CurrentAccount()
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
            Account acc = new CurrentAccount()
            {
                Titular = new Client("Edson Zeballos", 25)
            };
            tbTitular.Text = acc.Titular.Name;
        }

        private void btnBankBalance_Click(object sender, EventArgs e)
        {
            Account acc = new SavingsAccount();
            acc.Deposit(2000);

            SavingsAccount sacc = new SavingsAccount();
            sacc.Deposit(20);

            BankBalance bank = new BankBalance();
            bank.SumAccount(acc);
            bank.SumAccount(sacc);
            
            MessageBox.Show("Saldo do banco é: " + bank.Total);
        }

        private void btnAccountUpdater_Click(object sender, EventArgs e)
        {
            Account acc = new CurrentAccount();
            acc.Deposit(2300.5);

            SavingsAccount sacc = new SavingsAccount();
            sacc.Deposit(2051);

            CurrentAccount cacc = new CurrentAccount();
            cacc.Deposit(5000);

            BankBalance bank = new BankBalance();
            bank.SumAccount(acc);
            bank.SumAccount(sacc);
            bank.SumAccount(cacc);

            MessageBox.Show("Saldo do banco é: " + bank.Total);

            AccountUpdater updater = new AccountUpdater(0.05);
            updater.Run(acc);
            updater.Run(sacc);
            updater.Run(cacc);

            MessageBox.Show("Saldo ACC é: " + acc.Balance);
            MessageBox.Show("Saldo SACC é: " + sacc.Balance);
            MessageBox.Show("Saldo CACC é: " + cacc.Balance);
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            Account[] accounts = new Account[3];
            accounts[0] = new CurrentAccount();
            accounts[1] = new SavingsAccount();
            accounts[2] = new CurrentAccount();

            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i].Deposit(150 * (i+1));
            }

            // or

            foreach (Account acc in accounts)
            {
                MessageBox.Show("Saldo da conta é: " + acc.Balance);
            }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            SavingsAccount sa = new SavingsAccount();
            InvestmentAccount ic = new InvestmentAccount();
            sa.Deposit(200.0);
            ic.Deposit(300.0);

            TaxManager t = new TaxManager();
            t.Accumulates(sa);
            t.Accumulates(ic);

            MessageBox.Show("Total de taxas: " + t.Total);
        }

        private void btnPoupanca_Click(object sender, EventArgs e)
        {
            SavingsAccount sa1 = new SavingsAccount();
            MessageBox.Show("Total de contas poupança: " + SavingsAccount.TotalAccounts);

            SavingsAccount sa2 = new SavingsAccount();
            MessageBox.Show("Total de contas poupança: " + SavingsAccount.TotalAccounts);

            SavingsAccount sa3 = new SavingsAccount();
            MessageBox.Show("Total de contas poupança: " + SavingsAccount.TotalAccounts);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var accounts = new List<Account>();

            var c1 = new CurrentAccount();
            c1.Titular = new Client("Fulano de tal", 26);

            accounts.Add(c1);

            var c2 = new SavingsAccount();
            c2.Titular = new Client("Jecca", 46);

            accounts.Add(c2);

            accounts.Remove(c1);

            accounts.Add(c1);

            MessageBox.Show("Tem contas? R: " + accounts.Contains(c1));

            foreach (Account acc in accounts)
            {
                MessageBox.Show("Titular: " + acc.Titular.Name);
            }

            MessageBox.Show("Total de contas: " + accounts.Count);
        }

        private void btnEqToString_Click(object sender, EventArgs e)
        {
            var c1 = new Client("Fulano de tal", 26);
            c1.Cpf = "010.001.001-01";
            
            var c2 = new Client("Jecca", 46);
            c2.Cpf = "001.001.001-05";

            MessageBox.Show("Clients equals? " + c1.Equals(c2));
            MessageBox.Show("Client c1: \n" + c1.ToString());
            MessageBox.Show("Client c2: \n" + c2.ToString());
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            var c1 = new Client("Fulano de tal", 26);
            c1.Cpf = "010.001.001-01";

            var c2 = new Client("Jecca", 46);
            c2.Cpf = "001.001.001-05";

            var clients = new HashSet<Client>();
            clients.Add(c1);
            clients.Add(c2);
            clients.Add(c1);

            foreach (Client c in clients)
            {
                MessageBox.Show(c.Name);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e)
        {
            SortedSet<string> words = new SortedSet<string>();
            words.Add("Life");
            words.Add("Death");
            words.Add("Ananases");
            words.Add("Bread");
            foreach (string word in words)
            {
                MessageBox.Show(word);
            }
        }
    }
}
