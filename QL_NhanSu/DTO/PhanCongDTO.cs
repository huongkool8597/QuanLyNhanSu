using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DTO
{
    class PhanCongDTO
    {
        private string hOTEN;
        private string tENDA;
        private int mADA;
        private int mANV;
        private int sOGIO;

        public string HOTEN { get => hOTEN; set => hOTEN = value; }
        public string TENDA { get => tENDA; set => tENDA = value; }
        public int MADA { get => mADA; set => mADA = value; }
        public int MANV { get => mANV; set => mANV = value; }
        public int SOGIO { get => sOGIO; set => sOGIO = value; }


        public PhanCongDTO(int mADA, int mANV, int sOGIO,string hOTEN,string tENDA)
        {
            this.hOTEN = hOTEN;
            this.tENDA = tENDA;
            this.mADA = mADA;
            this.mANV = mANV;
            this.sOGIO = sOGIO;

        }
        public PhanCongDTO(DataRow row)
        {
            this.hOTEN = row["HOTEN"].ToString();
            this.tENDA = row["TENDA"].ToString();

            Int32.TryParse(row["MADA"].ToString(), out this.mADA);

            Int32.TryParse(row["MANV"].ToString(), out this.mANV);

            Int32.TryParse(row["SOGIO"].ToString(), out this.sOGIO);

        }
    }


}
