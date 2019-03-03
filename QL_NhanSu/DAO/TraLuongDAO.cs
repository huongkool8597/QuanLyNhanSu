using QL_NhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DAO
{
    class TraLuongDAO
    {
        private static TraLuongDAO instance;

        internal static TraLuongDAO Instance
        {
            get { if (instance == null) instance = new TraLuongDAO(); return instance; }
            private set { instance = value; }
        }
        public List<TraLuong_DTO> GetListTL()
        {
            List<TraLuong_DTO> list = new List<TraLuong_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetTraLuong");
            foreach (DataRow item in data.Rows)
            {
                TraLuong_DTO sv = new TraLuong_DTO(item);
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
        public bool InsertTL(int maNV,DateTime ngNhan)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertTL @manv , @ngaynhan ", new object[] { maNV, ngNhan });

            return result > 0;
        }
        public bool UpdateTL(int maNV, DateTime ngNhan, int maTT)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateTL @matt , @manv , @ngaynhan ", new object[] { maTT, maNV, ngNhan });

            return result > 0;
        }
        public bool DeleteTL(int maTT)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteTL @matt ", new object[] { maTT });

            return result > 0;
        }
        public List<TraLuong_DTO> SearchTL(string str)
        {
            List<TraLuong_DTO> TLList = new List<TraLuong_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchTL @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                TraLuong_DTO TraLuong = new TraLuong_DTO(item);
                TLList.Add(TraLuong);
            }
            return TLList;
        }
    }
}
