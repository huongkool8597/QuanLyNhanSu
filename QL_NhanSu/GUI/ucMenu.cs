using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace QL_NhanSu.GUI
{
    public partial class ucMenu : UserControl
    {
        public ucMenu()
        {
            InitializeComponent();
        }
        string ucName = "";
        private void btn_Click(object sender, EventArgs e)
        {
            
            MetroTile btn = sender as MetroTile;
            ucName = btn.Tag.ToString();// xác định button uc nào được click
            switch (ucName)
            {
                case "ucNhanVien":
                    ucNhanVien ucNhanVien = new ucNhanVien();
                    ucNhanVien.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucNhanVien);
                    frmMain.FrmMain.MetroContainer.Controls["ucNhanVien"].BringToFront();
                    break;
                case "ucPhongBan":
                    ucPhongBan ucPhongBan = new ucPhongBan();
                    ucPhongBan.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucPhongBan);
                    frmMain.FrmMain.MetroContainer.Controls["ucPhongBan"].BringToFront();
                    break;
                case "ucDuAn":
                    ucDuAn ucDuAn = new ucDuAn();
                    ucDuAn.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucDuAn);
                    frmMain.FrmMain.MetroContainer.Controls["ucDuAn"].BringToFront();
                    break;
                case "ucThanNhan":
                    ucThanNhan ucThanNhan = new ucThanNhan();
                    ucThanNhan.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucThanNhan);
                    frmMain.FrmMain.MetroContainer.Controls["ucThanNhan"].BringToFront();
                    break;
                case "ucPhanCong":
                    ucPhanCong ucPhanCong = new ucPhanCong();
                    ucPhanCong.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucPhanCong);
                    frmMain.FrmMain.MetroContainer.Controls["ucPhanCong"].BringToFront();
                    break;
                case "ucTangCa":
                    ucTangCa ucTangCa = new ucTangCa();
                    ucTangCa.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucTangCa);
                    frmMain.FrmMain.MetroContainer.Controls["ucTangCa"].BringToFront();
                    break;
                case "ucTraLuong":
                    ucTraLuong ucTraLuong = new ucTraLuong();
                    ucTraLuong.Dock = DockStyle.Fill;
                    frmMain.FrmMain.MetroContainer.Controls.Add(ucTraLuong);
                    frmMain.FrmMain.MetroContainer.Controls["ucTraLuong"].BringToFront();
                    break;
            }
            foreach (ucMenu uc in frmMain.FrmMain.MetroContainer.Controls.OfType<ucMenu>())
            {
                frmMain.FrmMain.MetroContainer.Controls.Remove(uc);
            }
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.FileName = @"D:\VS_2017\QLKTX\QLKTX\HuongDan.txt";
            prc.Start();
        }
    }
}
