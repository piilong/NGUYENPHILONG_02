﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENPHILONG_02
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            QuanLyNV ql = new QuanLyNV();
            int chon = 0;
            do
            {
                Console.WriteLine("******** CHUONG TRINH  QUAN LY NHAN VIEN ******");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("1. Nhap danh sach nhan vien.");
                Console.WriteLine("2. Xuat thong tin nhan vien.");
                Console.WriteLine("3. Thong ke tong tien luong nhan vien.");
                Console.WriteLine("0. Ket thuc chuong trinh");
                Console.WriteLine("--------------------------------");
                Console.Write("Ban chon chuc nang:");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        ql.NhapDS();
                        break;

                    case 2:
                        ql.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine($"Tong tien luong phai tra cho nhan vien: {ql.tinhTongLuong():#,##0 vnd}");
                        break;
                    case 0:
                        Console.WriteLine("Tam bie.");
                        Console.ReadLine();
                        break;
                }

            } while (chon != 0);
        }
    }
}
