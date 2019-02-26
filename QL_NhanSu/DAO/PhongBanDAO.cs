using QL_NhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QL_NhanSu.DAO
{
    class PhongBanDAO
    {
        private static PhongBanDAO instance;

        internal static PhongBanDAO Instance
        {
            get { if (instance == null) instance = new PhongBanDAO(); return instance; }
            private set { instance = value; }
        }
        public List<PhongBanDTO> GetPB()
        {
            List<PhongBanDTO> list = new List<PhongBanDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetDSPB");
            foreach (DataRow item in data.Rows)
            {
                PhongBanDTO sv = new PhongBanDTO(item);
                list.Add(sv);
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

        public bool InsertPB(string tenpb,int matb, DateTime ngnhanchuc)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertPB @tenpb , @matb , @ngnhanchuc " ,new object[] { tenpb, matb, ngnhanchuc });

            return result > 0;
        }

        public bool UpdatePB(string tenpb,int matb, DateTime ngnhanchuc )
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdatePB @tenpb , @matb , @ngnhanchuc  ", new object[] { tenpb, matb, ngnhanchuc });

            return result > 0;
        }
        public bool DeletePB(int mapb)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeletePB @mapb ", new object[] { mapb });

            return result > 0;
        }
        public List<PhongBanDTO> SearchPB(string str)
        {
            List<PhongBanDTO> PBList = new List<PhongBanDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchPB @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                PhongBanDTO PhongBan = new PhongBanDTO(item);
                PBList.Add(PhongBan);
            }
            return PBList;
        }
    }
}
