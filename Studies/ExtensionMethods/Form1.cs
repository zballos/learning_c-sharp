using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtensionMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string newText = textBox1.Text.Pluralize();
                MessageBox.Show(newText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account acc = Account.GetAccounts()[1];

            Serializer serialize = new Serializer();
            System.Console.Write(Serializer.AsXml(acc));
        }
    }
}
