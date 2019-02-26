using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QL_NhanSu.DTO
{
    class PhongBanDTO
    {
        private int mapb;
        private string tenpb;
        private int matb;
        private string hoTen;
        private DateTime ngnhanchuc;

        public int Mapb { get => mapb; set => mapb = value; }
        public string Tenpb { get => tenpb; set => tenpb = value; }
        public int Matb { get => matb; set => matb = value; }
        public DateTime Ngnhanchuc { get => ngnhanchuc; set => ngnhanchuc = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }

        public PhongBanDTO(int mapb, string tenpb, int matb, DateTime ngnhanchuc,string hoTen)
        {
            this.mapb = Mapb;
            this.tenpb = Tenpb;
            this.matb = Matb;
            this.hoTen = HoTen;
            this.ngnhanchuc = Ngnhanchuc;

        }
        public PhongBanDTO(DataRow row)
        {
            Int32.TryParse(row["MAPB"].ToString(), out this.mapb);
            this.tenpb = row["TENPB"].ToString();
            Int32.TryParse(row["MATB"].ToString(), out this.matb);
            this.hoTen = row["HOTEN"].ToString();
            this.ngnhanchuc = (DateTime)row["NGNHANCHUC"];

        }
    }
}
