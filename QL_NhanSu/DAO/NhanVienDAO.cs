using QL_NhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        public List<NhanVienDTO> GetNV()
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetDSNV");
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO sv = new NhanVienDTO(item);
                list.Add(sv);
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

        public bool InsertNv(string hoten,DateTime ngsinh,string diachi,string gioitinh,string sdt,int luong,int mapb)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertNv @hoten , @ngsinh , @diachi , @gioitinh , @sdt , @luong , @mapb ", new object[] { hoten, ngsinh, diachi, gioitinh, sdt, luong, mapb });

            return result > 0;
        }

        public bool UpdateNv(string hoten, DateTime ngsinh, string diachi, string gioitinh, string sdt, int luong, int mapb, int manv)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_UpdateNV @manv , @hoten , @ngsinh , @diachi , @gioitinh , @sdt , @luong , @mapb ", new object[] { manv, hoten, ngsinh, diachi, gioitinh, sdt, luong, mapb });

            return result > 0;
        }
        public bool DeleteNv( int manv )
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_DeleteNV @manv ", new object[] { manv });

            return result > 0;
        }
        public List<NhanVienDTO> SearchNv(string str)
        {
            List<NhanVienDTO> NvList = new List<NhanVienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchNv @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                NhanVienDTO NhanVien = new NhanVienDTO(item);
                NvList.Add(NhanVien);
            }
            return NvList;
        }
    }
}
