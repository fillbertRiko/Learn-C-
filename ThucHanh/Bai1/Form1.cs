using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblKetQua.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = "Hello World!";
        }

        private void btnChangeItalic_Click(object sender, EventArgs e)
        {
            lblKetQua.Font = new Font(lblKetQua.Font, lblKetQua.Font.Style ^ FontStyle.Italic);
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            lblKetQua.ForeColor = Color.Red;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblKetQua.Text = "";
        }
    }
}
