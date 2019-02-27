using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NhanSu.DAO;

namespace QL_NhanSu.GUI
{
    public partial class ucThanNhan : UserControl
    {
        BindingSource thanNhanList = new BindingSource();

        ////////////////////////////// LOADING FOR FIRST TIME ////////////////////////////// 

        public ucThanNhan()
        {
            InitializeComponent();
            LoadFirstTime();
        }

        /// <summary>
        /// Load lần đầu tiên khi vào trong view
        /// </summary>
        private void LoadFirstTime()
        {
            dgvThanNhan.DataSource = thanNhanList;
            LoadListThanNhan();
            EditDataGridView();
            LoadIntoComBoBoxMaNhanVien();
            BindingDataToFrom();
        }

        /// <summary>
        /// Load list thân nhân từ Database và đẩy ra gridview
        /// </summary>
        private void LoadListThanNhan ()
        {
            
            thanNhanList.DataSource = ThanNhan_DAO.Instance.GetAllThanNhan();
        }

        /// <summary>
        /// Đổi tên cột tương ứng trong gridview
        /// </summary>
        private void EditDataGridView()
        {
            dgvThanNhan.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvThanNhan.Columns["HoTenThanNhan"].HeaderText = "Họ tên thân nhân";
            dgvThanNhan.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvThanNhan.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvThanNhan.Columns["QuanHe"].HeaderText = "Quan hệ";
        }

        /// <summary>
        /// Load và hiển thị dữ liệu mã nhân viên ra combobox
        /// </summary>
        private void LoadIntoComBoBoxMaNhanVien()
        {
            cboMaNhanVien.DataSource = ThanNhan_DAO.Instance.GetListMaNhanVien();
            cboMaNhanVien.DisplayMember = "MANV";
        }

        /// <summary>
        /// BindingData ra các ô: text box, giới tính, ngày sinh
        /// </summary>
        private void BindingDataToFrom ()
        {
            txtHoTenThanNhan.DataBindings.Add(new Binding("Text", dgvThanNhan.DataSource, "HoTenThanNhan", true, DataSourceUpdateMode.Never));
            txtQuanHe.DataBindings.Add(new Binding("Text", dgvThanNhan.DataSource, "QuanHe", true, DataSourceUpdateMode.Never));

            cboMaNhanVien.DataBindings.Add(new Binding("Text", dgvThanNhan.DataSource, "MaNV", true, DataSourceUpdateMode.Never));

            dtpNgaySinh.DataBindings.Add(new Binding("Text", dgvThanNhan.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));

            var fmaleBinding = new Binding("Checked", dgvThanNhan.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never);
            // when Formatting (reading from datasource), return true for Female, else false
            fmaleBinding.Format += (s, args) => args.Value = ((string)args.Value) == "Nữ";
            // when Parsing (writing to datasource), return "Male" for true, else "Fmale"
            fmaleBinding.Parse += (s, args) => args.Value = (bool)args.Value ? "Nữ" : "Nam";
            // add the binding
            radNu.DataBindings.Add(fmaleBinding);
            // you don't need to bind the Male radiobutton, just make it do the opposite
            // of Male by handling the CheckedChanged event on Male:
            radNu.CheckedChanged += (s, args) => radNam.Checked = !radNu.Checked;
        }
        ////////////////////////////// HANDLE EVENT OF BUTTON ////////////////////////////// 
        private void btnBack_Click(object sender, EventArgs e)
        {
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            frmMain.FrmMain.MetroContainer.Controls.Add(ucMenu);
            frmMain.FrmMain.MetroContainer.Controls["ucMenu"].BringToFront();
            foreach (ucNhanVien uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucNhanVien>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }

        private void dgvThanNhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadListThanNhan();
        }

        /// <summary>
        /// Làm trống form
        /// </summary>
        void ResetFormToNull()
        {
            txtQuanHe.Text = "";
            txtHoTenThanNhan.Text = "";
            txtSearch.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            LoadIntoComBoBoxMaNhanVien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetFormToNull();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa thân nhân của nhân viên có tên là: " + txtHoTenThanNhan.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maNV;
                string hoTenThanNhan = txtHoTenThanNhan.Text;
                Int32.TryParse(cboMaNhanVien.Text, out maNV);
                try
                {
                    ThanNhan_DAO.Instance.DeleteThanNhan(maNV, hoTenThanNhan);
                    MessageBox.Show("Xóa thân nhân của nhân viên thành công! ");
                    LoadFirstTime();
                } catch (Exception error)
                {
                    // MessageBox.Show("Có lỗi khi xóa thân nhân! Vui lòng thử lại.");
                    Console.WriteLine(error);

                }
            }
        }
    }
}
