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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Account acc = new Account() {
                Number = 100
            };
            acc.Deposit(250.0);
            acc.Titular = new Client("Van helsing");

            txtTitular.Text = acc.Titular.Name;
            txtBalance.Text = Convert.ToString(acc.Balance);
            txtNumber.Text = Convert.ToString(acc.Number);
        }
    }
}
