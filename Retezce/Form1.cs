using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retezce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string text = textBox1.Text;
            string[] slovo = text.Split(' ');
            int pocetSlov = 0;
            if (text.Contains(' '))
            {
                pocetSlov++;
            }
            string cislo = "0123456789";
            if (text.Contains(cislo))
            {
                for (int i = 0; i < pocetSlov; i++)
                {
                    listBox1.Items.Add(slovo);
                }
            }
            foreach (char k in text)
            {
                if (text.Contains (" "))
                {
                text = text.Replace(" ", "");
                textBox1.Text = text;
                }
            }
        }
    }
}
