using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DTO
{
    class Phongban_DTO
    {
        private int mapb;
        private string tenpb;
        private int matb;
        private DateTime ngnhanchuc;

        public int Mapb { get => mapb; set => mapb = value; }
        public string Tenpb { get => tenpb; set => tenpb = value; }
        public int Matb { get => matb; set => matb = value; }
        public DateTime Ngnhanchuc { get => ngnhanchuc; set => ngnhanchuc = value; }

        public Phongban_DTO( int maPB, string tenPB, int maTB, DateTime Ngnhanchuc)
        {
            this.mapb = maPB;
            this.tenpb = tenPB;
            this.matb = maTB;
            this.ngnhanchuc = Ngnhanchuc;

        }
        public Phongban_DTO(DataRow row)
        {
            Int32.TryParse(row["MAPB"].ToString(), out this.mapb);
            this.Tenpb = row["TENPB"].ToString();
            Int32.TryParse(row["MATB"].ToString(), out this.matb);
            this.ngnhanchuc = (DateTime)row["NGNHANCHUC"];
        }


    }
}
