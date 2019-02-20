using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DTO
{
    class NhanVienDTO
    {
        private int maNV;
        private string hoTen;
        private DateTime ngaySinh;
        private string diaChi;
        private string gioiTinh;
        private int luong;
        private int maPB;
        private string sDT;
        private string tenPB;

        public int MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int Luong { get => luong; set => luong = value; }
        public int MaPB { get => maPB; set => maPB = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string TenPB { get => tenPB; set => tenPB = value; }

        public NhanVienDTO( int maNV,string hoTen, DateTime ngaySinh, string diaChi,  string gioiTinh, int luong,int maPB,string sDT,string tenPB)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.gioiTinh = gioiTinh;
            this.luong = luong;
            this.maPB = maPB;
            this.sDT = sDT;
            this.tenPB = tenPB;
        }
        public NhanVienDTO(DataRow row)
        {
            Int32.TryParse(row["MANV"].ToString(), out this.maNV);
            this.hoTen = row["HOTEN"].ToString();
            this.ngaySinh = (DateTime)row["NGSINH"];
            this.diaChi = row["DIACHI"].ToString();
            this.gioiTinh = row["GIOITINH"].ToString();
            Int32.TryParse(row["LUONG"].ToString(), out this.luong);
            Int32.TryParse(row["MAPB"].ToString(), out this.maPB);
            this.sDT = row["SDT"].ToString();
            this.tenPB = row["TENPB"].ToString();
        }
    }
}
