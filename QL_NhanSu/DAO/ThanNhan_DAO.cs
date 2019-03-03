using QL_NhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanSu.DAO
{
    class ThanNhan_DAO
    {
        private static ThanNhan_DAO instance;

        internal static ThanNhan_DAO Instance
        {
            get { if (instance == null) instance = new ThanNhan_DAO(); return instance; }
            private set { instance = value; }
        }

        /// <summary>
        /// Lấy ra danh sách thân nhân sử dụng Store Procedure
        /// </summary>
        /// <returns>Trả về list thân nhân</returns>
        public List<ThanNhan_DTO> GetAllThanNhan()
        {
            List<ThanNhan_DTO> list = new List<ThanNhan_DTO>();
            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("[dbo].[SP_ThanNhan_GETALL]");
                foreach (DataRow item in data.Rows)
                {
                    ThanNhan_DTO thanNhan = new ThanNhan_DTO(item);
                    list.Add(thanNhan);
                }
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            return list;

        }

        /// <summary>
        /// Lấy ra list mã nhân viên
        /// </summary>
        /// <returns>Danh sách mã nhân viên</returns>
        public List<MaNV_DTO> GetListMaNhanVien()
        {
            List<MaNV_DTO> maNhanVienList = new List<MaNV_DTO>();


            try
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT MANV FROM dbo.NHANVIEN");
                foreach (DataRow item in data.Rows)
                {
                    MaNV_DTO ma = new MaNV_DTO(item);
                    maNhanVienList.Add(ma);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Load ma nhan vien loi. Thu lai!", e);
            }

            return maNhanVienList;
        }

        /// <summary>
        /// Thêm thân nhân vào database
        /// </summary>
        /// <param name="manv">Mã nhân viên</param>
        /// <param name="hoTenThanNhan">Họ tên thân nhân</param>
        /// <param name="ngsinh">Ngày sinh</param>
        /// <param name="gioitinh">Giới tính</param>
        /// <param name="quanHe">Quan hệ</param>
        /// <returns>True nếu insert thành công, False nếu insert không thành công</returns>
        public bool InsertThanNhan(int manv, string hoTenThanNhan, DateTime ngsinh, string gioitinh, string quanHe)
        {
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC [dbo].[SP_ThanNhan_INSERT] @MANV , @HOTENTN , @GIOITINH , @NGSINH , @QUANHE ", new object[] { manv, hoTenThanNhan, gioitinh, ngsinh, quanHe });

            return result > 0;
        }

        /// <summary>
        /// Update bảng thân nhân
        /// </summary>
        /// <param name="manv">Mã nhân viên</param>
        /// <param name="hoten">Họ và tên thân nhân</param>
        /// <param name="ngsinh">Ngày sinh</param>
        /// <param name="gioitinh">Giới tính</param>
        /// <param name="quanhe">Quan hệ</param>
        /// <returns>Trả về true nếu thành công, false nếu thất bại</returns>
        public bool UpdateThanNhan(int manv, string hotenthannhan, DateTime ngsinh, string gioitinh, string quanhe)
        { 
            int result = DataProvider.Instance.ExecuteNonQuery(" EXEC [dbo].[SP_ThanNhan_UPDATE] @MANV , @HOTENTN , @GIOITINH , @NGSINH , @QUANHE", new object[] { manv, hotenthannhan, gioitinh, ngsinh, quanhe });

            return result > 0;
        }

        /// <summary>
        /// Xóa một thân nhân của nhân viên
        /// </summary>
        /// <param name="manv">Mã nhân viên</param>
        /// <param name="hoTenThanNhan">Họ tên thân nhân</param>
        /// <returns>True nếu thành công, False nếu thất bại</returns>
        public bool DeleteThanNhan(int manv, string hoTenThanNhan)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC SP_ThanNhan_DELETE @MANV , @HOTENTN ", new object[] { manv, hoTenThanNhan });

            return result > 0;
        }

        /// <summary>
        /// Tìm kiếm thân nhân
        /// </summary>
        /// <param name="searchValue">Giá trị tìm kiếm</param>
        /// <returns>Danh sách thân nhân</returns>
        public List<ThanNhan_DTO> SearchThanNhan(string searchValue)
        {
            List<ThanNhan_DTO> ListThanNhan = new List<ThanNhan_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC [dbo].[SP_ThanNhan_SEARCH] @SEARCHVALUE ", new object[] { searchValue });
            foreach (DataRow item in data.Rows)
            {
                ThanNhan_DTO thanNhan = new ThanNhan_DTO(item);
                ListThanNhan.Add(thanNhan); 
            }
            return ListThanNhan;
        }
    }
}
