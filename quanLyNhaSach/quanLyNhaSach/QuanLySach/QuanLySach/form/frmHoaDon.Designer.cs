namespace QuanLySach
{
    partial class frmHoaDon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCTHD = new System.Windows.Forms.Button();
            this.dataHoaDon = new System.Windows.Forms.DataGridView();
            this.btnDSHD = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaKhachhang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddCTHD = new System.Windows.Forms.Button();
            this.btnDeleteAllCT = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtSLB = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labDayMonthYear = new System.Windows.Forms.Label();
            this.labday = new System.Windows.Forms.Label();
            this.labSecons = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddHD = new System.Windows.Forms.Button();
            this.btnDeleteAllHD = new System.Windows.Forms.Button();
            this.txtNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.toolbox = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(429, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(342, 20);
            this.txtSearch.TabIndex = 75;
            this.txtSearch.Text = "Nhập Mã Hóa Đơn Cần Tìm";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // btnCTHD
            // 
            this.btnCTHD.Location = new System.Drawing.Point(268, 515);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(122, 23);
            this.btnCTHD.TabIndex = 74;
            this.btnCTHD.Text = "Xem DS CT  Hóa Đơn";
            this.btnCTHD.UseVisualStyleBackColor = true;
            this.btnCTHD.Click += new System.EventHandler(this.btnCTHD_Click);
            // 
            // dataHoaDon
            // 
            this.dataHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHoaDon.Location = new System.Drawing.Point(421, 103);
            this.dataHoaDon.Name = "dataHoaDon";
            this.dataHoaDon.Size = new System.Drawing.Size(451, 385);
            this.dataHoaDon.TabIndex = 73;
            this.dataHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHoaDon_CellClick);
            // 
            // btnDSHD
            // 
            this.btnDSHD.Location = new System.Drawing.Point(123, 515);
            this.btnDSHD.Name = "btnDSHD";
            this.btnDSHD.Size = new System.Drawing.Size(121, 23);
            this.btnDSHD.TabIndex = 72;
            this.btnDSHD.Text = "Xem DS Hóa Đơn";
            this.btnDSHD.UseVisualStyleBackColor = true;
            this.btnDSHD.Click += new System.EventHandler(this.btnDSHD_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaKhachhang);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnAddCTHD);
            this.groupBox2.Controls.Add(this.btnDeleteAllCT);
            this.groupBox2.Controls.Add(this.txtGiaBan);
            this.groupBox2.Controls.Add(this.txtSLB);
            this.groupBox2.Controls.Add(this.txtMaSach);
            this.groupBox2.Controls.Add(this.txtMaCTHD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 261);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // txtMaKhachhang
            // 
            this.txtMaKhachhang.Location = new System.Drawing.Point(139, 185);
            this.txtMaKhachhang.Name = "txtMaKhachhang";
            this.txtMaKhachhang.Size = new System.Drawing.Size(207, 20);
            this.txtMaKhachhang.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Khách Hàng ";
            // 
            // btnAddCTHD
            // 
            this.btnAddCTHD.Image = global::QuanLySach.Properties.Resources.add_25px;
            this.btnAddCTHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCTHD.Location = new System.Drawing.Point(194, 225);
            this.btnAddCTHD.Name = "btnAddCTHD";
            this.btnAddCTHD.Size = new System.Drawing.Size(134, 30);
            this.btnAddCTHD.TabIndex = 76;
            this.btnAddCTHD.Text = "Thêm CT Hóa Đơn";
            this.btnAddCTHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCTHD.UseVisualStyleBackColor = true;
            this.btnAddCTHD.Click += new System.EventHandler(this.btnAddCTHD_Click);
            // 
            // btnDeleteAllCT
            // 
            this.btnDeleteAllCT.Image = global::QuanLySach.Properties.Resources.delete_25px;
            this.btnDeleteAllCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllCT.Location = new System.Drawing.Point(64, 225);
            this.btnDeleteAllCT.Name = "btnDeleteAllCT";
            this.btnDeleteAllCT.Size = new System.Drawing.Size(86, 30);
            this.btnDeleteAllCT.TabIndex = 75;
            this.btnDeleteAllCT.Text = "Delete All ";
            this.btnDeleteAllCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllCT.UseVisualStyleBackColor = true;
            this.btnDeleteAllCT.Click += new System.EventHandler(this.btnDeleteAllCT_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(139, 147);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(207, 20);
            this.txtGiaBan.TabIndex = 72;
            // 
            // txtSLB
            // 
            this.txtSLB.Location = new System.Drawing.Point(139, 107);
            this.txtSLB.Name = "txtSLB";
            this.txtSLB.Size = new System.Drawing.Size(207, 20);
            this.txtSLB.TabIndex = 71;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(139, 67);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(207, 20);
            this.txtMaSach.TabIndex = 70;
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.Location = new System.Drawing.Point(139, 27);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(207, 20);
            this.txtMaCTHD.TabIndex = 69;
            this.txtMaCTHD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMaCTHD_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Giá Bán ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Số Lượng Bán";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Mã Sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Mã Hóa Đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ngày Bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Mã Hóa Đơn ";
            // 
            // labDayMonthYear
            // 
            this.labDayMonthYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDayMonthYear.AutoSize = true;
            this.labDayMonthYear.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDayMonthYear.Location = new System.Drawing.Point(773, 16);
            this.labDayMonthYear.Name = "labDayMonthYear";
            this.labDayMonthYear.Size = new System.Drawing.Size(99, 21);
            this.labDayMonthYear.TabIndex = 69;
            this.labDayMonthYear.Text = "DayMonthYear";
            // 
            // labday
            // 
            this.labday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labday.AutoSize = true;
            this.labday.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labday.Location = new System.Drawing.Point(703, 16);
            this.labday.Name = "labday";
            this.labday.Size = new System.Drawing.Size(33, 21);
            this.labday.TabIndex = 68;
            this.labday.Text = "Day";
            // 
            // labSecons
            // 
            this.labSecons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labSecons.AutoSize = true;
            this.labSecons.Location = new System.Drawing.Point(662, 22);
            this.labSecons.Name = "labSecons";
            this.labSecons.Size = new System.Drawing.Size(17, 13);
            this.labSecons.TabIndex = 67;
            this.labSecons.Text = "ss";
            // 
            // labTime
            // 
            this.labTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(619, 16);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(58, 21);
            this.labTime.TabIndex = 66;
            this.labTime.Text = "HH:mm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 65;
            this.label1.Text = "Hóa Đơn Bán Hàng ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddHD);
            this.groupBox1.Controls.Add(this.btnDeleteAllHD);
            this.groupBox1.Controls.Add(this.txtNgayBan);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 163);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // btnAddHD
            // 
            this.btnAddHD.Image = global::QuanLySach.Properties.Resources.add_25px;
            this.btnAddHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddHD.Location = new System.Drawing.Point(212, 114);
            this.btnAddHD.Name = "btnAddHD";
            this.btnAddHD.Size = new System.Drawing.Size(116, 30);
            this.btnAddHD.TabIndex = 74;
            this.btnAddHD.Text = "Thêm Hóa Đơn";
            this.btnAddHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddHD.UseVisualStyleBackColor = true;
            this.btnAddHD.Click += new System.EventHandler(this.btnAddHD_Click);
            // 
            // btnDeleteAllHD
            // 
            this.btnDeleteAllHD.Image = global::QuanLySach.Properties.Resources.delete_25px;
            this.btnDeleteAllHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllHD.Location = new System.Drawing.Point(64, 114);
            this.btnDeleteAllHD.Name = "btnDeleteAllHD";
            this.btnDeleteAllHD.Size = new System.Drawing.Size(86, 30);
            this.btnDeleteAllHD.TabIndex = 73;
            this.btnDeleteAllHD.Text = "Delete All ";
            this.btnDeleteAllHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllHD.UseVisualStyleBackColor = true;
            this.btnDeleteAllHD.Click += new System.EventHandler(this.btnDeleteAllHD_Click);
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.CustomFormat = "dd/MM/yyyy";
            this.txtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayBan.Location = new System.Drawing.Point(133, 67);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(213, 20);
            this.txtNgayBan.TabIndex = 72;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(133, 28);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(213, 20);
            this.txtMaHD.TabIndex = 69;
            this.txtMaHD.TextChanged += new System.EventHandler(this.txtMaHD_TextChanged);
            // 
            // toolbox
            // 
            this.toolbox.Controls.Add(this.btnXoa);
            this.toolbox.Controls.Add(this.btnCapNhat);
            this.toolbox.Location = new System.Drawing.Point(416, 495);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(456, 54);
            this.toolbox.TabIndex = 78;
            this.toolbox.TabStop = false;
            this.toolbox.Text = "ToolBox";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLySach.Properties.Resources.delete_25px;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(134, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 23);
            this.btnXoa.TabIndex = 62;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Image = global::QuanLySach.Properties.Resources.available_updates_20px;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(6, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(122, 23);
            this.btnCapNhat.TabIndex = 61;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // Exit
            // 
            this.Exit.Image = global::QuanLySach.Properties.Resources.exit;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(16, 515);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(91, 23);
            this.Exit.TabIndex = 77;
            this.Exit.Text = "Bán Hàng";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::QuanLySach.Properties.Resources.icons8_search_16;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(781, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 23);
            this.btnSearch.TabIndex = 76;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCTHD);
            this.Controls.Add(this.dataHoaDon);
            this.Controls.Add(this.btnDSHD);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labDayMonthYear);
            this.Controls.Add(this.labday);
            this.Controls.Add(this.labSecons);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(884, 561);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCTHD;
        private System.Windows.Forms.DataGridView dataHoaDon;
        private System.Windows.Forms.Button btnDSHD;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCTHD;
        private System.Windows.Forms.Button btnDeleteAllCT;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtSLB;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaCTHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labDayMonthYear;
        private System.Windows.Forms.Label labday;
        private System.Windows.Forms.Label labSecons;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddHD;
        private System.Windows.Forms.Button btnDeleteAllHD;
        private System.Windows.Forms.DateTimePicker txtNgayBan;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox toolbox;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMaKhachhang;
        private System.Windows.Forms.Label label5;
    }
}