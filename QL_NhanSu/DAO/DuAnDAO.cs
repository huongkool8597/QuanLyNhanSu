using QL_NhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DAO
{
    class DuAnDAO
    {
        private static DuAnDAO instance;

        internal static DuAnDAO Instance
        {
            get { if (instance == null) instance = new DuAnDAO(); return instance; }
            private set { instance = value; }
        }

        public List<DuAnDTO> GetDA()
        {
            List<DuAnDTO> list = new List<DuAnDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetDSDA");
            foreach (DataRow item in data.Rows)
            {
                DuAnDTO da = new DuAnDTO(item);
                list.Add(da);
            }
            return list;
        }

        public List<MaPB_DTO> GetListMaPB()
        {
            List<MaPB_DTO> maLopList = new List<MaPB_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MAPB FROM dbo.PHONGBAN");
            foreach (DataRow item in data.Rows)
            {
                MaPB_DTO maLop = new MaPB_DTO(item);
                maLopList.Add(maLop);
            }
            return maLopList;
        }

        public bool InsertDA(string TENDA, string DIADIEM, int MAPB)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC SP_DUAN_INSERT @TENDA , @DIADIEM , @MAPB ", new object[] { TENDA, DIADIEM, MAPB });

            return result > 0;
        }

        public bool UpdateDA(string TENDA, string DIADIEM, int MAPB, int MADA)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC SP_DUAN_UPDATE @MADA , @TENDA , @DIADIEM , @MAPB ", new object[] { MADA, TENDA, DIADIEM, MAPB });

            return result > 0;
        }

        public bool DeleteDA(int MADA)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC SP_DUAN_DELETE @MADA", new object[] { MADA });

            return result > 0;
        }

        public List<DuAnDTO> SearchDA(string str)
        {
            List<DuAnDTO> DaList = new List<DuAnDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC SP_DUAN_SEARCH @SEARCHVALUE ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                DuAnDTO DuAn = new DuAnDTO(item);
                DaList.Add(DuAn);
            }
            return DaList;
        }


    }
}