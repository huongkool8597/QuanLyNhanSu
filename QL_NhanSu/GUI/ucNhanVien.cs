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
using MetroFramework.Controls;

namespace QL_NhanSu.GUI
{
    public partial class ucNhanVien : UserControl
    {
        BindingSource NvList = new BindingSource();
        public ucNhanVien()
        {
            InitializeComponent();
            LoadFirstTime();
        }

        void LoadFirstTime()
        {
            dgvNhanVien.DataSource = NvList;
            LoadListNV();
            LoadIntoComBoBoxMaPB(cboPhongBan);
            AddBinding();
        }

        void LoadListNV()
        {
            NvList.DataSource = NhanVienDAO.Instance.GetNV();
            EditDataGridView();
        }

        void LoadIntoComBoBoxMaPB(ComboBox cb)
        {
            cb.DataSource = NhanVienDAO.Instance.GetListMaPB();
            cb.DisplayMember = "MAPB";
        }

        void AddBinding()
        {
            lblMaNV.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "MANV", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            txtSDT.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            cboPhongBan.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "MAPB", true, DataSourceUpdateMode.Never));
            dtpNgaySinh.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "ngaySinh", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
            txtLuong.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "LUONG", true, DataSourceUpdateMode.Never));
            var fmaleBinding = new Binding("Checked", dgvNhanVien.DataSource, "GIOITINH",true,DataSourceUpdateMode.Never);
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
        private void EditDataGridView()
        {
            dgvNhanVien.Columns["MaNV"].Visible = false;
            dgvNhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvNhanVien.Columns["HoTen"].Width = 240;
            dgvNhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgvNhanVien.Columns["NgaySinh"].Width = 170;
            dgvNhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns["DiaChi"].Width = 190;
            dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgvNhanVien.Columns["GioiTinh"].Width = 104;
            dgvNhanVien.Columns["Luong"].HeaderText = "Lương";
            dgvNhanVien.Columns["Luong"].Width = 140;
            dgvNhanVien.Columns["MaPB"].Visible = false;
            dgvNhanVien.Columns["MaPB"].HeaderText = "Mã phòng ban";
            dgvNhanVien.Columns["MaPB"].Width = 140;
            dgvNhanVien.Columns["SDT"].HeaderText = "Số điện thoại";
            dgvNhanVien.Columns["SDT"].Width = 140;
        }

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn thêm nhân viên có tên là: " + txtHoTen.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtHoTen.Text == "" || txtDiaChi.Text == "" || txtLuong.Text == "" || txtSDT.Text == "" || Int64.TryParse(txtSDT.Text, out check) == false)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
//                    LoadListNV();
                }
                else
                {
                    string hoTen = txtHoTen.Text;
                    DateTime ngaySinh;
                    DateTime.TryParse(dtpNgaySinh.Text, out ngaySinh);
                    string diaChi=txtDiaChi.Text;
                    string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
                    int luong;
                    Int32.TryParse(txtLuong.Text, out luong);
                    int maPB;
                    Int32.TryParse(cboPhongBan.Text, out maPB);
                    string sDT = txtSDT.Text; ;
                    if (NhanVienDAO.Instance.InsertNv(hoTen, ngaySinh, diaChi, gioiTinh, sDT, luong, maPB))
                    {
                        MessageBox.Show("Thêm nhân viên thành công! ");
                        LoadListNV();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm nhân viên! ");
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa nhân viên có tên là: " + txtHoTen.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtHoTen.Text == "" || txtDiaChi.Text == "" || txtLuong.Text == "" || txtSDT.Text == "" || txtSDT.Text.Length != 10 || Int64.TryParse(txtSDT.Text, out check) == false)
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    string hoTen = txtHoTen.Text;
                    DateTime ngaySinh;
                    DateTime.TryParse(dtpNgaySinh.Text, out ngaySinh);
                    string diaChi = txtDiaChi.Text;
                    string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
                    int luong;
                    Int32.TryParse(txtLuong.Text, out luong);
                    int maPB;
                    Int32.TryParse(cboPhongBan.Text, out maPB);
                    string sDT = txtSDT.Text;
                    int maNV;
                    Int32.TryParse(lblMaNV.Text, out maNV);
                    if (NhanVienDAO.Instance.UpdateNv(hoTen, ngaySinh, diaChi, gioiTinh, sDT, luong, maPB, maNV))
                    {
                        MessageBox.Show("Sửa nhân viên thành công! ");
                        LoadListNV();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa nhân viên! ");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên có tên là: " + txtHoTen.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maNV;
                Int32.TryParse(lblMaNV.Text, out maNV);
                if (NhanVienDAO.Instance.DeleteNv( maNV ))
                {
                    MessageBox.Show("Xóa nhân viên thành công! ");
                    LoadListNV();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa nhân viên! ");
                }
            }
        }

        void Reset()
        {
            lblMaNV.Text = "";
            txtHoTen.Text = "";
            txtLuong.Text = "";
            txtDiaChi.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            LoadIntoComBoBoxMaPB(cboPhongBan);
            txtSDT.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tac vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvNhanVien.DataSource = NvList;
            NvList.DataSource = NhanVienDAO.Instance.SearchNv(str);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListNV();
        }
    }
}
