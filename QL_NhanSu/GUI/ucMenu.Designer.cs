namespace QL_NhanSu.GUI
{
    partial class ucMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnHuongDan = new MetroFramework.Controls.MetroTile();
            this.btnTraLuong = new MetroFramework.Controls.MetroTile();
            this.btnTangCa = new MetroFramework.Controls.MetroTile();
            this.btnPhongBan = new MetroFramework.Controls.MetroTile();
            this.btnPhanCong = new MetroFramework.Controls.MetroTile();
            this.btnThanNhan = new MetroFramework.Controls.MetroTile();
            this.btnDuAn = new MetroFramework.Controls.MetroTile();
            this.btnNhanVien = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 711);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnHuongDan);
            this.metroPanel1.Controls.Add(this.btnTraLuong);
            this.metroPanel1.Controls.Add(this.btnTangCa);
            this.metroPanel1.Controls.Add(this.btnPhongBan);
            this.metroPanel1.Controls.Add(this.btnPhanCong);
            this.metroPanel1.Controls.Add(this.btnThanNhan);
            this.metroPanel1.Controls.Add(this.btnDuAn);
            this.metroPanel1.Controls.Add(this.btnNhanVien);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(76, 12);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(872, 686);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.ActiveControl = null;
            this.btnHuongDan.BackColor = System.Drawing.Color.Teal;
            this.btnHuongDan.ForeColor = System.Drawing.Color.White;
            this.btnHuongDan.Location = new System.Drawing.Point(595, 451);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(246, 164);
            this.btnHuongDan.TabIndex = 6;
            this.btnHuongDan.Tag = "";
            this.btnHuongDan.Text = "Hướng dẫn";
            this.btnHuongDan.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHuongDan.TileImage = global::QL_NhanSu.Properties.Resources._5627cd21bd54f17f49cc212c_Icon_lamp;
            this.btnHuongDan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHuongDan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnHuongDan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnHuongDan.UseCustomBackColor = true;
            this.btnHuongDan.UseCustomForeColor = true;
            this.btnHuongDan.UseSelectable = true;
            this.btnHuongDan.UseTileImage = true;
            this.btnHuongDan.Click += new System.EventHandler(this.btnHuongDan_Click);
            // 
            // btnTraLuong
            // 
            this.btnTraLuong.ActiveControl = null;
            this.btnTraLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTraLuong.ForeColor = System.Drawing.Color.White;
            this.btnTraLuong.Location = new System.Drawing.Point(43, 451);
            this.btnTraLuong.Name = "btnTraLuong";
            this.btnTraLuong.Size = new System.Drawing.Size(518, 164);
            this.btnTraLuong.TabIndex = 4;
            this.btnTraLuong.Tag = "ucTraLuong";
            this.btnTraLuong.Text = "Thanh toán lương";
            this.btnTraLuong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTraLuong.TileImage = global::QL_NhanSu.Properties.Resources.loan_lending;
            this.btnTraLuong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTraLuong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnTraLuong.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnTraLuong.UseCustomBackColor = true;
            this.btnTraLuong.UseCustomForeColor = true;
            this.btnTraLuong.UseSelectable = true;
            this.btnTraLuong.UseTileImage = true;
            this.btnTraLuong.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTangCa
            // 
            this.btnTangCa.ActiveControl = null;
            this.btnTangCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTangCa.ForeColor = System.Drawing.Color.White;
            this.btnTangCa.Location = new System.Drawing.Point(595, 259);
            this.btnTangCa.Margin = new System.Windows.Forms.Padding(4);
            this.btnTangCa.Name = "btnTangCa";
            this.btnTangCa.Size = new System.Drawing.Size(246, 164);
            this.btnTangCa.TabIndex = 3;
            this.btnTangCa.Tag = "ucTangCa";
            this.btnTangCa.Text = "Làm tăng ca";
            this.btnTangCa.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnTangCa.TileImage = global::QL_NhanSu.Properties.Resources.icon_relogio;
            this.btnTangCa.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTangCa.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnTangCa.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnTangCa.UseCustomBackColor = true;
            this.btnTangCa.UseCustomForeColor = true;
            this.btnTangCa.UseSelectable = true;
            this.btnTangCa.UseTileImage = true;
            this.btnTangCa.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPhongBan
            // 
            this.btnPhongBan.ActiveControl = null;
            this.btnPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(53)))), ((int)(((byte)(174)))));
            this.btnPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnPhongBan.Location = new System.Drawing.Point(315, 70);
            this.btnPhongBan.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.Size = new System.Drawing.Size(246, 164);
            this.btnPhongBan.TabIndex = 2;
            this.btnPhongBan.Tag = "ucPhongBan";
            this.btnPhongBan.Text = "Phòng Ban";
            this.btnPhongBan.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPhongBan.TileImage = global::QL_NhanSu.Properties.Resources.PhongBan;
            this.btnPhongBan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhongBan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnPhongBan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnPhongBan.UseCustomBackColor = true;
            this.btnPhongBan.UseCustomForeColor = true;
            this.btnPhongBan.UseSelectable = true;
            this.btnPhongBan.UseTileImage = true;
            this.btnPhongBan.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.ActiveControl = null;
            this.btnPhanCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(85)))), ((int)(((byte)(45)))));
            this.btnPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnPhanCong.Location = new System.Drawing.Point(43, 259);
            this.btnPhanCong.Margin = new System.Windows.Forms.Padding(4);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(246, 164);
            this.btnPhanCong.TabIndex = 2;
            this.btnPhanCong.Tag = "ucPhanCong";
            this.btnPhanCong.Text = "Phân Công Dự Án";
            this.btnPhanCong.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnPhanCong.TileImage = global::QL_NhanSu.Properties.Resources.PhanCong;
            this.btnPhanCong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhanCong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnPhanCong.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnPhanCong.UseCustomBackColor = true;
            this.btnPhanCong.UseCustomForeColor = true;
            this.btnPhanCong.UseSelectable = true;
            this.btnPhanCong.UseTileImage = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnThanNhan
            // 
            this.btnThanNhan.ActiveControl = null;
            this.btnThanNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnThanNhan.ForeColor = System.Drawing.Color.White;
            this.btnThanNhan.Location = new System.Drawing.Point(315, 259);
            this.btnThanNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanNhan.Name = "btnThanNhan";
            this.btnThanNhan.Size = new System.Drawing.Size(246, 164);
            this.btnThanNhan.TabIndex = 2;
            this.btnThanNhan.Tag = "ucThanNhan";
            this.btnThanNhan.Text = "Thân Nhân";
            this.btnThanNhan.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnThanNhan.TileImage = global::QL_NhanSu.Properties.Resources.ThanNhan;
            this.btnThanNhan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThanNhan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnThanNhan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnThanNhan.UseCustomBackColor = true;
            this.btnThanNhan.UseCustomForeColor = true;
            this.btnThanNhan.UseSelectable = true;
            this.btnThanNhan.UseTileImage = true;
            this.btnThanNhan.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDuAn
            // 
            this.btnDuAn.ActiveControl = null;
            this.btnDuAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(133)))), ((int)(((byte)(238)))));
            this.btnDuAn.ForeColor = System.Drawing.Color.White;
            this.btnDuAn.Location = new System.Drawing.Point(595, 70);
            this.btnDuAn.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuAn.Name = "btnDuAn";
            this.btnDuAn.Size = new System.Drawing.Size(246, 164);
            this.btnDuAn.TabIndex = 2;
            this.btnDuAn.Tag = "ucDuAn";
            this.btnDuAn.Text = "Dự Án";
            this.btnDuAn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDuAn.TileImage = global::QL_NhanSu.Properties.Resources.DuAn;
            this.btnDuAn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDuAn.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDuAn.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnDuAn.UseCustomBackColor = true;
            this.btnDuAn.UseCustomForeColor = true;
            this.btnDuAn.UseSelectable = true;
            this.btnDuAn.UseTileImage = true;
            this.btnDuAn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.ActiveControl = null;
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(141)))), ((int)(((byte)(23)))));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(43, 70);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(246, 164);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Tag = "ucNhanVien";
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNhanVien.TileImage = global::QL_NhanSu.Properties.Resources.NhanVien;
            this.btnNhanVien.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanVien.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnNhanVien.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.btnNhanVien.UseCustomBackColor = true;
            this.btnNhanVien.UseCustomForeColor = true;
            this.btnNhanVien.UseSelectable = true;
            this.btnNhanVien.UseTileImage = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btn_Click);
            // 
            // ucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucMenu";
            this.Size = new System.Drawing.Size(1024, 711);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnPhongBan;
        private MetroFramework.Controls.MetroTile btnPhanCong;
        private MetroFramework.Controls.MetroTile btnThanNhan;
        private MetroFramework.Controls.MetroTile btnDuAn;
        private MetroFramework.Controls.MetroTile btnNhanVien;
        private MetroFramework.Controls.MetroTile btnTraLuong;
        private MetroFramework.Controls.MetroTile btnHuongDan;
        private MetroFramework.Controls.MetroTile btnTangCa;
    }
}
