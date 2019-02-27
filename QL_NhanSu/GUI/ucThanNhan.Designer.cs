namespace QL_NhanSu.GUI
{
    partial class ucThanNhan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.dgvThanNhan = new MetroFramework.Controls.MetroGrid();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btnLamMoi = new MetroFramework.Controls.MetroButton();
            this.txtHoTenThanNhan = new System.Windows.Forms.TextBox();
            this.cboMaNhanVien = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtQuanHe = new System.Windows.Forms.TextBox();
            this.radNu = new MetroFramework.Controls.MetroRadioButton();
            this.radNam = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanNhan)).BeginInit();
            this.metroPanel4.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Image = global::QL_NhanSu.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1184, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 78);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnBack.TabIndex = 1;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(127, 27);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Thân Nhân";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(4, 4);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(366, 78);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_NhanSu.Properties.Resources.ThanNhan;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QL_NhanSu.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(352, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(41, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(301, 42);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.UseWaitCursor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnHuy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnHuy.Location = new System.Drawing.Point(1072, 14);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(137, 43);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseCustomBackColor = true;
            this.btnHuy.UseCustomForeColor = true;
            this.btnHuy.UseSelectable = true;
            this.btnHuy.UseWaitCursor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnCapNhat.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCapNhat.Location = new System.Drawing.Point(727, 14);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(137, 43);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseCustomBackColor = true;
            this.btnCapNhat.UseCustomForeColor = true;
            this.btnCapNhat.UseSelectable = true;
            this.btnCapNhat.UseWaitCursor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnXoa.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnXoa.Location = new System.Drawing.Point(894, 14);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 43);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseCustomBackColor = true;
            this.btnXoa.UseCustomForeColor = true;
            this.btnXoa.UseSelectable = true;
            this.btnXoa.UseWaitCursor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnThem.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnThem.Location = new System.Drawing.Point(573, 14);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 43);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseCustomBackColor = true;
            this.btnThem.UseCustomForeColor = true;
            this.btnThem.UseSelectable = true;
            this.btnThem.UseWaitCursor = true;
            // 
            // dgvThanNhan
            // 
            this.dgvThanNhan.AllowUserToResizeRows = false;
            this.dgvThanNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvThanNhan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThanNhan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvThanNhan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThanNhan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThanNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThanNhan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThanNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThanNhan.EnableHeadersVisualStyles = false;
            this.dgvThanNhan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvThanNhan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvThanNhan.Location = new System.Drawing.Point(0, 386);
            this.dgvThanNhan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThanNhan.Name = "dgvThanNhan";
            this.dgvThanNhan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThanNhan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThanNhan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvThanNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanNhan.Size = new System.Drawing.Size(1248, 408);
            this.dgvThanNhan.TabIndex = 16;
            this.dgvThanNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanNhan_CellContentClick);
            // 
            // metroPanel4
            // 
            this.metroPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.btnLamMoi);
            this.metroPanel4.Controls.Add(this.pictureBox2);
            this.metroPanel4.Controls.Add(this.txtSearch);
            this.metroPanel4.Controls.Add(this.btnHuy);
            this.metroPanel4.Controls.Add(this.btnCapNhat);
            this.metroPanel4.Controls.Add(this.btnXoa);
            this.metroPanel4.Controls.Add(this.btnThem);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel4.ForeColor = System.Drawing.Color.White;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 12;
            this.metroPanel4.Location = new System.Drawing.Point(0, 309);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1248, 77);
            this.metroPanel4.TabIndex = 17;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.UseCustomForeColor = true;
            this.metroPanel4.UseStyleColors = true;
            this.metroPanel4.UseWaitCursor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 13;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnLamMoi.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLamMoi.Location = new System.Drawing.Point(419, 14);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(137, 43);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseCustomBackColor = true;
            this.btnLamMoi.UseCustomForeColor = true;
            this.btnLamMoi.UseSelectable = true;
            this.btnLamMoi.UseWaitCursor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtHoTenThanNhan
            // 
            this.txtHoTenThanNhan.Location = new System.Drawing.Point(325, 119);
            this.txtHoTenThanNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenThanNhan.Name = "txtHoTenThanNhan";
            this.txtHoTenThanNhan.Size = new System.Drawing.Size(313, 22);
            this.txtHoTenThanNhan.TabIndex = 5;
            this.txtHoTenThanNhan.UseWaitCursor = true;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.ItemHeight = 24;
            this.cboMaNhanVien.Location = new System.Drawing.Point(325, 48);
            this.cboMaNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(313, 30);
            this.cboMaNhanVien.TabIndex = 4;
            this.cboMaNhanVien.UseSelectable = true;
            this.cboMaNhanVien.UseWaitCursor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(189, 165);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(70, 20);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Quan Hệ:";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.UseWaitCursor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(695, 48);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 20);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Giới Tính:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseWaitCursor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(149, 120);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Tên Thân Nhân:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseWaitCursor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Controls.Add(this.dtpNgaySinh);
            this.metroPanel2.Controls.Add(this.txtQuanHe);
            this.metroPanel2.Controls.Add(this.radNu);
            this.metroPanel2.Controls.Add(this.radNam);
            this.metroPanel2.Controls.Add(this.txtHoTenThanNhan);
            this.metroPanel2.Controls.Add(this.cboMaNhanVien);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.ForeColor = System.Drawing.Color.White;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(0, 86);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1248, 223);
            this.metroPanel2.TabIndex = 15;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.UseWaitCursor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ngày sinh";
            this.label1.UseWaitCursor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(801, 117);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(287, 22);
            this.dtpNgaySinh.TabIndex = 9;
            this.dtpNgaySinh.UseWaitCursor = true;
            // 
            // txtQuanHe
            // 
            this.txtQuanHe.Location = new System.Drawing.Point(325, 165);
            this.txtQuanHe.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuanHe.Name = "txtQuanHe";
            this.txtQuanHe.Size = new System.Drawing.Size(313, 22);
            this.txtQuanHe.TabIndex = 8;
            this.txtQuanHe.UseWaitCursor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(895, 51);
            this.radNu.Margin = new System.Windows.Forms.Padding(4);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(42, 17);
            this.radNu.TabIndex = 7;
            this.radNu.Text = "Nữ";
            this.radNu.UseCustomBackColor = true;
            this.radNu.UseCustomForeColor = true;
            this.radNu.UseSelectable = true;
            this.radNu.UseWaitCursor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(801, 51);
            this.radNam.Margin = new System.Windows.Forms.Padding(4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(52, 17);
            this.radNam.TabIndex = 6;
            this.radNam.Text = "Nam";
            this.radNam.UseCustomBackColor = true;
            this.radNam.UseCustomForeColor = true;
            this.radNam.UseSelectable = true;
            this.radNam.UseWaitCursor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(149, 56);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Mã Nhân Viên:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1248, 86);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // ucThanNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvThanNhan);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucThanNhan";
            this.Size = new System.Drawing.Size(1248, 794);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanNhan)).EndInit();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnBack;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnHuy;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroGrid dgvThanNhan;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private System.Windows.Forms.TextBox txtHoTenThanNhan;
        private MetroFramework.Controls.MetroComboBox cboMaNhanVien;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.TextBox txtQuanHe;
        private MetroFramework.Controls.MetroRadioButton radNu;
        private MetroFramework.Controls.MetroRadioButton radNam;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnLamMoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}
