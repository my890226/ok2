using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190503
{
    public partial class Form1 : Form
    {
        public double first_number;
        public string yon;

        public Form1()
        {
            InitializeComponent();
        }



        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                first_number = double.Parse(tb.Text);
                tb.Text = "0";
                yon = "*";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            tb.Text = (first_number * double.Parse(tb.Text)).ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            tb.Text = "0";
            first_number = 0;
            yon = "";
        }

        private void number_click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            if (tb.Text.Equals("0"))
            {
                tb.Text = btn.Text;
            }
            else
            {
                tb.Text = tb.Text + btn.Text;
            }
        }
    }
}
