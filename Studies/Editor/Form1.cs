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
                Stream entry = File.Open("entryFile.txt", FileMode.Open);
                StreamReader reader = new StreamReader(entry);

                string line = reader.ReadLine();
                while(line != null)
                {
                    textBox1.Text += line;
                    line = reader.ReadLine();
                }
                reader.Close();
                entry.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream outHere = File.Open("entryFile.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(outHere);

            writer.WriteLine(textBox1.Text);
            
            writer.Close();
            outHere.Close();
            this.Close();
        }
    }
}
