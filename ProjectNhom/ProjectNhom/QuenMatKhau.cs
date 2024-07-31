using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNhom
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label1.Text = "";
        }
        Modify modify = new Modify();
        private void button_Laymatkhau_Click(object sender, EventArgs e)
        {
            string email = textBox_emaildangky.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email!");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    label1.ForeColor = Color.Blue;
                    label1.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].MatKhau1;
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Email này chưa được đăng ký!";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
