using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGUYENPHILONG_02
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }

        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.Write("Chon Loai Nhan Vien: [1: Nhan Vien Bien Che, 2: Nhan Vien Hop Dong]:");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Ban da chon sai, vui long chon lai 1 trong 2.");
                        break;
                }

                Console.Write("Ban co muon tiep tuc khong ? Y/N:");
                tieptuc = Console.ReadLine();
            } while (tieptuc.ToLower() == "y");
        }

        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so",-5} {"Ho Ten",20}, {"Doanh Thu",20}");
            foreach ( NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.MaSo,-5}  {x.HoTen,20} {x.tinhLuong(),20:#,##0 vnd}");
            }
        }
        
        public int tinhTongLuong()
        {
            int sum = 0;
            foreach (NhanVien nv in dsNV)
            {
                sum += nv.tinhLuong();
            }

            return sum;
        }

        public double tinhTongTrungBinh()
        {
            int dem = dsNV.Count();
            return tinhTongTrungBinh() / dem;
        }
    }
}
