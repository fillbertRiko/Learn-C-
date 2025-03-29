using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bài4
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""H:\Tài liệu học tập\2025\Lập trình ứng dụng\Bài tập\Learn-C-\ThucHanh\bài4\Database1.mdf"";Integrated Security=True");
        ConnectionState sqlConState;
        private void Connect2Database()
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                {
                    sqlCon.Open();
                    sqlConState = sqlCon.State;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        string pathPhoto = "";
        OpenFileDialog opflogPhoto = new OpenFileDialog(); // Add this line to declare opflogPhoto

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            opflogPhoto.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if(opflogPhoto.ShowDialog() == DialogResult.OK)
            {
                pathPhoto = opflogPhoto.FileName;
                pictureBox1.Image = Image.FromFile(pathPhoto);
            }
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                //lay du lieu tren forrm
                string maSP = txtMaSP.Text.Trim();
                string tenSP = txtTenSP.Text.Trim();
                string donGia = txtDonGia.Text.Trim();
                string soLuongNhap = nupSoLuongNhap.Value.ToString();
                string donViTinh = cbxDonViTinh.SelectedItem.ToString();
                string ngayNhap = dtpNgayNhap.Value.ToString("dd-MM-yyyy");
                string ghiChu = txtNote.Text.Trim();
                byte[] hinhAnh = System.IO.File.ReadAllBytes(pathPhoto);

                //tao danh sach tham so cho san pham
                ArrayList arr = new ArrayList();
                arr.Add(maSP);
                arr.Add(tenSP);
                arr.Add(donGia);
                arr.Add(soLuongNhap);
                arr.Add(donViTinh);
                arr.Add(ngayNhap);
                arr.Add(ghiChu);
                arr.Add(hinhAnh);

                //thuc hien them mot san pham moi
                ThemMotSanPham(arr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }

        private void ThemMotSanPham(ArrayList arr)
        {
            Connect2Database();
            if(sqlCon != null)
            {
                try
                {
                    //doi tuong thuc thi truy van
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.CommandText = "ThemSanPham";

                    //dinh nghia cac parameter
                    SqlParameter parMaSP = new SqlParameter("@MaSP", SqlDbType.NVarChar);
                    parMaSP.Value = arr[0];
                    sqlCmd.Parameters.Add(parMaSP);

                    SqlParameter parTenSP = new SqlParameter("@TenSP", SqlDbType.NVarChar);
                    parTenSP.Value = arr[1];
                    sqlCmd.Parameters.Add(parTenSP);

                    SqlParameter parDonGia = new SqlParameter("@Gia", SqlDbType.NVarChar);
                    parDonGia.Value = arr[2];
                    sqlCmd.Parameters.Add(parDonGia);

                    SqlParameter parSoLuongNhap = new SqlParameter("@SoLuong", SqlDbType.NVarChar);
                    parSoLuongNhap.Value = arr[3];
                    sqlCmd.Parameters.Add(parSoLuongNhap);

                    SqlParameter parDonViTinh = new SqlParameter("@DonViTinh", SqlDbType.NVarChar);
                    parDonViTinh.Value = arr[4];
                    sqlCmd.Parameters.Add(parDonViTinh);

                    SqlParameter parNgayNhap = new SqlParameter("@NgayNhap", SqlDbType.NVarChar);
                    parNgayNhap.Value = arr[5];
                    sqlCmd.Parameters.Add(parNgayNhap);

                    SqlParameter parGhiChu = new SqlParameter("@GhiChu", SqlDbType.NVarChar);
                    parGhiChu.Value = arr[6];
                    sqlCmd.Parameters.Add(parGhiChu);

                    SqlParameter parHinhAnh = new SqlParameter("@HinhAnh", SqlDbType.Image);
                    parHinhAnh.Value = arr[7];
                    sqlCmd.Parameters.Add(parHinhAnh);

                    //gan vao ket noi
                    sqlCmd.Connection = sqlCon;

                    //thuc thi truy van
                    int ret = sqlCmd.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Messeage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtDonGia.Text = "";
            txtMaSP.Text = "";
            txtNote.Text = "";
            txtTenSP.Text = "";
            nupSoLuongNhap.Value = 0;
            cbxDonViTinh.SelectedIndex = 0;
            pictureBox1.Image = null;
        }
    }
}
