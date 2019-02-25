using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DTO
{
    class ThanNhan_DTO
    {
        private int maNV;
        private string hoTenThanNhan;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string quanHe;

        public int MaNV { get => maNV; set => maNV = value; }
        public string HoTenThanNhan { get => hoTenThanNhan; set => hoTenThanNhan = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string QuanHe { get => quanHe; set => quanHe = value; }

        public ThanNhan_DTO(int maNV, string hoTenThanNhan, DateTime ngaySinh, string gioiTinh, string quanHe)
        {
            this.maNV = maNV;
            this.hoTenThanNhan = hoTenThanNhan;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.quanHe = quanHe;
        }

        public ThanNhan_DTO(DataRow row)
        {
            Int32.TryParse(row["MaNhanVien"].ToString(), out this.maNV);
            this.hoTenThanNhan = row["HoTen"].ToString();
            this.ngaySinh = (DateTime)row["NgaySinh"];
            this.gioiTinh = row["GioiTinh"].ToString();
            this.quanHe = row["QuanHe"].ToString();
        }
    }
}
