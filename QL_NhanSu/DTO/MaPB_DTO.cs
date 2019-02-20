using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DTO
{
    class MaPB_DTO
    {
        private int maPB;

        public int MaPB { get => maPB; set => maPB = value; }

        public MaPB_DTO(int maPB)
        {
            this.maPB = maPB;
        }

        public MaPB_DTO(DataRow row)
        {
            Int32.TryParse(row["MAPB"].ToString(), out this.maPB);
        }
    }
}
