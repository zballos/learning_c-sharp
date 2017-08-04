﻿using System;
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
    public partial class Form3 : Form
    {
        Account[] accounts;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            accounts = new Account[3];

            accounts[0] = new Account {
                Number = 1,
                Titular = new Client("João lima", 45)
            };

            accounts[1] = new Account
            {
                Number = 2,
                Titular = new Client("Maria Carey", 40)
            };

            accounts[2] = new Account
            {
                Number = 3,
                Titular = new Client("Marcela Pam", 25)
            };

            foreach(Account acc in accounts)
            {
                comboAccounts.Items.Add(acc.Titular.Name);
            }
        }

        private void comboAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = comboAccounts.SelectedIndex;

            Account acc = accounts[selectedItem];

            txtTitular.Text = acc.Titular.Name;
            txtNumber.Text = Convert.ToString(acc.Number);
            txtBalance.Text = Convert.ToString(acc.Balance);
        }
    }
}
