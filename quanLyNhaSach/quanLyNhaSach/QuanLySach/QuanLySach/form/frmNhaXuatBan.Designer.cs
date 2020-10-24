namespace QuanLySach
{
    partial class frmNhaXuatBan
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
            this.btnXoaAll = new System.Windows.Forms.Button();
            this.btnAddNXB = new System.Windows.Forms.Button();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.labDayMonthYear = new System.Windows.Forms.Label();
            this.labday = new System.Windows.Forms.Label();
            this.labSecons = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DataNXBTable = new System.Windows.Forms.DataGridView();
            this.MaNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolbox = new System.Windows.Forms.GroupBox();
            this.btnDelete = new ns1.BunifuFlatButton();
            this.btnCapNhat = new ns1.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataNXBTable)).BeginInit();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoaAll
            // 
            this.btnXoaAll.Image = global::QuanLySach.Properties.Resources.delete_25px;
            this.btnXoaAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaAll.Location = new System.Drawing.Point(66, 287);
            this.btnXoaAll.Name = "btnXoaAll";
            this.btnXoaAll.Size = new System.Drawing.Size(99, 30);
            this.btnXoaAll.TabIndex = 45;
            this.btnXoaAll.Text = "Xóa Tất Cả";
            this.btnXoaAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaAll.UseVisualStyleBackColor = true;
            this.btnXoaAll.Click += new System.EventHandler(this.btnXoaAll_Click);
            // 
            // btnAddNXB
            // 
            this.btnAddNXB.Image = global::QuanLySach.Properties.Resources.add_25px;
            this.btnAddNXB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNXB.Location = new System.Drawing.Point(257, 287);
            this.btnAddNXB.Name = "btnAddNXB";
            this.btnAddNXB.Size = new System.Drawing.Size(92, 30);
            this.btnAddNXB.TabIndex = 44;
            this.btnAddNXB.Text = "Thêm NXB";
            this.btnAddNXB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNXB.UseVisualStyleBackColor = true;
            this.btnAddNXB.Click += new System.EventHandler(this.btnAddNXB_Click);
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(157, 234);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(217, 20);
            this.txtDT.TabIndex = 41;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(157, 194);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(217, 20);
            this.txtDiaChi.TabIndex = 40;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(157, 154);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(217, 20);
            this.txtTenNXB.TabIndex = 39;
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(157, 114);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(217, 20);
            this.txtMaNXB.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Điện Thoại ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tên NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mã NXB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Thông Tin Nhà Xuất Bản";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Địa Chỉ";
            // 
            // labDayMonthYear
            // 
            this.labDayMonthYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDayMonthYear.AutoSize = true;
            this.labDayMonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDayMonthYear.Location = new System.Drawing.Point(765, 17);
            this.labDayMonthYear.Name = "labDayMonthYear";
            this.labDayMonthYear.Size = new System.Drawing.Size(128, 20);
            this.labDayMonthYear.TabIndex = 30;
            this.labDayMonthYear.Text = "DayMonthYear";
            // 
            // labday
            // 
            this.labday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labday.AutoSize = true;
            this.labday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labday.Location = new System.Drawing.Point(706, 17);
            this.labday.Name = "labday";
            this.labday.Size = new System.Drawing.Size(40, 20);
            this.labday.TabIndex = 29;
            this.labday.Text = "Day";
            // 
            // labSecons
            // 
            this.labSecons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labSecons.AutoSize = true;
            this.labSecons.Location = new System.Drawing.Point(665, 23);
            this.labSecons.Name = "labSecons";
            this.labSecons.Size = new System.Drawing.Size(17, 13);
            this.labSecons.TabIndex = 28;
            this.labSecons.Text = "ss";
            // 
            // labTime
            // 
            this.labTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(622, 17);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(68, 20);
            this.labTime.TabIndex = 27;
            this.labTime.Text = "HH:mm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Danh Sách Nhà Xuất Bản";
            // 
            // Exit
            // 
            this.Exit.Image = global::QuanLySach.Properties.Resources.exit;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(21, 527);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(85, 23);
            this.Exit.TabIndex = 25;
            this.Exit.Text = "Bán Hàng";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(775, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 23);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(424, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 20);
            this.txtSearch.TabIndex = 46;
            this.txtSearch.Text = "Nhập Mã Nhà Xuất Bản Cần Tìm";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            // 
            // DataNXBTable
            // 
            this.DataNXBTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNXBTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNXB,
            this.TenNXB,
            this.DiaChiNXB,
            this.DienThoai});
            this.DataNXBTable.Location = new System.Drawing.Point(426, 114);
            this.DataNXBTable.Name = "DataNXBTable";
            this.DataNXBTable.Size = new System.Drawing.Size(446, 435);
            this.DataNXBTable.TabIndex = 48;
            this.DataNXBTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNXBTable_CellClick);
            // 
            // MaNXB
            // 
            this.MaNXB.DataPropertyName = "MaNXB";
            this.MaNXB.HeaderText = "Mã NXB";
            this.MaNXB.Name = "MaNXB";
            // 
            // TenNXB
            // 
            this.TenNXB.DataPropertyName = "TenNXB";
            this.TenNXB.HeaderText = "Tên NXB";
            this.TenNXB.Name = "TenNXB";
            // 
            // DiaChiNXB
            // 
            this.DiaChiNXB.DataPropertyName = "DiaChiNXB";
            this.DiaChiNXB.HeaderText = "Địa Chỉ";
            this.DiaChiNXB.Name = "DiaChiNXB";
            // 
            // DienThoai
            // 
            this.DienThoai.DataPropertyName = "DienThoai";
            this.DienThoai.HeaderText = "Điện Thoại";
            this.DienThoai.Name = "DienThoai";
            // 
            // toolbox
            // 
            this.toolbox.Controls.Add(this.btnDelete);
            this.toolbox.Controls.Add(this.btnCapNhat);
            this.toolbox.Location = new System.Drawing.Point(46, 337);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(328, 75);
            this.toolbox.TabIndex = 77;
            this.toolbox.TabStop = false;
            this.toolbox.Text = "ToolBox";
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 6;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = global::QuanLySach.Properties.Resources.delete_25px;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 60D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(180, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.LightGray;
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(123, 36);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Textcolor = System.Drawing.Color.Black;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCapNhat.BackColor = System.Drawing.Color.LightGray;
            this.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCapNhat.BorderRadius = 5;
            this.btnCapNhat.ButtonText = "Cập Nhật ";
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.DisabledColor = System.Drawing.Color.Gray;
            this.btnCapNhat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCapNhat.Iconimage = global::QuanLySach.Properties.Resources.available_updates_20px;
            this.btnCapNhat.Iconimage_right = null;
            this.btnCapNhat.Iconimage_right_Selected = null;
            this.btnCapNhat.Iconimage_Selected = null;
            this.btnCapNhat.IconMarginLeft = 0;
            this.btnCapNhat.IconMarginRight = 0;
            this.btnCapNhat.IconRightVisible = true;
            this.btnCapNhat.IconRightZoom = 0D;
            this.btnCapNhat.IconVisible = true;
            this.btnCapNhat.IconZoom = 60D;
            this.btnCapNhat.IsTab = false;
            this.btnCapNhat.Location = new System.Drawing.Point(20, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Normalcolor = System.Drawing.Color.LightGray;
            this.btnCapNhat.OnHovercolor = System.Drawing.Color.Green;
            this.btnCapNhat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCapNhat.selected = false;
            this.btnCapNhat.Size = new System.Drawing.Size(123, 36);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập Nhật ";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Textcolor = System.Drawing.Color.Black;
            this.btnCapNhat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // frmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.DataNXBTable);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnXoaAll);
            this.Controls.Add(this.btnAddNXB);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNXB);
            this.Controls.Add(this.txtMaNXB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labDayMonthYear);
            this.Controls.Add(this.labday);
            this.Controls.Add(this.labSecons);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(884, 561);
            this.Name = "frmNhaXuatBan";
            this.Text = "frmNhaXuatBan";
            this.Load += new System.EventHandler(this.frmNhaXuatBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataNXBTable)).EndInit();
            this.toolbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXoaAll;
        private System.Windows.Forms.Button btnAddNXB;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labDayMonthYear;
        private System.Windows.Forms.Label labday;
        private System.Windows.Forms.Label labSecons;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView DataNXBTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
        private System.Windows.Forms.GroupBox toolbox;
        private ns1.BunifuFlatButton btnDelete;
        private ns1.BunifuFlatButton btnCapNhat;
    }
}