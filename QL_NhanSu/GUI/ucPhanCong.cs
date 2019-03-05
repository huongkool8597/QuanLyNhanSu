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
    public partial class ucPhanCong : UserControl
    {
        BindingSource PcList = new BindingSource();
        public ucPhanCong()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dgvPhanCong.DataSource = PcList;
            LoadListPhanCong();
            LoadIntoComBoBoxMaNV(cboMaNhanVien);
            LoadIntoComBoBoxMaDA(cboDuAn);
            AddBinding();
        }
        void LoadListPhanCong()
        {
            PcList.DataSource = PhanCongDAO.Instance.GetPHANCONG();
            EditDataGridViewPhanCong();
        }

        void LoadIntoComBoBoxMaDA(ComboBox cb)
        {
            cb.DataSource = PhanCongDAO.Instance.GetListMaDA();
            cb.DisplayMember = "MADA";
        }

        void LoadIntoComBoBoxMaNV(ComboBox cb)
        {
            cb.DataSource = PhanCongDAO.Instance.GetListMaNV();
            cb.DisplayMember = "MANV";
        }
        void AddBinding()
        {
            cboDuAn.DataBindings.Add(new Binding("Text", dgvPhanCong.DataSource, "MADA", true, DataSourceUpdateMode.Never));
            cboMaNhanVien.DataBindings.Add(new Binding("Text", dgvPhanCong.DataSource, "MANV", true, DataSourceUpdateMode.Never));
            txtSoGio.DataBindings.Add(new Binding("Text", dgvPhanCong.DataSource, "SOGIO", true, DataSourceUpdateMode.Never));
        }
        private void EditDataGridViewPhanCong()
        {
            dgvPhanCong.Columns["MADA"].Visible = false;
            dgvPhanCong.Columns["TENDA"].HeaderText = "Tên Dự Án";
            dgvPhanCong.Columns["TENDA"].Width = 240;
            dgvPhanCong.Columns["MANV"].Visible = false;
            dgvPhanCong.Columns["HOTEN"].HeaderText = "Tên Nhân Viên";
            dgvPhanCong.Columns["HOTEN"].Width = 190;
            dgvPhanCong.Columns["SOGIO"].HeaderText ="Số Giờ";
            dgvPhanCong.Columns["SOGIO"].Width = 240;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            frmMain.FrmMain.MetroContainer.Controls.Add(ucMenu);
            frmMain.FrmMain.MetroContainer.Controls["ucMenu"].BringToFront();
            foreach (ucPhanCong uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucPhanCong>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có thật sự muốn thêm nhân viên có mã là: " + cboDuAn.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cboDuAn.Text == "" || cboMaNhanVien.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListPC();
                }
                else
                {
                    int MaDA;
                    Int32.TryParse(cboDuAn.Text, out MaDA);
                    int MaNV;
                    Int32.TryParse(cboMaNhanVien.Text, out MaNV);
                    int SOGIO;
                    Int32.TryParse(txtSoGio.Text, out SOGIO);
                    if (PhanCongDAO.Instance.InsertPHANCONG(MaDA, MaNV, SOGIO))
                    {
                        MessageBox.Show("Thêm thông tin bảng phân công thành công! ");
                        LoadListPhanCong();
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
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa phân công có mã dự án là: " + cboDuAn.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (cboDuAn.Text == "" || cboMaNhanVien.Text == "" )
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    int MaDA;
                    Int32.TryParse(cboDuAn.Text, out MaDA);
                    int MaNV;
                    Int32.TryParse(cboMaNhanVien.Text, out MaNV);
                    int SOGIO;
                    Int32.TryParse(txtSoGio.Text, out SOGIO);
                    if (PhanCongDAO.Instance.UpdatePHANCONG(MaDA, MaNV, SOGIO))
                    {
                        MessageBox.Show("Sửa thông tin thành công! ");
                        LoadListPhanCong();
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
            if (MessageBox.Show("Bạn có thật sự muốn xóa dự án có mã là: " + cboDuAn.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int MaDA;
                Int32.TryParse(cboDuAn.Text, out MaDA);
                int MaNV;
                Int32.TryParse(cboMaNhanVien.Text, out MaNV);
                if (PhanCongDAO.Instance.DeletePHANCONG(MaDA,MaNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công! ");
                    LoadListPhanCong();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa thông tin! ");
                }
            }
        }
        void Reset()
        {
            cboDuAn.Text = "";
            cboMaNhanVien.Text = "";
            txtSoGio.Text = "";
            LoadIntoComBoBoxMaDA(cboDuAn);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tac vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvPhanCong.DataSource = PcList;
            PcList.DataSource = PhanCongDAO.Instance.SearchPHANCONG(str);
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListPhanCong();
        }
    }
}

