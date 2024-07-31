using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectNhom
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool checkAccount(string account)
        {
            return Regex.IsMatch(account, "^[a-zA-Z0-9]{6,24}$");//có in hoa và có số, giới hạn ký tự(6-24)
        }
        public bool checkEmail(string email)//check email
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9.]{3,20}@gmail.com(.vn|)");//có thể có .vn hoặc không
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKi_Load(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string username = textBox_Tentaikhoan.Text;
            string password = textBox_Matkhau.Text; 
            string cfpassword = textBox_Xacnhanmatkhau.Text;    
            string Email = textBox_Email.Text;
            if (!checkAccount(username))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, gồm các ký tự chữ, in hoa và số!");
                return;
            }
            if (!checkAccount(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, gồm các ký tự chữ, in hoa và số!");
                return;
            }
            if (password != cfpassword)
            {
                MessageBox.Show("Xác nhận mật khẩu không chính xác!");
                return;
            }
            if (!checkEmail(Email))
            {
                MessageBox.Show("Định dạng email không chính xác!");
                return;
            }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + Email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký! Vui lòng đăng ký bằng email khác!");
                return;
            }
            try
            {
                string query = "Insert into TaiKhoan values ('" + username + "','" + password + "','" + Email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công!Bạn có muốn đăng nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký! Vui lòng đăng ký tên tài khoản khác!");
            }
        }
    }
}
