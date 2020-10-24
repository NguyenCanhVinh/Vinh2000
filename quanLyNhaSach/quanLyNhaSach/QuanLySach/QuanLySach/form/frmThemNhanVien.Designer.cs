namespace QuanLySach
{
    partial class frmThemNhanVien
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
            this.btnTaoThe = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnAddNhanVien = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labDayMonthYear = new System.Windows.Forms.Label();
            this.labday = new System.Windows.Forms.Label();
            this.labSecons = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtChucVu = new System.Windows.Forms.ComboBox();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.raNam = new System.Windows.Forms.RadioButton();
            this.raNu = new System.Windows.Forms.RadioButton();
            this.raKhac = new System.Windows.Forms.RadioButton();
            this.btnSearchNV = new ns1.BunifuFlatButton();
            this.txtsearchNV = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtcreateLogin = new System.Windows.Forms.GroupBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.txtcreateLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTaoThe
            // 
            this.btnTaoThe.Location = new System.Drawing.Point(626, 517);
            this.btnTaoThe.Name = "btnTaoThe";
            this.btnTaoThe.Size = new System.Drawing.Size(157, 23);
            this.btnTaoThe.TabIndex = 47;
            this.btnTaoThe.Text = "Tạo Thẻ ";
            this.btnTaoThe.UseVisualStyleBackColor = true;
            this.btnTaoThe.Click += new System.EventHandler(this.btnTaoThe_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Image = global::QuanLySach.Properties.Resources.delete_25px;
            this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAll.Location = new System.Drawing.Point(47, 463);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(145, 30);
            this.btnDeleteAll.TabIndex = 45;
            this.btnDeleteAll.Text = "Xóa Tất Cả";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnAddNhanVien
            // 
            this.btnAddNhanVien.Image = global::QuanLySach.Properties.Resources.add_25px;
            this.btnAddNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNhanVien.Location = new System.Drawing.Point(225, 463);
            this.btnAddNhanVien.Name = "btnAddNhanVien";
            this.btnAddNhanVien.Size = new System.Drawing.Size(157, 30);
            this.btnAddNhanVien.TabIndex = 44;
            this.btnAddNhanVien.Text = "Thêm Nhân Viên ";
            this.btnAddNhanVien.UseVisualStyleBackColor = true;
            this.btnAddNhanVien.Click += new System.EventHandler(this.btnAddNhanVien_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(157, 250);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(225, 20);
            this.txtDiaChi.TabIndex = 42;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(157, 139);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(225, 20);
            this.txtTenNV.TabIndex = 39;
            // 
            // txtMaNv
            // 
            this.txtMaNv.Location = new System.Drawing.Point(157, 99);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(225, 20);
            this.txtMaNv.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Chức Vụ ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Ngày Sinh ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tên Nhân Viên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Mã Nhân Viên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Thông Tin Nhân Viên ";
            // 
            // labDayMonthYear
            // 
            this.labDayMonthYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDayMonthYear.AutoSize = true;
            this.labDayMonthYear.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDayMonthYear.Location = new System.Drawing.Point(765, 17);
            this.labDayMonthYear.Name = "labDayMonthYear";
            this.labDayMonthYear.Size = new System.Drawing.Size(99, 21);
            this.labDayMonthYear.TabIndex = 30;
            this.labDayMonthYear.Text = "DayMonthYear";
            // 
            // labday
            // 
            this.labday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labday.AutoSize = true;
            this.labday.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labday.Location = new System.Drawing.Point(706, 17);
            this.labday.Name = "labday";
            this.labday.Size = new System.Drawing.Size(33, 21);
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
            this.labTime.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(622, 17);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(58, 21);
            this.labTime.TabIndex = 27;
            this.labTime.Text = "HH:mm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 28);
            this.label1.TabIndex = 26;
            this.label1.Text = "Đăng Kí Tài Khoản Nhân Viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(494, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 370);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.Image = global::QuanLySach.Properties.Resources.exit;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(21, 527);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 23);
            this.Exit.TabIndex = 25;
            this.Exit.Text = "Bán Hàng";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtChucVu
            // 
            this.txtChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtChucVu.FormattingEnabled = true;
            this.txtChucVu.Items.AddRange(new object[] {
            "Nhân Viên",
            "Thu Ngân ",
            "Quản Lý"});
            this.txtChucVu.Location = new System.Drawing.Point(157, 288);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(225, 21);
            this.txtChucVu.TabIndex = 48;
            this.txtChucVu.Click += new System.EventHandler(this.txtChucVu_Click);
            this.txtChucVu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtChucVu_MouseDoubleClick);
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgaySinh.Location = new System.Drawing.Point(157, 217);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(225, 20);
            this.txtNgaySinh.TabIndex = 49;
            this.txtNgaySinh.Value = new System.DateTime(2020, 6, 11, 0, 0, 0, 0);
            // 
            // raNam
            // 
            this.raNam.AutoSize = true;
            this.raNam.Location = new System.Drawing.Point(157, 172);
            this.raNam.Name = "raNam";
            this.raNam.Size = new System.Drawing.Size(47, 17);
            this.raNam.TabIndex = 50;
            this.raNam.TabStop = true;
            this.raNam.Text = "Nam";
            this.raNam.UseVisualStyleBackColor = true;
            // 
            // raNu
            // 
            this.raNu.AutoSize = true;
            this.raNu.Location = new System.Drawing.Point(225, 172);
            this.raNu.Name = "raNu";
            this.raNu.Size = new System.Drawing.Size(39, 17);
            this.raNu.TabIndex = 51;
            this.raNu.TabStop = true;
            this.raNu.Text = "Nữ";
            this.raNu.UseVisualStyleBackColor = true;
            // 
            // raKhac
            // 
            this.raKhac.AutoSize = true;
            this.raKhac.Location = new System.Drawing.Point(304, 173);
            this.raKhac.Name = "raKhac";
            this.raKhac.Size = new System.Drawing.Size(50, 17);
            this.raKhac.TabIndex = 52;
            this.raKhac.Text = "Khác";
            this.raKhac.UseVisualStyleBackColor = true;
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.Activecolor = System.Drawing.Color.Silver;
            this.btnSearchNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearchNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchNV.BorderRadius = 5;
            this.btnSearchNV.ButtonText = "Search..";
            this.btnSearchNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchNV.DisabledColor = System.Drawing.Color.Goldenrod;
            this.btnSearchNV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchNV.Iconimage = global::QuanLySach.Properties.Resources.icons8_search_16;
            this.btnSearchNV.Iconimage_right = null;
            this.btnSearchNV.Iconimage_right_Selected = null;
            this.btnSearchNV.Iconimage_Selected = null;
            this.btnSearchNV.IconMarginLeft = 0;
            this.btnSearchNV.IconMarginRight = 0;
            this.btnSearchNV.IconRightVisible = true;
            this.btnSearchNV.IconRightZoom = 0D;
            this.btnSearchNV.IconVisible = true;
            this.btnSearchNV.IconZoom = 60D;
            this.btnSearchNV.IsTab = false;
            this.btnSearchNV.Location = new System.Drawing.Point(773, 76);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearchNV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearchNV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchNV.selected = false;
            this.btnSearchNV.Size = new System.Drawing.Size(91, 23);
            this.btnSearchNV.TabIndex = 59;
            this.btnSearchNV.Text = "Search..";
            this.btnSearchNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchNV.Textcolor = System.Drawing.Color.White;
            this.btnSearchNV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // txtsearchNV
            // 
            this.txtsearchNV.BorderColor = System.Drawing.Color.DarkGreen;
            this.txtsearchNV.Location = new System.Drawing.Point(494, 76);
            this.txtsearchNV.Name = "txtsearchNV";
            this.txtsearchNV.Size = new System.Drawing.Size(273, 20);
            this.txtsearchNV.TabIndex = 58;
            this.txtsearchNV.Text = "Tìm Kiếm Mã Nhân Viên ";
            this.txtsearchNV.Click += new System.EventHandler(this.txtsearchNV_Click);
            // 
            // txtcreateLogin
            // 
            this.txtcreateLogin.Controls.Add(this.btnok);
            this.txtcreateLogin.Controls.Add(this.btnhuybo);
            this.txtcreateLogin.Controls.Add(this.txtPassword);
            this.txtcreateLogin.Controls.Add(this.txtUsername);
            this.txtcreateLogin.Controls.Add(this.label9);
            this.txtcreateLogin.Controls.Add(this.label10);
            this.txtcreateLogin.Location = new System.Drawing.Point(51, 325);
            this.txtcreateLogin.Name = "txtcreateLogin";
            this.txtcreateLogin.Size = new System.Drawing.Size(331, 123);
            this.txtcreateLogin.TabIndex = 60;
            this.txtcreateLogin.TabStop = false;
            this.txtcreateLogin.Text = "Tạo Login ";
            // 
            // btnok
            // 
            this.btnok.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Location = new System.Drawing.Point(138, 94);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 45;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnhuybo
            // 
            this.btnhuybo.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnhuybo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnhuybo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnhuybo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhuybo.Location = new System.Drawing.Point(228, 94);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(75, 23);
            this.btnhuybo.TabIndex = 44;
            this.btnhuybo.Text = "Hủy Bỏ";
            this.btnhuybo.UseVisualStyleBackColor = true;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(106, 60);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 20);
            this.txtPassword.TabIndex = 43;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(106, 20);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 20);
            this.txtUsername.TabIndex = 42;
            this.txtUsername.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Username";
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtcreateLogin);
            this.Controls.Add(this.btnSearchNV);
            this.Controls.Add(this.txtsearchNV);
            this.Controls.Add(this.raKhac);
            this.Controls.Add(this.raNu);
            this.Controls.Add(this.raNam);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.btnTaoThe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnAddNhanVien);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtMaNv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labDayMonthYear);
            this.Controls.Add(this.labday);
            this.Controls.Add(this.labSecons);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmThemNhanVien";
            this.Text = "frmThemNhanVien";
            this.Load += new System.EventHandler(this.frmThemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.txtcreateLogin.ResumeLayout(false);
            this.txtcreateLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoThe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnAddNhanVien;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labDayMonthYear;
        private System.Windows.Forms.Label labday;
        private System.Windows.Forms.Label labSecons;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox txtChucVu;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.RadioButton raNam;
        private System.Windows.Forms.RadioButton raNu;
        private System.Windows.Forms.RadioButton raKhac;
        private ns1.BunifuFlatButton btnSearchNV;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtsearchNV;
        private System.Windows.Forms.GroupBox txtcreateLogin;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}