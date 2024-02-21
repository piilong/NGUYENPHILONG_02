﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENPHILONG_02
{
    class NhanVienBC: NhanVien
    {
        private string mucxeploai;

        public NhanVienBC() : base()
        {
        }
        public NhanVienBC(string maso, string hoten, int luongcung, string mucxeploai) : base(maso, hoten, luongcung)
        {
            this.mucxeploai = mucxeploai;
        }

        public string MucXepLoai
        {
            set { this.mucxeploai = value; }
            get { return mucxeploai; }
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap muc xep loai:");
            this.mucxeploai = Console.ReadLine();
        }

        public override int tinhLuong()
        {
            int Luong;
            if (MucXepLoai == "A")
                return Luong = (int)1.5 * LuongCung;
            if (MucXepLoai == "B")
                return Luong = (int)1.0 * LuongCung;
            else return  Luong = (int)0.5 * LuongCung;
        }
    }
}
