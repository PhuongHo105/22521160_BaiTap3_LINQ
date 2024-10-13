using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class SanPham
    {
        string maSP;
        public string MaSP { get { return maSP; } set { maSP = value; } }
        string tenSP;
        public string TenSP { get { return tenSP; } set {tenSP = value; } }
        int sl;
        public int SL { get { return sl; } set { sl = value; } }
        int donGia;
        public int DonGia {  get { return donGia; } set { donGia = value; } }
        string xuatXu;
        public string XuatXu { get { return xuatXu; } set { xuatXu = value; } }
        DateTime ngayHetHan;
        public DateTime NgayHetHan { get { return ngayHetHan; } set { ngayHetHan = value; } }
        
        public SanPham(string maSP, string tenSP, int sl, int dongia, string xuatXu, DateTime ngayHetHan)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.SL = sl;
            this.DonGia = dongia;
            this.XuatXu = xuatXu;
            this.NgayHetHan = ngayHetHan;
        }
    }
}
