using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangdhph31492_TrainingC1_B1._1
{
    internal class SinhVien
    {
        private string maSV;
        private string ten;
        private int namSinh;
        private double diem;
        private int tuoi;
        public SinhVien()
        {

        }

        public SinhVien(string maSV, string ten, int namSinh, double diem, int tuoi)
        {
            this.maSV = maSV;
            this.ten = ten;
            this.namSinh = namSinh;
            this.diem = diem;
            this.tuoi = tuoi1();
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public virtual void inThongTin()
        {
            Console.WriteLine($"{maSV} | {ten} | {namSinh} | {diem}");
        }
        public int tuoi1()
        {
            int tuoi = DateTime.Now.Year - namSinh;
            return tuoi;
        }
    }
}
