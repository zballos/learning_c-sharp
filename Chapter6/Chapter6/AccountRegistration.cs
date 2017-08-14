using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zballos;
using Zballos.Objects;

namespace Chapter6
{
    public partial class AccountRegistration : Form
    {
        private Form3 mainApplication;

        public AccountRegistration(Form3 form)
        {
            this.mainApplication = form;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string titular = this.titular.Text;
            int numAccount = Convert.ToInt32(this.numero.Text);

            Account acc = this.GetAccount(comboBox1.SelectedIndex, titular, numAccount);

            mainApplication.NewAccount(acc);
            this.Close();
        }

        private void AccountRegistration_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Corrente");
            comboBox1.Items.Add("Poupança");
            comboBox1.Items.Add("Investimento");
        }

        private Account GetAccount(int indexAccType, string titular, int numAccount)
        {
            if (indexAccType == 0)
            {
                return new CurrentAccount()
                {
                    Titular = new Client(titular, new Random().Next()),
                    Number = numAccount
                };
            }
            else if(indexAccType == 1)
            {
                return new SavingsAccount()
                {
                    Titular = new Client(titular, new Random().Next()),
                    Number = numAccount
                };
            }
            else
            {
                return new InvestmentAccount()
                {
                    Titular = new Client(titular, new Random().Next()),
                    Number = numAccount
                };
            }
        }
    }
}
