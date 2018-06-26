using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array_value
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                const int SIZE = 3;
               string[] numbersArray = new string[SIZE];
            numbersArray[0] = textBox1.Text;
            numbersArray[1] = textBox2.Text;
            numbersArray[2] = textBox3.Text;

            // label4.Text = numbersArray[0]+"  "+ numbersArray[1]+" "+ numbersArray[2];
            label4.Text = "";
            for(int i=0;i<numbersArray.Length;i++)
            {
                label4.Text+= numbersArray[i]+" ";
            }


         /*   MessageBox.Show(numbersArray[0]);
            MessageBox.Show(numbersArray[1]);
            MessageBox.Show(numbersArray[2]);*/
        }
    }
}
