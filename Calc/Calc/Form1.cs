using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtAns.Text = Convert.ToString(Convert.ToInt16(txtNum1.Text) / Convert.ToInt16(txtNum2.Text));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAns.Text = Convert.ToString(Convert.ToInt16(txtNum1.Text)+Convert.ToInt16(txtNum2.Text));
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            txtAns.Text = Convert.ToString(Convert.ToInt16(txtNum1.Text) - Convert.ToInt16(txtNum2.Text));
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            txtAns.Text = Convert.ToString(Convert.ToInt16(txtNum1.Text) * Convert.ToInt16(txtNum2.Text));
        }
    }
}
