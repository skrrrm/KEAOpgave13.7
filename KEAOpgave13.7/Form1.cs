using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KEAOpgave13._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Table
        {
            // Fields
            private int factor = 0;
            private int[] tables = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // Properties
            public int Factor
            {
                get
                {
                    return factor;
                }
                set
                {
                    if (value > 0)
                        factor = value;
                    else
                        factor = 10;
                }
            }

            public Table() { }

            public int Multiplication(int n)
            {
                int result = 0;

                return result = Factor * n;

            }
        }
        private void buttonTable_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Table myTable = new Table();
            try
            {
                myTable.Factor = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                label2.Text = "Numbers only!    ";
            }
            int n = 1;
            while (n <= 10)
            {
                listBox1.Items.Add(myTable.Multiplication(n));
                n++;
            }
            
        }
    }
}
