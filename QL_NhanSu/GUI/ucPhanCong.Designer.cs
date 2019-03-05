namespace QL_NhanSu.GUI
{
    partial class ucPhanCong
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnHuy = new MetroFramework.Controls.MetroButton();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.btnThem = new MetroFramework.Controls.MetroButton();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.dgvPhanCong = new MetroFramework.Controls.MetroGrid();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btnRefesh = new MetroFramework.Controls.MetroButton();
            this.btnXoa = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.txtSoGio = new System.Windows.Forms.TextBox();
            this.cboDuAn = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.cboMaNhanVien = new MetroFramework.Controls.MetroComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            this.metroPanel4.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QL_NhanSu.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(352, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(41, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(301, 42);
            this.txtSearch.TabIndex = 8;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnHuy.Location = new System.Drawing.Point(1089, 14);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(137, 43);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseCustomBackColor = true;
            this.btnHuy.UseCustomForeColor = true;
            this.btnHuy.UseSelectable = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCapNhat.Location = new System.Drawing.Point(755, 14);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(137, 43);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseCustomBackColor = true;
            this.btnCapNhat.UseCustomForeColor = true;
            this.btnCapNhat.UseSelectable = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnThem.Location = new System.Drawing.Point(583, 14);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 43);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseCustomBackColor = true;
            this.btnThem.UseCustomForeColor = true;
            this.btnThem.UseSelectable = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.dgvPhanCong);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 12;
            this.metroPanel5.Location = new System.Drawing.Point(0, 77);
            this.metroPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(1250, 556);
            this.metroPanel5.TabIndex = 6;
            this.metroPanel5.UseCustomBackColor = true;
            this.metroPanel5.UseCustomForeColor = true;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 13;
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.AllowUserToResizeRows = false;
            this.dgvPhanCong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPhanCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhanCong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPhanCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhanCong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhanCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanCong.EnableHeadersVisualStyles = false;
            this.dgvPhanCong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPhanCong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPhanCong.Location = new System.Drawing.Point(0, 0);
            this.dgvPhanCong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhanCong.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhanCong.RowHeadersVisible = false;
            this.dgvPhanCong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanCong.Size = new System.Drawing.Size(1250, 556);
            this.dgvPhanCong.TabIndex = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.btnRefesh);
            this.metroPanel4.Controls.Add(this.pictureBox2);
            this.metroPanel4.Controls.Add(this.txtSearch);
            this.metroPanel4.Controls.Add(this.btnHuy);
            this.metroPanel4.Controls.Add(this.btnCapNhat);
            this.metroPanel4.Controls.Add(this.btnXoa);
            this.metroPanel4.Controls.Add(this.btnThem);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 12;
            this.metroPanel4.Location = new System.Drawing.Point(0, 0);
            this.metroPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1250, 77);
            this.metroPanel4.TabIndex = 5;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.UseCustomForeColor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 13;
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnRefesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefesh.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRefesh.Location = new System.Drawing.Point(427, 14);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(137, 43);
            this.btnRefesh.TabIndex = 9;
            this.btnRefesh.Text = "Làm mới";
            this.btnRefesh.UseCustomBackColor = true;
            this.btnRefesh.UseCustomForeColor = true;
            this.btnRefesh.UseSelectable = true;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnXoa.Location = new System.Drawing.Point(921, 14);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(137, 43);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseCustomBackColor = true;
            this.btnXoa.UseCustomForeColor = true;
            this.btnXoa.UseSelectable = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroPanel5);
            this.metroPanel3.Controls.Add(this.metroPanel4);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.ForeColor = System.Drawing.Color.White;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 12;
            this.metroPanel3.Location = new System.Drawing.Point(543, 4);
            this.metroPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1250, 633);
            this.metroPanel3.TabIndex = 1;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.UseCustomForeColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 13;
            // 
            // txtSoGio
            // 
            this.txtSoGio.Location = new System.Drawing.Point(204, 174);
            this.txtSoGio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoGio.Name = "txtSoGio";
            this.txtSoGio.Size = new System.Drawing.Size(271, 22);
            this.txtSoGio.TabIndex = 3;
            // 
            // cboDuAn
            // 
            this.cboDuAn.FormattingEnabled = true;
            this.cboDuAn.ItemHeight = 24;
            this.cboDuAn.Location = new System.Drawing.Point(204, 103);
            this.cboDuAn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDuAn.Name = "cboDuAn";
            this.cboDuAn.Size = new System.Drawing.Size(271, 30);
            this.cboDuAn.TabIndex = 2;
            this.cboDuAn.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(33, 174);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(123, 20);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Số Giờ Tham Gia:";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(33, 103);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Mã dự án:";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(33, 44);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Mã nhân viên:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.cboMaNhanVien);
            this.metroPanel2.Controls.Add(this.txtSoGio);
            this.metroPanel2.Controls.Add(this.cboDuAn);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 12;
            this.metroPanel2.Location = new System.Drawing.Point(4, 4);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(531, 633);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 13;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.ItemHeight = 24;
            this.cboMaNhanVien.Location = new System.Drawing.Point(204, 34);
            this.cboMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(271, 30);
            this.cboMaNhanVien.TabIndex = 1;
            this.cboMaNhanVien.UseSelectable = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.metroPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 86);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1797, 641);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Image = global::QL_NhanSu.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(1733, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.metroLabel1.Size = new System.Drawing.Size(162, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Phân Công Dự Án";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_NhanSu.Properties.Resources.PhanCong;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(531, 78);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1797, 86);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ucPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucPhanCong";
            this.Size = new System.Drawing.Size(1797, 727);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnHuy;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private MetroFramework.Controls.MetroButton btnThem;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroGrid dgvPhanCong;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton btnXoa;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.TextBox txtSoGio;
        private MetroFramework.Controls.MetroComboBox cboDuAn;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox btnBack;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnRefesh;
        private MetroFramework.Controls.MetroComboBox cboMaNhanVien;
    }
}
