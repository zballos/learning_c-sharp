using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQLambda
{
    public partial class Form1 : Form
    {
        List<Account> myList = new List<Account>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // example LINQ
            var filtered =
                from acc in myList
                where acc.Balance > 2000.00
                select acc;

            foreach (Account a in filtered)
            {
                MessageBox.Show("O saldo é: " + a.Balance);
            }

            double total = myList.Sum(acc => acc.Balance);
            MessageBox.Show("Valor total é: " + total);
        }

        private Account AccountWithBalance(string titular, double v)
        {
            return new Account(titular, v);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myList.Add(AccountWithBalance("Marcos", 3000.00));
            myList.Add(AccountWithBalance("Rachid", 4500.00));
            myList.Add(AccountWithBalance("Gilbert", 1500.00));
            myList.Add(AccountWithBalance("Geovanna", 4200.00));
            myList.Add(AccountWithBalance("Maria", 1600.00));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var filtered =
                from acc in myList
                where acc.Titular.StartsWith("M")
                select acc;

            foreach (Account a in filtered)
            {
                MessageBox.Show("Titular é: " + a.Titular);
            }
        }
    }
}
