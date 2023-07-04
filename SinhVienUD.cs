using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoangdhph31492_TrainingC1_B1._1
{
    internal class SinhVienUD : SinhVien
    {
        private int kyHoc;
        public SinhVienUD()
        {

        }
        public SinhVienUD(string maSV, string ten, int namSinh, double diem,int tuoi, int kyHoc) : base(maSV, ten, namSinh, diem,tuoi)
        {
            this.kyHoc = kyHoc;
        }

        public int KyHoc { get => kyHoc; set => kyHoc = value; }
        public override void inThongTin()
        {
            base.inThongTin();
        }
    }
}
