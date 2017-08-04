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
    public partial class Form2 : Form
    {
        private Account acc;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.acc = new Account() {
                Number = 100
            };
            this.acc.Deposit(250.0);
            this.acc.Titular = new Client("Van helsing", 45);

            this.ShowAccount();
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            double valueDep = Convert.ToDouble(textValue.Text);

            this.acc.Deposit(valueDep);

            this.ShowAccount();
        }

        private void ShowAccount()
        {
            txtTitular.Text = this.acc.Titular.Name;
            txtBalance.Text = Convert.ToString(this.acc.Balance);
            txtNumber.Text = Convert.ToString(this.acc.Number);
        }

        private void btnSaq_Click(object sender, EventArgs e)
        {
            double valueDep = Convert.ToDouble(textValue.Text);

            this.acc.Withdraw(valueDep);

            this.ShowAccount();
        }
    }
}
