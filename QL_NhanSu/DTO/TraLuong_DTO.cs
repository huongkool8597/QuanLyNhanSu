using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DTO
{
    class TraLuong_DTO
    {
        private int maNV;
        private string tenNV;
        private int luong;
        private DateTime ngayNhan;
        private int maTT;

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public int Luong { get => luong; set => luong = value; }
        public DateTime NgayNhan { get => ngayNhan; set => ngayNhan = value; }
        public int MaTT { get => maTT; set => maTT = value; }

        public TraLuong_DTO(int maNV,string tenNV,int luong,DateTime ngayNhan, int maTT)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.luong = luong;
            this.ngayNhan = ngayNhan;
            this.maTT = maTT;
        }
        public TraLuong_DTO (DataRow row)
        {
            Int32.TryParse(row["MANV"].ToString(), out maNV);
            this.tenNV = row["HOTEN"].ToString();
            Int32.TryParse(row["LUONG"].ToString(), out luong);
            DateTime.TryParse(row["NGNHAN"].ToString(), out ngayNhan);
            Int32.TryParse(row["MATL"].ToString(), out maTT);
        }
    }
}
