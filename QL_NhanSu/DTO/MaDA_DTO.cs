using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DTO
{
    class MaDA_DTO
    {
        private int maDA;

        public int MaDA { get => maDA; set => maDA = value; }

        public MaDA_DTO(int maDA)
        {
            this.maDA = maDA;
        }

        public MaDA_DTO(DataRow row)
        {
            Int32.TryParse(row["MADA"].ToString(), out this.maDA);
        }
    }
}
