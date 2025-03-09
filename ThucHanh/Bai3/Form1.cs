using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void txtNumB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (rdoBSCLN.Checked == false && rdoUSCLN.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn một trong hai tuỳ chọn");
                rdoBSCLN.Checked = true;
                return;
            }
            else if (rdoBSCLN.Checked == true)
            {
                //Lấy dữ liệu từ textbox
                int numA = Convert.ToInt32(txtNumA.Text);
                int numB = Convert.ToInt32(txtNumB.Text);
                //Tìm ước chung lớn nhất
                int USCLN = GCD(numA, numB);
                //Hiển thị kết quả
                txtShow.Text = USCLN.ToString();

            }
            else
            {
                //Lấy dữ liệu từ textbox
                int numA = Convert.ToInt32(txtNumA.Text);
                int numB = Convert.ToInt32(txtNumB.Text);
                //Tìm bội số chung nhỏ nhất
                int BSCNN = numA * numB / GCD(numA, numB);
                //Hiển thị kết quả
                txtShow.Text = BSCNN.ToString();
            }
        }

        private int GCD(int numA, int numB)
        {
            while (numB != 0)
            {
                int temp = numB;
                numB = numA % numB;
                numA = temp;
            }

            return numA;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNumA.Text = "";
            txtNumB.Text = "";
            txtShow.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.Exit();
        }
    }

}