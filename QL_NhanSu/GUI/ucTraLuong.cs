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
    public partial class ucTraLuong : UserControl
    {
        BindingSource TraLuongList = new BindingSource();
        public ucTraLuong()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dgvTraLuong.DataSource = TraLuongList;
            LoadListTL();
            LoadIntoComBoBoxMaNV(cboNhanVien);
            AddBinding();
        }
        void LoadListTL()
        {
            TraLuongList.DataSource = TraLuongDAO.Instance.GetListTL();
            EditDataGridView();
        }
        void LoadIntoComBoBoxMaNV(ComboBox cb)
        {
            cb.DataSource = TraLuongDAO.Instance.GetListMaNV();
            cb.DisplayMember = "MANV";
        }
        void AddBinding()
        {
            cboNhanVien.DataBindings.Add(new Binding("Text", dgvTraLuong.DataSource, "MANV", true, DataSourceUpdateMode.Never));
            txtLuong.DataBindings.Add(new Binding("Text", dgvTraLuong.DataSource, "LUONG", true, DataSourceUpdateMode.Never));
            dtpNgayNhan.DataBindings.Add(new Binding("Text", dgvTraLuong.DataSource, "NgayNhan", true, DataSourceUpdateMode.Never));
            lblMaTT.DataBindings.Add(new Binding("Text", dgvTraLuong.DataSource, "MaTT", true, DataSourceUpdateMode.Never));
        }
        private void EditDataGridView()
        {
            dgvTraLuong.Columns["MaNV"].Visible = false;
            dgvTraLuong.Columns["TenNV"].HeaderText = "Họ Tên Nhân Viên";
            dgvTraLuong.Columns["TenNV"].Width = 240;
            dgvTraLuong.Columns["Luong"].HeaderText = "Lương";
            dgvTraLuong.Columns["Luong"].Width = 140;
            dgvTraLuong.Columns["NgayNhan"].HeaderText = "Ngày Nhận";
            dgvTraLuong.Columns["NgayNhan"].Width = 170;
            dgvTraLuong.Columns["MaTT"].Visible = false;
        }  


            private void btnBack_Click(object sender, EventArgs e)
        {
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            frmMain.FrmMain.MetroContainer.Controls.Add(ucMenu);
            frmMain.FrmMain.MetroContainer.Controls["ucMenu"].BringToFront();
            foreach (ucTraLuong uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucTraLuong>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm thông tin thanh toán lương cho nhân viên có mã là: " + cboNhanVien.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cboNhanVien.Text == "" || dtpNgayNhan.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    DateTime ngayNhan;
                    DateTime.TryParse(dtpNgayNhan.Text, out ngayNhan);
                    int maNV;
                    Int32.TryParse(cboNhanVien.Text, out maNV);
                    if (TraLuongDAO.Instance.InsertTL(maNV, ngayNhan))
                    {
                        MessageBox.Show("Thêm thông tin thanh toán lương thành công! ");
                        LoadListTL();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm thông tin thanh toán lương! ");
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn sửa thông tin thanh toán lương cho nhân viên có mã là: " + cboNhanVien.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cboNhanVien.Text == "" || dtpNgayNhan.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    DateTime ngayNhan;
                    DateTime.TryParse(dtpNgayNhan.Text, out ngayNhan);
                    int maNV;
                    Int32.TryParse(cboNhanVien.Text, out maNV);
                    int maTT;
                    Int32.TryParse(lblMaTT.Text, out maTT);
                    if (TraLuongDAO.Instance.UpdateTL(maNV, ngayNhan, maTT))
                    {
                        MessageBox.Show("Sửa thông tin thanh toán lương thành công! ");
                        LoadListTL();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa thông tin thanh toán lương! ");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa thông tin thanh toán lương cho nhân viên có mã là: " + cboNhanVien.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maTT;
                Int32.TryParse(lblMaTT.Text, out maTT);
                if (TraLuongDAO.Instance.DeleteTL(maTT))
                {
                    MessageBox.Show("Xóa thông tin thanh toán lương thành công! ");
                    LoadListTL();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa thông tin thanh toán lương! ");
                }
            }
        }
        void Reset()
        {
            lblMaTT.Text = "";
            txtLuong.Text = "";
            dtpNgayNhan.Value = DateTime.Now;
            LoadIntoComBoBoxMaNV(cboNhanVien);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tac vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListTL();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvTraLuong.DataSource = TraLuongList;
            TraLuongList.DataSource = TraLuongDAO.Instance.SearchTL(str);
        }
    }
}
