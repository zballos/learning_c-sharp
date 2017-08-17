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

        private Account AccountWithBalance(string titular, int number, double v)
        {
            return new Account(titular, number, v);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myList.Add(AccountWithBalance("Marcos", 1, 3000.00));
            myList.Add(AccountWithBalance("Rashid", 2, 4500.00));
            myList.Add(AccountWithBalance("Gilbert", 3, 1500.00));
            myList.Add(AccountWithBalance("Joaquina", 6, 1600.00));
            myList.Add(AccountWithBalance("Geovanna", 4, 4200.00));
            myList.Add(AccountWithBalance("Maria", 5, 1600.00));
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

        private void button3_Click(object sender, EventArgs e)
        {
            var filtered = myList.Where(acc => acc.Balance > 4000 && acc.Number < 1000);
                
            foreach (Account a in filtered)
            {
                MessageBox.Show("Titular é: " + a.Titular + " Número: " + a.Number);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var lessBalance = myList.Min(acc => acc.Balance);

            MessageBox.Show("Menor saldo é: " + lessBalance);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int amount = myList.Count(acc => acc.Balance < 5000);

            MessageBox.Show("Quantidade de contas com saldo menor de 5000: " + amount);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var filtered =
                from acc in myList
                where acc.Number < 5
                select new { acc.Titular, acc.Number };

            foreach (var a in filtered)
            {
                MessageBox.Show("Titular é: " + a.Titular + "\nNúmero: " + a.Number);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int [] arr = { 12, 2, 31, 4, 53, 6, 70 };

            int total = arr.Where(x => x >= 15).Sum();

            MessageBox.Show("Total é: " + total);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var arr = new int[] { 12, 2, 31, 4, 53, 6, 70, 200, 41, 23, 55 };

            var ordered =
                from n in arr
                orderby n
                select n;

            string result = "";
            foreach (int n in ordered)
            {
                result += n + "\n";
            }
            MessageBox.Show(result);

            var orderedAccount =
                from acc in myList
                where acc.Balance > 1000
                orderby acc.Number descending
                select acc;

            string resultAccount = "";
            foreach (Account a in orderedAccount)
            {
                resultAccount += a.Titular + " N°: " + a.Number + "\n";
            }
            MessageBox.Show(resultAccount);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var orderedAccount = myList.OrderBy(acc => acc.Balance).ThenByDescending(acc => acc.Number);

            string resultAccount = "";
            foreach (Account a in orderedAccount)
            {
                resultAccount += a.Titular + " N°: " + a.Number + " Saldo: " + a.Balance + "\n";
            }
            MessageBox.Show(resultAccount);
        }
    }
}
