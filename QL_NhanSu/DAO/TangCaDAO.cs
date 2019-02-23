using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhanSu.DTO;

namespace QL_NhanSu.DAO
{
    class TangCaDAO
    {
        private static TangCaDAO instance;

        internal static TangCaDAO Instance
        {
            get { if (instance == null) instance = new TangCaDAO(); return instance; }
            private set { instance = value; }
        }
        public List<TangCaDTO> GetTangCa()
        {
            List<TangCaDTO> list = new List<TangCaDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.USP_GetDSLamThem");
            foreach (DataRow item in data.Rows)
            {
                TangCaDTO tc = new TangCaDTO(item);
                list.Add(tc);
            }
            return list;

        }
        public List<MaNV_DTO> GetListMaNV()
        {
            List<MaNV_DTO> maNVList = new List<MaNV_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MANV FROM dbo.NHANVIEN");
            foreach (DataRow item in data.Rows)
            {
                MaNV_DTO maNV = new MaNV_DTO(item);
                maNVList.Add(maNV);
            }
            return maNVList;
        }
        public bool InsertTangCa(int manv, int sogio, int dongia)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC USP_InsertLamthem @manv , @sogio , @dongia ", new object[] { manv,sogio,dongia });

            return result > 0;
        }
    }
}

