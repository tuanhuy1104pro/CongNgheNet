using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Module1
{
    public class ChuyenXe:NgoaiThanh,NoiThanh
    {
        protected string maSoChuyen;

        public string MaSoChuyen
        {
            get { return maSoChuyen; }
            set { maSoChuyen = value; }
        }
        protected string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        protected int soXe;

        public int SoXe
        {
            get { return soXe; }
            set { soXe = value; }
        }

        protected float doanhThu;

        public float DoanhThu
        {
            get { return doanhThu; }
            set { doanhThu = value; }
        }
        public ChuyenXe():this("","",0,0)
        {

        }
        public ChuyenXe(string masochuyen,string hoten,int soxe,float doanhthu)
        {
            this.maSoChuyen = masochuyen;
            this.hoTen = hoten;
            this.soXe = soxe;
            this.doanhThu = doanhthu;
        }
       
    }
    public interface NoiThanh
    {
        public int soChuyen;
        public float soKilomet;
    }
    private interface NgoaiThanh
    {
        public string noiDen;
        public int soNgayDi;
    }
}
