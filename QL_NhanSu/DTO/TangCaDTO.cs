using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DTO
{
    class TangCaDTO
    {
        private int maNV;
        private string hoTen;
        private int soGio;
        private int soTien;

        public int MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int SoGio { get => soGio; set => soGio = value; }
        public int SoTien { get => soTien; set => soTien = value; }
        public TangCaDTO(int maNV, string hoTen, int soGio, int soTien)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.soGio = soGio;
            this.soTien = soTien;
        }
        public TangCaDTO(DataRow row)
        {
            Int32.TryParse(row["MANV"].ToString(), out this.maNV);
            this.hoTen = row["HOTEN"].ToString();
            Int32.TryParse(row["SOBUOI"].ToString(), out this.soGio);
            Int32.TryParse(row["TONGTIEN"].ToString(), out this.soTien);
        }
    }
}
