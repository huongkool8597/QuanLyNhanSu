using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System;
using System.Windows.Forms;
using QL_NhanSu.DAO;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

namespace QL_NhanSu.GUI
{
    public partial class ucPhongBan : UserControl
    {
        BindingSource PBList = new BindingSource();
        public ucPhongBan()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            dgvPhongBan.DataSource = PBList;
            LoadListPB();
            LoadIntoComBoBoxMaPB(cboTruongPhong);
            AddBinding();
        }
        void LoadListPB()
        {
            
                PBList.DataSource = PhongBanDAO.Instance.GetPB();
                EditDataGridView();
            
        }
        void LoadIntoComBoBoxMaPB(ComboBox cb)
        {
            cb.DataSource = PhongBanDAO.Instance.GetListMaNV();
            cb.DisplayMember = "MANV";
        }
        void AddBinding()
        {
            lblMaPB.DataBindings.Add(new Binding("Text", dgvPhongBan.DataSource, "MAPB", true, DataSourceUpdateMode.Never));
            txtTenPB.DataBindings.Add(new Binding("Text", dgvPhongBan.DataSource, "TENPB", true, DataSourceUpdateMode.Never));
            cboTruongPhong.DataBindings.Add(new Binding("Text", dgvPhongBan.DataSource, "MATB", true, DataSourceUpdateMode.Never));
            dtpNgNhanChuc.DataBindings.Add(new Binding("Text", dgvPhongBan.DataSource, "NgNhanChuc", true, DataSourceUpdateMode.Never));
        }
        private void EditDataGridView()
        {
            dgvPhongBan.Columns["MaPB"].Visible = false;
            dgvPhongBan.Columns["TenPB"].HeaderText = "Tên Phòng Ban";
            dgvPhongBan.Columns["TenPB"].Width = 240;
            dgvPhongBan.Columns["MaTB"].Visible = false;
            dgvPhongBan.Columns["NgNhanChuc"].HeaderText = "Ngày Nhận Chức";
            dgvPhongBan.Columns["NgNhanChuc"].Width = 200;
            dgvPhongBan.Columns["HOTEN"].HeaderText = "Họ Tên";
            dgvPhongBan.Columns["HoTen"].Width = 240;
        }
        /////////////////////////////////// Handle Event Button////////////////////////// 
        /// <summary>
        /// Trở lại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            ucMenu ucMenu = new ucMenu();
            ucMenu.Dock = DockStyle.Fill;
            frmMain.FrmMain.MetroContainer.Controls.Add(ucMenu);
            frmMain.FrmMain.MetroContainer.Controls["ucMenu"].BringToFront();
            foreach (ucPhongBan uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucPhongBan>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm Phong Ban có tên là: " + txtTenPB.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenPB.Text == "" || cboTruongPhong.Text == "" )
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListPB();
                }
                else
                {
                    string TenPB = txtTenPB.Text;
                    DateTime ngnhanchuc;
                    DateTime.TryParse(dtpNgNhanChuc.Text, out ngnhanchuc);
                    int maTB;
                    Int32.TryParse(cboTruongPhong.Text, out maTB);
                    if (PhongBanDAO.Instance.InsertPB(TenPB, maTB, ngnhanchuc))
                    {
                        MessageBox.Show("Thêm Phòng Ban thành công! ");
                        LoadListPB();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm phòng ban! ");
                    }
                }
            }
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn sửa phòng ban có tên là: " + txtTenPB.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenPB.Text == "" || cboTruongPhong.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    int maPB;
                    Int32.TryParse(lblMaPB.Text, out maPB);
                    string TenPB = txtTenPB.Text;
                    DateTime ngnhanchuc;
                    DateTime.TryParse(dtpNgNhanChuc.Text, out ngnhanchuc);
                    int maTB;
                    Int32.TryParse(cboTruongPhong.Text, out maTB);
                    if (PhongBanDAO.Instance.UpdateNv(maPB,TenPB, maTB, ngnhanchuc))
                    {
                        MessageBox.Show("Cập Nhậy Phòng Ban thành công! ");
                        LoadListPB();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi cập nhật phòng ban! ");
                    }
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa phòng ban có tên là: " + txtTenPB.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    int maPB;
                    Int32.TryParse(lblMaPB.Text, out maPB);
                    if (PhongBanDAO.Instance.DeletePB(maPB))
                    {
                        MessageBox.Show("Xóa phòng ban thành công! ");
                        LoadListPB();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa phòng ban! ");
                    }
                }
            }
        }

        void Reset()
        {
            lblMaPB.Text = "";
            txtTenPB.Text = "";
            cboTruongPhong.Text = "";
            dtpNgNhanChuc.Value = DateTime.Now;
            LoadIntoComBoBoxMaPB(cboTruongPhong);

        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy các thao tac vừa nhập ", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Reset();
            }
        }

        private void ptnsearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") MessageBox.Show("Chưa nhập thông tin tìm kiếm");
            string str = txtSearch.Text;
            dgvPhongBan.DataSource = PBList;
            PBList.DataSource = PhongBanDAO.Instance.SearchPB(str);

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListPB();
        }
    }
}
