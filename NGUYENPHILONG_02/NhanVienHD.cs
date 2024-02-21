using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENPHILONG_02
{
    class NhanVienHD : NhanVien
    {
        private double doanhthu;
        public NhanVienHD(): base()
        {
        }

        public NhanVienHD(string maso, string hoten, int luongcung, double doanhthu): base(maso, hoten, luongcung)
        {
            this.doanhthu = doanhthu;
        }

        public double DoanhThu
        {
            set { this.doanhthu = value; }
            get { return doanhthu; }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap doanh thu:");
            this.doanhthu = double.Parse(Console.ReadLine());
        }

        public override int tinhLuong()
        {
            double luong = doanhthu * 0.1;
            return (int)luong;
        }
    }
}
