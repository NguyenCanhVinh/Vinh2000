namespace QuanLySach.form
{
    partial class frmQuanLy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Exit = new System.Windows.Forms.Button();
            this.labDayMonthYear = new System.Windows.Forms.Label();
            this.labday = new System.Windows.Forms.Label();
            this.labSecons = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnSearch = new ns1.BunifuFlatButton();
            this.txtSearch = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.toolbox = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnquanlydangnhap = new System.Windows.Forms.Button();
            this.btnQuanLyKhachHang = new System.Windows.Forms.Button();
            this.btnthongkenhap = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.DateTimePicker();
            this.paNgay = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtend = new System.Windows.Forms.DateTimePicker();
            this.btnFinish = new ns1.BunifuFlatButton();
            this.btnThongKeXuat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.laTongTien = new System.Windows.Forms.Label();
            this.paTong = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.toolbox.SuspendLayout();
            this.paNgay.SuspendLayout();
            this.paTong.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Exit
            // 
            this.Exit.Image = global::QuanLySach.Properties.Resources.exit;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(12, 526);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(91, 23);
            this.Exit.TabIndex = 44;
            this.Exit.Text = "Bán Hàng";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
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
            this.labDayMonthYear.TabIndex = 48;
            this.labDayMonthYear.Text = "DayMonthYear";
            // 
            // labday
            // 
            this.labday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labday.AutoSize = true;
            this.labday.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labday.Location = new System.Drawing.Point(706, 9);
            this.labday.Name = "labday";
            this.labday.Size = new System.Drawing.Size(33, 21);
            this.labday.TabIndex = 47;
            this.labday.Text = "Day";
            // 
            // labSecons
            // 
            this.labSecons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labSecons.AutoSize = true;
            this.labSecons.Location = new System.Drawing.Point(665, 15);
            this.labSecons.Name = "labSecons";
            this.labSecons.Size = new System.Drawing.Size(17, 13);
            this.labSecons.TabIndex = 46;
            this.labSecons.Text = "ss";
            // 
            // labTime
            // 
            this.labTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(622, 9);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(58, 21);
            this.labTime.TabIndex = 45;
            this.labTime.Text = "HH:mm";
            // 
            // data
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.Location = new System.Drawing.Point(171, 80);
            this.data.Name = "data";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data.Size = new System.Drawing.Size(713, 409);
            this.data.TabIndex = 49;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuanLyNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnQuanLyNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(12, 80);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(127, 30);
            this.btnQuanLyNhanVien.TabIndex = 50;
            this.btnQuanLyNhanVien.Text = "Quản Lý Nhân Viên ";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.Silver;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.ButtonText = "Search..";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Goldenrod;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = global::QuanLySach.Properties.Resources.icons8_search_16;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 60D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(790, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(82, 23);
            this.btnSearch.TabIndex = 59;
            this.btnSearch.Text = "Search..";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.DarkGreen;
            this.txtSearch.Location = new System.Drawing.Point(514, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(270, 20);
            this.txtSearch.TabIndex = 58;
            this.txtSearch.Text = "Tìm Kiếm ";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // toolbox
            // 
            this.toolbox.Controls.Add(this.btnXoa);
            this.toolbox.Controls.Add(this.btnCapNhat);
            this.toolbox.Location = new System.Drawing.Point(171, 495);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(315, 54);
            this.toolbox.TabIndex = 67;
            this.toolbox.TabStop = false;
            this.toolbox.Text = "ToolBox";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLySach.Properties.Resources.delete_25px;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(166, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 23);
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
            this.btnCapNhat.Size = new System.Drawing.Size(135, 23);
            this.btnCapNhat.TabIndex = 61;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnquanlydangnhap
            // 
            this.btnquanlydangnhap.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnquanlydangnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnquanlydangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnquanlydangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquanlydangnhap.Location = new System.Drawing.Point(12, 116);
            this.btnquanlydangnhap.Name = "btnquanlydangnhap";
            this.btnquanlydangnhap.Size = new System.Drawing.Size(127, 30);
            this.btnquanlydangnhap.TabIndex = 68;
            this.btnquanlydangnhap.Text = "Quản Lý Đăng nhập";
            this.btnquanlydangnhap.UseVisualStyleBackColor = true;
            this.btnquanlydangnhap.Click += new System.EventHandler(this.btnquanlydangnhap_Click);
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuanLyKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnQuanLyKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnQuanLyKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(12, 152);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(127, 30);
            this.btnQuanLyKhachHang.TabIndex = 69;
            this.btnQuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            this.btnQuanLyKhachHang.UseVisualStyleBackColor = true;
            this.btnQuanLyKhachHang.Click += new System.EventHandler(this.btnQuanLyKhachHang_Click);
            // 
            // btnthongkenhap
            // 
            this.btnthongkenhap.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnthongkenhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnthongkenhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnthongkenhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthongkenhap.Location = new System.Drawing.Point(12, 188);
            this.btnthongkenhap.Name = "btnthongkenhap";
            this.btnthongkenhap.Size = new System.Drawing.Size(127, 30);
            this.btnthongkenhap.TabIndex = 70;
            this.btnthongkenhap.Text = "Thống Kê Nhập";
            this.btnthongkenhap.UseVisualStyleBackColor = true;
            this.btnthongkenhap.Click += new System.EventHandler(this.btnthongkenhap_Click);
            // 
            // txtStart
            // 
            this.txtStart.CustomFormat = "dd/MM/yyyy";
            this.txtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStart.Location = new System.Drawing.Point(10, 26);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(127, 20);
            this.txtStart.TabIndex = 71;
            // 
            // paNgay
            // 
            this.paNgay.Controls.Add(this.btnFinish);
            this.paNgay.Controls.Add(this.txtend);
            this.paNgay.Controls.Add(this.label2);
            this.paNgay.Controls.Add(this.label1);
            this.paNgay.Controls.Add(this.txtStart);
            this.paNgay.Location = new System.Drawing.Point(2, 290);
            this.paNgay.Name = "paNgay";
            this.paNgay.Size = new System.Drawing.Size(148, 140);
            this.paNgay.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "End";
            // 
            // txtend
            // 
            this.txtend.CustomFormat = "dd/MM/yyyy";
            this.txtend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtend.Location = new System.Drawing.Point(10, 74);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(127, 20);
            this.txtend.TabIndex = 74;
            // 
            // btnFinish
            // 
            this.btnFinish.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFinish.BackColor = System.Drawing.Color.Silver;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinish.BorderRadius = 7;
            this.btnFinish.ButtonText = "Finish";
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.DisabledColor = System.Drawing.Color.Gray;
            this.btnFinish.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFinish.Iconimage = null;
            this.btnFinish.Iconimage_right = null;
            this.btnFinish.Iconimage_right_Selected = null;
            this.btnFinish.Iconimage_Selected = null;
            this.btnFinish.IconMarginLeft = 0;
            this.btnFinish.IconMarginRight = 0;
            this.btnFinish.IconRightVisible = true;
            this.btnFinish.IconRightZoom = 0D;
            this.btnFinish.IconVisible = true;
            this.btnFinish.IconZoom = 90D;
            this.btnFinish.IsTab = false;
            this.btnFinish.Location = new System.Drawing.Point(10, 110);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnFinish.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnFinish.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFinish.selected = false;
            this.btnFinish.Size = new System.Drawing.Size(127, 27);
            this.btnFinish.TabIndex = 75;
            this.btnFinish.Text = "Finish";
            this.btnFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFinish.Textcolor = System.Drawing.Color.White;
            this.btnFinish.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnThongKeXuat
            // 
            this.btnThongKeXuat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThongKeXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnThongKeXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnThongKeXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeXuat.Location = new System.Drawing.Point(12, 224);
            this.btnThongKeXuat.Name = "btnThongKeXuat";
            this.btnThongKeXuat.Size = new System.Drawing.Size(127, 30);
            this.btnThongKeXuat.TabIndex = 73;
            this.btnThongKeXuat.Text = "Thống Kê Xuất";
            this.btnThongKeXuat.UseVisualStyleBackColor = true;
            this.btnThongKeXuat.Click += new System.EventHandler(this.btnThongKeXuat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 22);
            this.label3.TabIndex = 74;
            this.label3.Text = "Tổng Tiền:";
            // 
            // laTongTien
            // 
            this.laTongTien.AutoSize = true;
            this.laTongTien.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTongTien.Location = new System.Drawing.Point(107, 11);
            this.laTongTien.Name = "laTongTien";
            this.laTongTien.Size = new System.Drawing.Size(101, 22);
            this.laTongTien.TabIndex = 75;
            this.laTongTien.Text = "Tổng Tiền:";
            // 
            // paTong
            // 
            this.paTong.Controls.Add(this.laTongTien);
            this.paTong.Controls.Add(this.label3);
            this.paTong.Location = new System.Drawing.Point(551, 506);
            this.paTong.Name = "paTong";
            this.paTong.Size = new System.Drawing.Size(303, 43);
            this.paTong.TabIndex = 76;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.paTong);
            this.Controls.Add(this.btnThongKeXuat);
            this.Controls.Add(this.paNgay);
            this.Controls.Add(this.btnthongkenhap);
            this.Controls.Add(this.btnQuanLyKhachHang);
            this.Controls.Add(this.btnquanlydangnhap);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnQuanLyNhanVien);
            this.Controls.Add(this.data);
            this.Controls.Add(this.labDayMonthYear);
            this.Controls.Add(this.labday);
            this.Controls.Add(this.labSecons);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.Exit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(884, 561);
            this.Name = "frmQuanLy";
            this.Text = "frmQuanLy";
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.toolbox.ResumeLayout(false);
            this.paNgay.ResumeLayout(false);
            this.paNgay.PerformLayout();
            this.paTong.ResumeLayout(false);
            this.paTong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label labDayMonthYear;
        private System.Windows.Forms.Label labday;
        private System.Windows.Forms.Label labSecons;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private ns1.BunifuFlatButton btnSearch;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSearch;
        private System.Windows.Forms.GroupBox toolbox;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnquanlydangnhap;
        private System.Windows.Forms.Button btnQuanLyKhachHang;
        private System.Windows.Forms.Button btnthongkenhap;
        private System.Windows.Forms.DateTimePicker txtStart;
        private System.Windows.Forms.Panel paNgay;
        private ns1.BunifuFlatButton btnFinish;
        private System.Windows.Forms.DateTimePicker txtend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThongKeXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laTongTien;
        private System.Windows.Forms.Panel paTong;
    }
}