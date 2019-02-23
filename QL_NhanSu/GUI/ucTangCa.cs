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
            Load();
        }

        void Load()
        {
            dgvTangCa.DataSource = TangCaList;
            LoadListTangCa();
            LoadIntoComBoBoxMaNV(cboMaNhanVien);
            AddBinding();
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
            cboMaNhanVien.DataBindings.Add(new Binding("Text", dgvTangCa.DataSource, "MANV", true, DataSourceUpdateMode.Never));
            txtSoGio.DataBindings.Add(new Binding("Text", dgvTangCa.DataSource, "SOGIO", true, DataSourceUpdateMode.Never));
            txtTongTien.DataBindings.Add(new Binding("Text", dgvTangCa.DataSource, "SOTIEN", true, DataSourceUpdateMode.Never));
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
                        MessageBox.Show("Thêm nhân viên thành công! ");
                        LoadListTangCa();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm nhân viên! ");
                    }
                }
            }
        }
    }
}
