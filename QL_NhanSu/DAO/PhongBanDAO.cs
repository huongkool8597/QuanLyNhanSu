using QL_NhanSu.DTO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DAO
{
    class PhongBanDAO
    {
        public static PhongBanDAO instance;
        internal static PhongBanDAO Instance
        {
            get { if (instance == null) instance = new PhongBanDAO(); return instance; }
            private set { instance = value; }
        }
        public List<Phongban_DTO> GetPB()
        {
            List<Phongban_DTO> list = new List<Phongban_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetDSPB");
            foreach (DataRow item in data.Rows) {       
                Phongban_DTO pb = new Phongban_DTO(item);
                list.Add(pb);
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
        public bool InsertPB(int maPB ,string tenPB , int maTB ,DateTime Ngnhanchuc)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertPB @TENPB , @MATB , @NGNHANCHUC", new object[] { tenPB , maTB , Ngnhanchuc });

            return result > 0;
        }

        public bool UpdateNv(int maPB, string tenPB, int maTB, DateTime Ngnhanchuc)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdatePB @MAPB , @TENPB , @MATB , @NGNHANCHUC" , new object[] { maPB, tenPB , maTB , Ngnhanchuc});

            return result > 0;
        }
        public bool DeletePB(int maPB)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeletePB @maPB ", new object[] { maPB });

            return result > 0;
        }
        public List<Phongban_DTO> SearchPB(string str)
        {
            List<Phongban_DTO> PBList = new List<Phongban_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchPB @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                Phongban_DTO PhongBan = new Phongban_DTO(item);
                PBList.Add(PhongBan);
            }
            return PBList;
        }
    }
}
