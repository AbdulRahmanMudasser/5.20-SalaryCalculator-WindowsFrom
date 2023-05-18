using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary_Calculator_Windows_From
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string e1Name = e1NameTextBox.Text;
            string e2Name = e2NameTextBox.Text;
            string e3Name = e3NameTextBox.Text;

            double e1Hours = Convert.ToDouble(e1HoursTextBox.Text);
            double e2Hours = Convert.ToDouble(e2HoursTextBox.Text);
            double e3Hours = Convert.ToDouble(e3HoursTextBox.Text);

            double e1Rate = Convert.ToDouble(e1RateTextBox.Text);
            double e2Rate = Convert.ToDouble(e2RateTextBox.Text);
            double e3Rate = Convert.ToDouble(e3RateTextBox.Text);

            double e1Pay, e2Pay, e3Pay;

            // for e1
            if (e1Hours >= 40)
            {
                e1Pay = e1Rate * 40;
            }

            else
            {
                e1Pay = (e1Rate * 40) + ((e1Hours - 40) * e1Rate * 1.5); 
            }

            // for e2
            if (e2Hours >= 40)
            {
                e2Pay = e2Rate * 40;
            }

            else
            {
                e2Pay = (e2Rate * 40) + ((e2Hours - 40) * e2Rate * 1.5);
            }

            // for e3
            if (e3Hours >= 40)
            {
                e3Pay = e3Rate * 40;
            }

            else
            {
                e3Pay = (e3Rate * 40) + ((e3Hours - 40) * e3Rate) * 1.5;
            }

            e1PayTextBox.Text = e1Pay.ToString();
            e2PayTextBox.Text = e2Pay.ToString();
            e3PayTextBox.Text = e3Pay.ToString();
        }
    }
}
