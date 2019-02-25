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
    
    public partial class ucDuAn : UserControl
    {
        BindingSource DaList = new BindingSource();
        public ucDuAn()
        {
            InitializeComponent();
            Load();
        }

        void Load()
            {
                dgvDuAn.DataSource = DaList;
                LoadListDA();
                LoadIntoComBoBoxMaPB(cboPhongBanDA);
                AddBinding();
            }

        void LoadListDA()
        {
            DaList.DataSource = DuAnDAO.Instance.GetDA();
            EditDataGridViewDA();
        }

        void LoadIntoComBoBoxMaPB(ComboBox cb)
        {
            cb.DataSource = DuAnDAO.Instance.GetListMaPB();
            cb.DisplayMember = "MAPB";
        }

        void AddBinding()
        {
            lblMaDA.DataBindings.Add(new Binding("Text", dgvDuAn.DataSource, "MADA", true, DataSourceUpdateMode.Never));
            txtTenDA.DataBindings.Add(new Binding("Text", dgvDuAn.DataSource, "TENDA", true, DataSourceUpdateMode.Never));
            txtDiaDiemDA.DataBindings.Add(new Binding("Text", dgvDuAn.DataSource, "DIADIEM", true, DataSourceUpdateMode.Never));
            cboPhongBanDA.DataBindings.Add(new Binding("Text", dgvDuAn.DataSource, "MAPB", true, DataSourceUpdateMode.Never));           
        }

        private void EditDataGridViewDA()
        {
            dgvDuAn.Columns["MADA"].Visible = false;
            dgvDuAn.Columns["TENDA"].HeaderText = "Tên Dự Án";
            dgvDuAn.Columns["TENDA"].Width = 240;
            dgvDuAn.Columns["DIADIEM"].HeaderText = "Địa Điểm Dự Án";
            dgvDuAn.Columns["DIADIEM"].Width = 190;
            //dgvDuAn.Columns["MaPB"].Visible = false;
            dgvDuAn.Columns["MAPB"].HeaderText = "Mã phòng ban phụ trách";
            dgvDuAn.Columns["MAPB"].Width = 240;
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
            if (MessageBox.Show("Bạn có thật sự muốn thêm dự án là: " + txtTenDA.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenDA.Text == "" || txtDiaDiemDA.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                    //                    LoadListNV();
                }
                else
                {
                    string tenDA = txtTenDA.Text;                  
                    string diaDiem = txtDiaDiemDA.Text;
                    int maPB;
                    Int32.TryParse(cboPhongBanDA.Text, out maPB);                
                    if (DuAnDAO.Instance.InsertDA(tenDA, diaDiem, maPB))
                    {
                        MessageBox.Show("Thêm thông tin dự án thành công! ");
                        LoadListDA();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm thông tin dự án! ");
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            long check;
            if (MessageBox.Show("Bạn có thật sự muốn sửa dự án có tên là: " + txtTenDA.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                if (txtTenDA.Text == "" || txtDiaDiemDA.Text == "")
                {
                    MessageBox.Show("Sai hoặc thiếu thông tin");
                }
                else
                {
                    string tenDA = txtTenDA.Text;
                    string diaDiem = txtDiaDiemDA.Text;
                    int maPB;
                    Int32.TryParse(cboPhongBanDA.Text, out maPB);
                    
                    int maDA;
                    Int32.TryParse(lblMaDA.Text, out maDA);
                    if (DuAnDAO.Instance.UpdateDA(tenDA, diaDiem, maPB, maDA))
                    {
                        MessageBox.Show("Sửa thông tin dự án thành công! ");
                        LoadListDA();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi sửa thông tin dự án! ");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa dự án có tên là: " + txtTenDA.Text, "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int maDA;
                Int32.TryParse(lblMaDA.Text, out maDA);
                
                if (DuAnDAO.Instance.DeleteDA(maDA))
                {
                    MessageBox.Show("Xóa thông tin về dự án thành công! ");
                    LoadListDA();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi xóa thông tin dự án! ");
                }
            }
        }

         private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadListDA();
        }

        void Reset()
        {
            lblMaDA.Text = "";
            txtTenDA.Text = "";
            txtDiaDiemDA.Text = "";
            LoadIntoComBoBoxMaPB(cboPhongBanDA);
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
            dgvDuAn.DataSource = DaList;
            DaList.DataSource = DuAnDAO.Instance.SearchDA(str);
        }
    }
}
