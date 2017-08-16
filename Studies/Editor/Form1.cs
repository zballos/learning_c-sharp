using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("entryFile.txt"))
            {
                using (Stream entry = File.Open("entryFile.txt", FileMode.Open))
                using (StreamReader reader = new StreamReader(entry))
                {
                    string line = reader.ReadToEnd();
                    textBox1.Text = line;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(Stream outHere = File.Open("entryFile.txt", FileMode.Create))
            using(StreamWriter writer = new StreamWriter(outHere))
            {
                writer.WriteLine(textBox1.Text);
            }
            
            this.Close();
        }
    }
}
