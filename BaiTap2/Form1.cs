using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiTap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection("Data Source=DESKTOP-S1U5F99;Initial Catalog=QLBHĐTDĐ;Integrated Security=True");
            try
            {
                sqlconn.Open();
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string sql = "select *from NguoiDung where Username='" + username + "' and Password='" + password + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    fdangnhapthanhcong f = new fdangnhapthanhcong();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");

                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
}
