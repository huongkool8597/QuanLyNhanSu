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

        private void LoadFirstTime()
        {
            // dgvThanNhan.DataSource = thanNhanList;
            LoadListThanNhan();
        }

        private void LoadListThanNhan ()
        {
            dgvThanNhan.DataSource = thanNhanList;
            thanNhanList.DataSource = ThanNhan_DAO.Instance.GetAllThanNhan();
            EditDataGridView();
        }

        private void EditDataGridView()
        {
            dgvThanNhan.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvThanNhan.Columns["HoTenThanNhan"].HeaderText = "Họ tên thân nhân";
            dgvThanNhan.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvThanNhan.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvThanNhan.Columns["QuanHe"].HeaderText = "Quan hệ";

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
    }
}
