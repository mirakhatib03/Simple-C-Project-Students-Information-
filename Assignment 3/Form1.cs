using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbxOptions.SelectedIndex > -1)
            {
                object item1 = cbxOptions.SelectedItem;
                lsbSelectedOptions.Items.Add(item1);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsbSelectedOptions.SelectedIndex > -1)
            {
                lsbSelectedOptions.Items.RemoveAt(lsbSelectedOptions.SelectedIndex);
            }
        }
        int month;
        double mbf;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double total = 0;
            string m = txbMonths.Text;
            if (int.TryParse(m, out month))
            {
                if (month < 1 || month > 24)
                {
                    MessageBox.Show("Wrong value", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    if (lsbMembership.SelectedIndex==0)
                    {
                        mbf = 40;
                    }
                    else if (lsbMembership.SelectedIndex == 1)
                    {
                        mbf = 20;
                    }
                    else if (lsbMembership.SelectedIndex == 2)
                    {
                        mbf = 25;
                    }
                    else if (lsbMembership.SelectedIndex == 3)
                    {
                        mbf += 30;
                    }
                    else if (lsbMembership.SelectedIndex == -1)
                    {
                        lsbMembership.SelectedIndex = 0;
                        mbf = 40;
                    }
                    if (lsbSelectedOptions.Items.Contains("Yoga "))
                    {
                        mbf += 10;
                    }
                    if (lsbSelectedOptions.Items.Contains("Karate "))
                    {
                        mbf += 30;
                    }
                    if (lsbSelectedOptions.Items.Contains("Personal Trainer"))
                    {
                        mbf += 50;
                    }

                    total = mbf * month;
                    lblMonthlyFee.Text = $"${mbf.ToString()}";
                    lblTotalFee.Text = $"${total.ToString()}";
                }
            }
            else
            {
                MessageBox.Show("Please enter integer number", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
           
        }

        private void txbMonths_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbMonths_KeyPress(object sender, KeyPressEventArgs e)
        {
            char i = e.KeyChar;
            if (!Char.IsDigit(i) && i != 8 )
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsbMembership.ClearSelected();
            lsbSelectedOptions.Items.Clear();
            lblMonthlyFee.Text = "                          ";
            lblTotalFee.Text = "                          ";
            txbMonths.Clear();
            cbxOptions.Text = "          ";
        }
    }
    }

