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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myList = new List<Account>();

            myList.Add(AccountWithBalance(3000.00));
            myList.Add(AccountWithBalance(4500.00));
            myList.Add(AccountWithBalance(1500.00));

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

        private Account AccountWithBalance(double v)
        {
            return new Account(v);
        }
    }
}
