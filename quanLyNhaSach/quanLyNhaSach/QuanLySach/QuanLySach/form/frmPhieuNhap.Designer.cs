namespace QuanLySach
{
    partial class frmPhieuNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.labDayMonthYear = new System.Windows.Forms.Label();
            this.labday = new System.Windows.Forms.Label();
            this.labSecons = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddPN = new System.Windows.Forms.Button();
            this.btnDeleteAllPN = new System.Windows.Forms.Button();
            this.txtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddCTPN = new System.Windows.Forms.Button();
            this.btnDeleteAllCT = new System.Windows.Forms.Button();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSLN = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaCTPN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDSPN = new System.Windows.Forms.Button();
            this.dataPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnCTPN = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.toolbox = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuNhap)).BeginInit();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "Phiếu Nhập Kho ";
            // 
            // labDayMonthYear
            // 
            this.labDayMonthYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDayMonthYear.AutoSize = true;
            this.labDayMonthYear.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDayMonthYear.Location = new System.Drawing.Point(773, 9);
            this.labDayMonthYear.Name = "labDayMonthYear";
            this.labDayMonthYear.Size = new System.Drawing.Size(99, 21);
            this.labDayMonthYear.TabIndex = 57;
            this.labDayMonthYear.Text = "DayMonthYear";
            // 
            // labday
            // 
            this.labday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labday.AutoSize = true;
            this.labday.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labday.Location = new System.Drawing.Point(703, 9);
            this.labday.Name = "labday";
            this.labday.Size = new System.Drawing.Size(33, 21);
            this.labday.TabIndex = 56;
            this.labday.Text = "Day";
            // 
            // labSecons
            // 
            this.labSecons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labSecons.AutoSize = true;
            this.labSecons.Location = new System.Drawing.Point(662, 15);
            this.labSecons.Name = "labSecons";
            this.labSecons.Size = new System.Drawing.Size(17, 13);
            this.labSecons.TabIndex = 55;
            this.labSecons.Text = "ss";
            // 
            // labTime
            // 
            this.labTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(619, 9);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(58, 21);
            this.labTime.TabIndex = 54;
            this.labTime.Text = "HH:mm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddPN);
            this.groupBox1.Controls.Add(this.btnDeleteAllPN);
            this.groupBox1.Controls.Add(this.txtNgayNhap);
            this.groupBox1.Controls.Add(this.txtMaNXB);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 195);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập";
            // 
            // btnAddPN
            // 
            this.btnAddPN.Image = global::QuanLySach.Properties.Resources.add_25px;
            this.btnAddPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPN.Location = new System.Drawing.Point(212, 153);
            this.btnAddPN.Name = "btnAddPN";
            this.btnAddPN.Size = new System.Drawing.Size(134, 23);
            this.btnAddPN.TabIndex = 74;
            this.btnAddPN.Text = "Thêm Phiếu Nhập";
            this.btnAddPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPN.UseVisualStyleBackColor = true;
            this.btnAddPN.Click += new System.EventHandler(this.btnAddPN_Click);
            // 
            // btnDeleteAllPN
            // 
            this.btnDeleteAllPN.Image = global::QuanLySach.Properties.Resources.delete_25px;
            this.btnDeleteAllPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllPN.Location = new System.Drawing.Point(64, 153);
            this.btnDeleteAllPN.Name = "btnDeleteAllPN";
            this.btnDeleteAllPN.Size = new System.Drawing.Size(83, 23);
            this.btnDeleteAllPN.TabIndex = 73;
            this.btnDeleteAllPN.Text = "Delete All ";
            this.btnDeleteAllPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllPN.UseVisualStyleBackColor = true;
            this.btnDeleteAllPN.Click += new System.EventHandler(this.btnDeleteAllPN_Click);
            // 
            // txtNgayNhap
            // 
            this.txtNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.txtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayNhap.Location = new System.Drawing.Point(133, 67);
            this.txtNgayNhap.Name = "txtNgayNhap";
            this.txtNgayNhap.Size = new System.Drawing.Size(213, 20);
            this.txtNgayNhap.TabIndex = 72;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(133, 108);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(213, 20);
            this.txtMaNXB.TabIndex = 71;
            // 
            // txtMaPN
            // 
            this.txtMaPN.Location = new System.Drawing.Point(133, 28);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(213, 20);
            this.txtMaPN.TabIndex = 69;
            this.txtMaPN.TextChanged += new System.EventHandler(this.txtMaPN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "Mã Nhà Xuất Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ngày Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Mã Phiếu Nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddCTPN);
            this.groupBox2.Controls.Add(this.btnDeleteAllCT);
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.txtSLN);
            this.groupBox2.Controls.Add(this.txtMaSach);
            this.groupBox2.Controls.Add(this.txtMaCTPN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 240);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // btnAddCTPN
            // 
            this.btnAddCTPN.Image = global::QuanLySach.Properties.Resources.add_25px;
            this.btnAddCTPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCTPN.Location = new System.Drawing.Point(194, 186);
            this.btnAddCTPN.Name = "btnAddCTPN";
            this.btnAddCTPN.Size = new System.Drawing.Size(152, 23);
            this.btnAddCTPN.TabIndex = 76;
            this.btnAddCTPN.Text = "Thêm CT Phiếu Nhập";
            this.btnAddCTPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCTPN.UseVisualStyleBackColor = true;
            this.btnAddCTPN.Click += new System.EventHandler(this.btnAddCTPN_Click);
            // 
            // btnDeleteAllCT
            // 
            this.btnDeleteAllCT.Image = global::QuanLySach.Properties.Resources.delete_25px;
            this.btnDeleteAllCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAllCT.Location = new System.Drawing.Point(64, 186);
            this.btnDeleteAllCT.Name = "btnDeleteAllCT";
            this.btnDeleteAllCT.Size = new System.Drawing.Size(83, 23);
            this.btnDeleteAllCT.TabIndex = 75;
            this.btnDeleteAllCT.Text = "Delete All ";
            this.btnDeleteAllCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAllCT.UseVisualStyleBackColor = true;
            this.btnDeleteAllCT.Click += new System.EventHandler(this.btnDeleteAllCT_Click);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(139, 147);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(207, 20);
            this.txtGiaNhap.TabIndex = 72;
            // 
            // txtSLN
            // 
            this.txtSLN.Location = new System.Drawing.Point(139, 107);
            this.txtSLN.Name = "txtSLN";
            this.txtSLN.Size = new System.Drawing.Size(207, 20);
            this.txtSLN.TabIndex = 71;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(139, 67);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(207, 20);
            this.txtMaSach.TabIndex = 70;
            // 
            // txtMaCTPN
            // 
            this.txtMaCTPN.Location = new System.Drawing.Point(139, 27);
            this.txtMaCTPN.Name = "txtMaCTPN";
            this.txtMaCTPN.Size = new System.Drawing.Size(207, 20);
            this.txtMaCTPN.TabIndex = 69;
            this.txtMaCTPN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMaCTPN_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Giá Nhập";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Số Lượng Nhập";
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
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Mã Phiếu Nhập";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDSPN
            // 
            this.btnDSPN.Location = new System.Drawing.Point(109, 517);
            this.btnDSPN.Name = "btnDSPN";
            this.btnDSPN.Size = new System.Drawing.Size(122, 23);
            this.btnDSPN.TabIndex = 60;
            this.btnDSPN.Text = "Xem DS Phiếu Nhập";
            this.btnDSPN.UseVisualStyleBackColor = true;
            this.btnDSPN.Click += new System.EventHandler(this.btnDSPN_Click);
            // 
            // dataPhieuNhap
            // 
            this.dataPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhieuNhap.Location = new System.Drawing.Point(416, 80);
            this.dataPhieuNhap.Name = "dataPhieuNhap";
            this.dataPhieuNhap.Size = new System.Drawing.Size(464, 396);
            this.dataPhieuNhap.TabIndex = 61;
            this.dataPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPhieuNhap_CellClick);
            // 
            // btnCTPN
            // 
            this.btnCTPN.Location = new System.Drawing.Point(237, 517);
            this.btnCTPN.Name = "btnCTPN";
            this.btnCTPN.Size = new System.Drawing.Size(149, 23);
            this.btnCTPN.TabIndex = 62;
            this.btnCTPN.Text = "Xem DS CT  Phiếu Nhập";
            this.btnCTPN.UseVisualStyleBackColor = true;
            this.btnCTPN.Click += new System.EventHandler(this.btnCTPN_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(781, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 23);
            this.btnSearch.TabIndex = 64;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(416, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(355, 20);
            this.txtSearch.TabIndex = 63;
            this.txtSearch.Text = "Nhập Mã Phiếu Nhập Cần Tìm";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            // 
            // Exit
            // 
            this.Exit.Image = global::QuanLySach.Properties.Resources.exit;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(12, 517);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(91, 23);
            this.Exit.TabIndex = 65;
            this.Exit.Text = "Bán Hàng";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // toolbox
            // 
            this.toolbox.Controls.Add(this.btnXoa);
            this.toolbox.Controls.Add(this.btnCapNhat);
            this.toolbox.Location = new System.Drawing.Point(416, 495);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(456, 54);
            this.toolbox.TabIndex = 66;
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
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCTPN);
            this.Controls.Add(this.dataPhieuNhap);
            this.Controls.Add(this.btnDSPN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labDayMonthYear);
            this.Controls.Add(this.labday);
            this.Controls.Add(this.labSecons);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhieuNhap)).EndInit();
            this.toolbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDayMonthYear;
        private System.Windows.Forms.Label labday;
        private System.Windows.Forms.Label labSecons;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddPN;
        private System.Windows.Forms.Button btnDeleteAllPN;
        private System.Windows.Forms.DateTimePicker txtNgayNhap;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCTPN;
        private System.Windows.Forms.Button btnDeleteAllCT;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtSLN;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaCTPN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDSPN;
        private System.Windows.Forms.DataGridView dataPhieuNhap;
        private System.Windows.Forms.Button btnCTPN;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox toolbox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
    }
}