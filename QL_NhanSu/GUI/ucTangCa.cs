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
using System.Data.SqlClient;

namespace QL_NhanSu.GUI
{
    public partial class ucTangCa : UserControl
    {
        BindingSource TangCaList = new BindingSource();
        public ucTangCa()
        {
            InitializeComponent();
            LoadFirstTime();
        }

        void LoadFirstTime()
        {
            dgvTangCa.DataSource = TangCaList;
            LoadListTangCa();
            LoadIntoComBoBoxMaNV(cboMaNhanVien);
            AddBinding();
            cboGhiChu.Items.Add("Đã thanh toán");
            cboGhiChu.Items.Add("");
        }

        void LoadListTangCa()
        {
            TangCaList.DataSource = TangCaDAO.Instance.GetTangCa();
            EditDataGridView();
        }

        void LoadIntoComBoBoxMaNV(ComboBox cb)
        {
            cb.DataSource = TangCaDAO.Instance.GetListMaNV();
            cb.DisplayMember = "MANV";
        }

        void AddBinding()
        {
            lblMaLamThem.DataBindings.Add(new Binding("Text", dgvTangCa.DataSource, "MATC", true, DataSourceUpdateMode.Never));
            cboMaNhanVien.DataBindings.Add(new Binding("Text", dgvTangCa.DataSource, "MANV", true, DataSourceUpdateMode.Never));
            txtSoGio.DataBindings.Add(new Binding("Text", dgvTangCa.DataSource, "SOGIO", true, DataSourceUpdateMode.Never));
            txtTongTien.DataBindings.Add(new Binding("Text", dgvTangCa.DataSource, "SOTIEN", true, DataSourceUpdateMode.Never));
            cboGhiChu.DataBindings.Add(new Binding("Text", dgvTangCa.DataSource, "GHICHU", true, DataSourceUpdateMode.Never));
            txtDonGia.DataBindings.Add(new Binding("Text", dgvTangCa.DataSource, "DONGIA", true, DataSourceUpdateMode.Never));
        }
        private void EditDataGridView()
        {
            dgvTangCa.Columns["MaNV"].Visible = false;
            dgvTangCa.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvTangCa.Columns["HoTen"].Width = 240;
            dgvTangCa.Columns["SoGio"].HeaderText = "Số Giờ";
            dgvTangCa.Columns["SoGio"].Width = 170;
            dgvTangCa.Columns["SoTien"].HeaderText = "Tổng Tiền";
            dgvTangCa.Columns["SoTien"].Width = 190;
            dgvTangCa.Columns["GhiChu"].HeaderText = "Ghi chú";
            dgvTangCa.Columns["GhiChu"].Width = 190;
            dgvTangCa.Columns["MaTc"].Visible = false;
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
            if (MessageBox.Show("Bạn có thật sự muốn thêm thông tin làm thêm của nhân viên có mã là: " + cboMaNhanVien.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtDonGia.Text == "" || txtSoGio.Text == "" || cboMaNhanVien.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    int manv;
                    int sogio;
                    int dongia;
                    Int32.TryParse(cboMaNhanVien.Text, out manv);
                    Int32.TryParse(txtSoGio.Text, out sogio);
                    Int32.TryParse(txtDonGia.Text, out dongia);
                    if (TangCaDAO.Instance.InsertTangCa(manv, sogio, dongia))
                    {
                        MessageBox.Show("Thêm thông tin thành công! ");
                        LoadListTangCa();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm thông tin! ");
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn sửa thông tin làm thêm của nhân viên có mã là: " + cboMaNhanVien.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtDonGia.Text == "" || txtSoGio.Text == "" || cboMaNhanVien.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    int matangca;
                    int manv;
                    int sogio;
                    int dongia;
                    string ghichu = cboGhiChu.Text;
                    Int32.TryParse(cboMaNhanVien.Text, out manv);
                    Int32.TryParse(txtSoGio.Text, out sogio);
                    Int32.TryParse(txtDonGia.Text, out dongia);
                    Int32.TryParse(lblMaLamThem.Text, out matangca);
                    if (TangCaDAO.Instance.UpdateTangCa(manv, sogio, dongia,ghichu, matangca))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListTangCa();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa thông tin! ");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm thông tin làm thêm của nhân viên có mã là: " + cboMaNhanVien.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maTc;
                Int32.TryParse(lblMaLamThem.Text, out maTc);
                if (TangCaDAO.Instance.DeleteTangCa(maTc))
                {
                    MessageBox.Show("Xóa nhân viên thành công! ");
                    LoadListTangCa();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa nhân viên! ");
                }
            }
        }
        void Reset()
        {
            lblMaLamThem.Text = "";
            txtDonGia.Text = "";
            txtSoGio.Text = "";
            txtTongTien.Text = "";
            LoadIntoComBoBoxMaNV(cboMaNhanVien);
            cboGhiChu.Text = "";
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
            LoadListTangCa();
        }

        private void ptSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvTangCa.DataSource = TangCaList;
            TangCaList.DataSource = TangCaDAO.Instance.SearchTangCa(str);
        }
    }
}
