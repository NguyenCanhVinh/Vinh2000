namespace QuanLySach
{
    partial class taoTheThanhVien
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKh = new System.Windows.Forms.TextBox();
            this.txtMaSoThue = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.raKhac = new System.Windows.Forms.RadioButton();
            this.raNu = new System.Windows.Forms.RadioButton();
            this.raNam = new System.Windows.Forms.RadioButton();
            this.txtsearchIDCustomer = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnSearch = new ns1.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đăng Kí Khách Hàng Thành Viên";
            // 
            // labDayMonthYear
            // 
            this.labDayMonthYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDayMonthYear.AutoSize = true;
            this.labDayMonthYear.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDayMonthYear.Location = new System.Drawing.Point(756, 16);
            this.labDayMonthYear.Name = "labDayMonthYear";
            this.labDayMonthYear.Size = new System.Drawing.Size(99, 21);
            this.labDayMonthYear.TabIndex = 7;
            this.labDayMonthYear.Text = "DayMonthYear";
            // 
            // labday
            // 
            this.labday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labday.AutoSize = true;
            this.labday.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labday.Location = new System.Drawing.Point(697, 16);
            this.labday.Name = "labday";
            this.labday.Size = new System.Drawing.Size(33, 21);
            this.labday.TabIndex = 6;
            this.labday.Text = "Day";
            // 
            // labSecons
            // 
            this.labSecons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labSecons.AutoSize = true;
            this.labSecons.Location = new System.Drawing.Point(656, 22);
            this.labSecons.Name = "labSecons";
            this.labSecons.Size = new System.Drawing.Size(17, 13);
            this.labSecons.TabIndex = 5;
            this.labSecons.Text = "ss";
            // 
            // labTime
            // 
            this.labTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTime.Location = new System.Drawing.Point(613, 16);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(58, 21);
            this.labTime.TabIndex = 4;
            this.labTime.Text = "HH:mm";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông Tin Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giới Tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã Số Thuế";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Địa Chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Điện Thoại";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(148, 113);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(147, 20);
            this.txtMaKH.TabIndex = 15;
            // 
            // txtTenKh
            // 
            this.txtTenKh.Location = new System.Drawing.Point(148, 153);
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.Size = new System.Drawing.Size(225, 20);
            this.txtTenKh.TabIndex = 16;
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.Location = new System.Drawing.Point(148, 233);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(225, 20);
            this.txtMaSoThue.TabIndex = 18;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(148, 273);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(225, 20);
            this.txtDiaChi.TabIndex = 19;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(148, 313);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(225, 20);
            this.txtDienThoai.TabIndex = 20;
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.Location = new System.Drawing.Point(601, 510);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(157, 23);
            this.btnCreateMember.TabIndex = 24;
            this.btnCreateMember.Text = "Tạo Thẻ ";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // raKhac
            // 
            this.raKhac.AutoSize = true;
            this.raKhac.Location = new System.Drawing.Point(295, 197);
            this.raKhac.Name = "raKhac";
            this.raKhac.Size = new System.Drawing.Size(50, 17);
            this.raKhac.TabIndex = 55;
            this.raKhac.Text = "Khác";
            this.raKhac.UseVisualStyleBackColor = true;
            // 
            // raNu
            // 
            this.raNu.AutoSize = true;
            this.raNu.Location = new System.Drawing.Point(216, 196);
            this.raNu.Name = "raNu";
            this.raNu.Size = new System.Drawing.Size(39, 17);
            this.raNu.TabIndex = 54;
            this.raNu.TabStop = true;
            this.raNu.Text = "Nữ";
            this.raNu.UseVisualStyleBackColor = true;
            // 
            // raNam
            // 
            this.raNam.AutoSize = true;
            this.raNam.Location = new System.Drawing.Point(148, 196);
            this.raNam.Name = "raNam";
            this.raNam.Size = new System.Drawing.Size(47, 17);
            this.raNam.TabIndex = 53;
            this.raNam.TabStop = true;
            this.raNam.Text = "Nam";
            this.raNam.UseVisualStyleBackColor = true;
            // 
            // txtsearchIDCustomer
            // 
            this.txtsearchIDCustomer.BorderColor = System.Drawing.Color.DarkGreen;
            this.txtsearchIDCustomer.Location = new System.Drawing.Point(485, 78);
            this.txtsearchIDCustomer.Name = "txtsearchIDCustomer";
            this.txtsearchIDCustomer.Size = new System.Drawing.Size(273, 20);
            this.txtsearchIDCustomer.TabIndex = 56;
            this.txtsearchIDCustomer.Text = "Tìm Kiếm Mã Khách Hàng";
            this.txtsearchIDCustomer.Click += new System.EventHandler(this.btnsearchIDCustomer_Click);
            this.txtsearchIDCustomer.TextChanged += new System.EventHandler(this.txtsearchIDCustomer_TextChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(764, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 57;
            this.btnSearch.Text = "Search..";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(485, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 370);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btndelete
            // 
            this.btndelete.Image = global::QuanLySach.Properties.Resources.delete_25px;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(38, 373);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(145, 30);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Xóa Tất Cả";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnAddKH
            // 
            this.btnAddKH.Image = global::QuanLySach.Properties.Resources.add_25px;
            this.btnAddKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddKH.Location = new System.Drawing.Point(216, 373);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(157, 30);
            this.btnAddKH.TabIndex = 21;
            this.btnAddKH.Text = "Thêm Khách Hàng";
            this.btnAddKH.UseVisualStyleBackColor = true;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // Exit
            // 
            this.Exit.Image = global::QuanLySach.Properties.Resources.exit;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(12, 526);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(89, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Bán Hàng";
            this.Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(301, 113);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(72, 23);
            this.btnAuto.TabIndex = 58;
            this.btnAuto.Text = "AutoKey";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // taoTheThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtsearchIDCustomer);
            this.Controls.Add(this.raKhac);
            this.Controls.Add(this.raNu);
            this.Controls.Add(this.raNam);
            this.Controls.Add(this.btnCreateMember);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnAddKH);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMaSoThue);
            this.Controls.Add(this.txtTenKh);
            this.Controls.Add(this.txtMaKH);
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
            this.MinimumSize = new System.Drawing.Size(884, 561);
            this.Name = "taoTheThanhVien";
            this.Text = "taoTheThanhVien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDayMonthYear;
        private System.Windows.Forms.Label labday;
        private System.Windows.Forms.Label labSecons;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKh;
        private System.Windows.Forms.TextBox txtMaSoThue;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Button btnAddKH;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.RadioButton raKhac;
        private System.Windows.Forms.RadioButton raNu;
        private System.Windows.Forms.RadioButton raNam;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtsearchIDCustomer;
        private ns1.BunifuFlatButton btnSearch;
        private System.Windows.Forms.Button btnAuto;
    }
}