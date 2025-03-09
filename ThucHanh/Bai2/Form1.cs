using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if(e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //buoc 1: lay gia tri tu 2 o nhap
            double numA = Convert.ToDouble(txtNumA.Text.Trim());
            double numB = Convert.ToDouble(txtNumB.Text.Trim());

            //buoc 2: tinh tong
            double sum = numA + numB;

            //buoc 3: hien thi ket qua
            txtShow.Text = sum.ToString();
        }

        private void btnDevied_Click(object sender, EventArgs e)
        {
            //buoc 1: lay gia tri tu 2 o nhap
            double numA = Convert.ToDouble(txtNumA.Text);
            double numB = Convert.ToDouble(txtNumB.Text);

            //buoc 2: tinh thuong
            double div = numA - numB;

            //buoc 3: hien thi ket qua
            txtShow.Text = div.ToString();
        }

        private void btnMultil_Click(object sender, EventArgs e)
        {
            //buoc 1: lay gia tri tu 2 o nhap
            double numA = Convert.ToDouble(txtNumA.Text.Trim());
            double numB = Convert.ToDouble(txtNumB.Text.Trim());

            //buoc 2: tinh tich
            double tich = numA * numB;

            //buoc 3: hien thi ket qua
            txtShow.Text = tich.ToString();
        }

        private void btnConque_Click(object sender, EventArgs e)
        {
            //buoc 1: lay gia tri tu 2 o nhap
            double numA = Convert.ToDouble(txtNumA.Text.Trim());
            double numB = Convert.ToDouble(txtNumB.Text.Trim());

            if (numB == 0)
            {
                MessageBox.Show("So bi chia phai khac 0");
                txtNumA.Focus();
                txtNumB.Focus();
                return;
            }

            //buoc 2: tinhs thuong
            double divc = numA / numB;

            //buoc 3: hien thi ket qua
            txtShow.Text = divc.ToString();

        }

        private void txtNumB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.Exit();
        }
    }
}
