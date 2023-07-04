using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangdhph31492_TrainingC1_B1._1
{

    internal class Program
    {
        static void Main(string[] args)
        {
        }
        static void menu()
        {
            int chon;
            SERVICE service = new SERVICE();
            List<SinhVien> lstsinhvien = new List<SinhVien>();
            List<SinhVienUD> lstsinhvienUD = new List<SinhVienUD>();
            do
            {
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("1.Nhap danh sach doi tuong");
                Console.WriteLine("2.Xuatdanh sach doi tuong");
                Console.WriteLine("3.Xuat danh sach sinh vien Vip Happy Bee");
                Console.WriteLine("4.Xoa sinh vien ko tham gia Happy Bee(tuoi > 25)");
                Console.WriteLine("5.Ke thua");
                Console.WriteLine("0.thoat");
                Console.WriteLine("Moi chon chuong trinh:");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1: service.nhapDS(lstsinhvien); break;
                    case 2: service.xuatDS(lstsinhvien); break;
                    case 3: service.VipHappyBee(lstsinhvien); break;
                    case 4: service.XoaKoThamGiaHB(lstsinhvien); break;
                    case 5: service.nhapDSKT(lstsinhvienUD); break;
                    default:
                        break;
                }
            } while (chon != 0);
        }
    }
}
