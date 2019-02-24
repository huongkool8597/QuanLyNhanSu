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
        public bool UpdateTangCa(int manv, int sogio, int dongia, string ghichu , int matangca)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC dbo.USP_UpdateLamthem @matangca , @manv , @sogio , @dongia , @ghichu ", new object[] { matangca , manv, sogio , dongia , ghichu});

            return result > 0;
        }
        public bool DeleteTangCa(int matangca)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC dbo.USP_DeleteLamThem @matangca ", new object[] { matangca });

            return result > 0;
        }
        public List<TangCaDTO> SearchTangCa(string str)
        {
            List<TangCaDTO> TcList = new List<TangCaDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_SearchLamThem @search ", new object[] { str });
            foreach (DataRow item in data.Rows)
            {
                TangCaDTO TangCa = new TangCaDTO(item);
                TcList.Add(TangCa);
            }
            return TcList;
        }
    }
}

