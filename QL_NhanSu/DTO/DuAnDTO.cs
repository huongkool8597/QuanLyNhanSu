using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DTO
{
    public class DuAnDTO
    {
        private int maDA;
        private string tenDA;
        private string diaDiem;
        private int maPB;

        public int MaDA { get => maDA; set => maDA = value; }
        public string TenDA { get => tenDA; set => tenDA = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public int MaPB { get => maPB; set => maPB = value; }

        public DuAnDTO(int maDA, string tenDA, string diaDiem, int maPB)
        {
            this.maDA = maDA;
            this.tenDA = tenDA;
            this.diaDiem = diaDiem;
            this.maPB = maPB;
        }

        public DuAnDTO(DataRow row)
        {
            Int32.TryParse(row["MADA"].ToString(), out this.maDA);
            this.tenDA = row["TENDA"].ToString();
            this.diaDiem = row["DIADIEM"].ToString();
            Int32.TryParse(row["MAPB"].ToString(), out this.maPB);
        }
    }
}