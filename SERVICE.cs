using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hoangdhph31492_TrainingC1_B1._1
{
    internal class SERVICE
    {
        public delegate string check<T>(T a, T b);
        public static string checkInput(string msg, string regex)
        {
            string input;
            do
            {
                Console.WriteLine("Moi nhap " + msg + " sinh vien : ");
                input = Console.ReadLine();
                if (!Regex.IsMatch(input, regex))
                {
                    Console.WriteLine("moi nhap lai!!");
                }
            } while (!Regex.IsMatch(input, regex));
            return input;
        }
        public void nhapDS(List<SinhVien> lstsinhvien)
        {
            check<string> check = checkInput;
            string tt;
            do
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = checkInput("Ma", @"^[a-zA-Z_0-9]+$");
                sv.Ten = checkInput("ten", @"^[a-zA-Z]+$");
                sv.NamSinh = Convert.ToInt32(checkInput("nam sinh", @"^[0-9]{4}$"));
                sv.Diem = Convert.ToDouble(checkInput("diem", @"^[0-9]+\.?[0-9]*$"));

                lstsinhvien.Add(sv);
                Console.WriteLine("Co muon tiep tuc khong?(co/khong)");
                tt = Console.ReadLine();

            } while (tt.Equals("co"));
        }
        public void xuatDS(List<SinhVien> lstsinhvien)
        {
            if (lstsinhvien.Count == 0)
            {
                Console.WriteLine("Danh sach trong!!!!");
            }
            foreach (var item in lstsinhvien)
            {
                item.inThongTin();
            }
        }
        public void VipHappyBee(List<SinhVien> lstsinhvien)
        {
            var LstHappyBee = lstsinhvien.Where(x => x.Diem >= 8).ToList();
            foreach (var item in LstHappyBee)
            {
                item.inThongTin();
            }
        }
        public void XoaKoThamGiaHB(List<SinhVien> lstsinhvien)
        {

            var LstHappyBee = lstsinhvien.Where(x => x.Diem < 8 || x.Tuoi > 25).ToList();

            foreach (var item in LstHappyBee)
            {
                lstsinhvien.Remove(item);
            }
            foreach (var item in lstsinhvien)
            {
                item.inThongTin();
            }
        }
        public void nhapDSKT(List<SinhVienUD> lstsinhvien)
        {
            check<string> check = checkInput;
            string tt;
            do
            {
                SinhVienUD svUD = new SinhVienUD();
                svUD.MaSV = checkInput("Ma", @"^[a-zA-Z_0-9]+$");
                svUD.Ten = checkInput("ten", @"^[a-zA-Z]+$");
                svUD.NamSinh = Convert.ToInt32(checkInput("nam sinh", @"^[0-9]{4}$"));
                svUD.Diem = Convert.ToDouble(checkInput("diem", @"^[0-9]+\.?[0-9]*$"));
                lstsinhvien.Add(svUD);
                Console.WriteLine("Co muon tiep tuc khong?(co/khong)");
                tt = Console.ReadLine();

            } while (tt.Equals("co"));
        }
    }
}
