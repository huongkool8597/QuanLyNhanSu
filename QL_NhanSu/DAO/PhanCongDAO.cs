using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhanSu.DTO;
using System.Data;

namespace QL_NhanSu.DAO
{ 
    class PhanCongDAO
    {
        private static PhanCongDAO instance;

        internal static PhanCongDAO Instance
        {
            get { if (instance == null) instance = new PhanCongDAO(); return instance; }
            private set { instance = value; }
        }
        public List<PhanCongDTO> GetPHANCONG()
        {
            List<PhanCongDTO> list = new List<PhanCongDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetPHANCONG");
            foreach (DataRow item in data.Rows)
            {
                PhanCongDTO da = new PhanCongDTO(item);
                list.Add(da);
            }
            return list;
        }
        public List<MaNV_DTO> GetListMaNV()
        {
            List<MaNV_DTO> maLopList = new List<MaNV_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MANV FROM dbo.NHANVIEN");
            foreach (DataRow item in data.Rows)
            {
                MaNV_DTO maLop = new MaNV_DTO(item);
                maLopList.Add(maLop);
            }
            return maLopList;
        }

        public List<MaDA_DTO> GetListMaDA()
        {
            List<MaDA_DTO> maLopList = new List<MaDA_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MADA FROM dbo.DUAN");
            foreach (DataRow item in data.Rows)
            {
                MaDA_DTO maLop = new MaDA_DTO(item);
                maLopList.Add(maLop);
            }
            return maLopList;
        }
        public bool InsertPHANCONG(int MADA, int MANV, int SOGIO) 
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_PHANCONG_INSERT @MADA , @MANV , @SOGIO ", new object[] { MADA, MANV,SOGIO });

            return result > 0;
        }
        public bool UpdatePHANCONG(int MADA, int MANV, int SOGIO)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_PHANCONG_UPDATE @MADA , @MANV , @SOGIO ", new object[] { MADA,MANV,SOGIO });

            return result > 0;
        }
        public bool DeletePHANCONG(int MADA,int MANV)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_PHANCONG_DELETE @MADA , @MANV", new object[] { MADA , MANV });

            return result > 0;
        }
        public List<PhanCongDTO> SearchPHANCONG(string str)
        { 
            List<PhanCongDTO> list = new List<PhanCongDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_PHANCONG_SEARCH @SEARCHVALUE ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                PhanCongDTO da = new PhanCongDTO(item);
                list.Add(da);
            }
            return list;
        }

    }
}
