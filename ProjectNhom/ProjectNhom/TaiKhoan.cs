using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNhom
{
    internal class TaiKhoan
    {
        private string TenTaiKhoan;
        private string MatKhau;

        public TaiKhoan()
        {

        }
        public TaiKhoan(string TenTaiKhoan, string MatKhau)
        {
            this.TenTaiKhoan = TenTaiKhoan;
            this.MatKhau = MatKhau;
        }

        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    }
}
