namespace QuanLySach
{
    partial class frmTacGia
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
            this.Exit = new System.Windows.Forms.Button();
            this.labDayMonthYear = new System.Windows.Forms.Label();
            this.labday = new System.Windows.Forms.Label();
            this.labSecons = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddTG = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnXoaALL = new System.Windows.Forms.Button();
            this.dataTacGia = new System.Windows.Forms.DataGridView();
            this.MaTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LienHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolbox = new System.Windows.Forms.GroupBox();
            this.btnDelete = new ns1.BunifuFlatButton();
            this.btnCapNhat = new ns1.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataTacGia)).BeginInit();
            this.toolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Image = global::QuanLySach.Properties.Resources.exit;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit.Location = new System.Drawing.Point(12, 526);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(91, 23);
            this.Exit.TabIndex = 26;
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
            this.labDayMonthYear.TabIndex = 34;
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
            this.labday.TabIndex = 33;
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
            this.labSecons.TabIndex = 32;
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
            this.labTime.TabIndex = 31;
            this.labTime.Text = "HH:mm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 37);
            this.label1.TabIndex = 35;
            this.label1.Text = "Thêm Tác Giả ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã Tác Giả ";
            // 
            // txtMaTG
            // 
            this.txtMaTG.Location = new System.Drawing.Point(89, 95);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(272, 20);
            this.txtMaTG.TabIndex = 37;
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(89, 138);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(272, 20);
            this.txtTenTG.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tên Tác Giả";
            // 
            // txtLH
            // 
            this.txtLH.Location = new System.Drawing.Point(89, 187);
            this.txtLH.Name = "txtLH";
            this.txtLH.Size = new System.Drawing.Size(272, 20);
            this.txtLH.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Liên Hệ";
            // 
            // btnAddTG
            // 
            this.btnAddTG.Image = global::QuanLySach.Properties.Resources.add_25px;
            this.btnAddTG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTG.Location = new System.Drawing.Point(234, 255);
            this.btnAddTG.Name = "btnAddTG";
            this.btnAddTG.Size = new System.Drawing.Size(109, 30);
            this.btnAddTG.TabIndex = 42;
            this.btnAddTG.Text = "Thêm Tác Giả ";
            this.btnAddTG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTG.UseVisualStyleBackColor = true;
            this.btnAddTG.Click += new System.EventHandler(this.btnAddTG_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(425, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(342, 20);
            this.txtSearch.TabIndex = 43;
            this.txtSearch.Text = "Nhập Mã Tác Giả Cần Tìm";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::QuanLySach.Properties.Resources.icons8_search_16;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(777, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 23);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnXoaALL
            // 
            this.btnXoaALL.Image = global::QuanLySach.Properties.Resources.delete_25px;
            this.btnXoaALL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaALL.Location = new System.Drawing.Point(89, 255);
            this.btnXoaALL.Name = "btnXoaALL";
            this.btnXoaALL.Size = new System.Drawing.Size(98, 30);
            this.btnXoaALL.TabIndex = 45;
            this.btnXoaALL.Text = "Xóa Tất Cả ";
            this.btnXoaALL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaALL.UseVisualStyleBackColor = true;
            this.btnXoaALL.Click += new System.EventHandler(this.btnXoaALL_Click);
            // 
            // dataTacGia
            // 
            this.dataTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTG,
            this.TenTG,
            this.LienHe});
            this.dataTacGia.Location = new System.Drawing.Point(425, 98);
            this.dataTacGia.Name = "dataTacGia";
            this.dataTacGia.Size = new System.Drawing.Size(443, 451);
            this.dataTacGia.TabIndex = 46;
            this.dataTacGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTacGia_CellClick);
            // 
            // MaTG
            // 
            this.MaTG.DataPropertyName = "MaTG";
            this.MaTG.HeaderText = "Mã Tác Giả";
            this.MaTG.Name = "MaTG";
            // 
            // TenTG
            // 
            this.TenTG.DataPropertyName = "TenTG";
            this.TenTG.HeaderText = "Tên Tác Giả";
            this.TenTG.Name = "TenTG";
            this.TenTG.Width = 150;
            // 
            // LienHe
            // 
            this.LienHe.DataPropertyName = "LienHe";
            this.LienHe.HeaderText = "Liên Hệ";
            this.LienHe.Name = "LienHe";
            this.LienHe.Width = 150;
            // 
            // toolbox
            // 
            this.toolbox.Controls.Add(this.btnDelete);
            this.toolbox.Controls.Add(this.btnCapNhat);
            this.toolbox.Location = new System.Drawing.Point(33, 314);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(328, 75);
            this.toolbox.TabIndex = 78;
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
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.dataTacGia);
            this.Controls.Add(this.btnXoaALL);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddTG);
            this.Controls.Add(this.txtLH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenTG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaTG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labDayMonthYear);
            this.Controls.Add(this.labday);
            this.Controls.Add(this.labSecons);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTacGia";
            this.Text = "frmTacGia";
            this.Load += new System.EventHandler(this.txtLienHe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTacGia)).EndInit();
            this.toolbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label labDayMonthYear;
        private System.Windows.Forms.Label labday;
        private System.Windows.Forms.Label labSecons;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddTG;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnXoaALL;
        private System.Windows.Forms.DataGridView dataTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LienHe;
        private System.Windows.Forms.GroupBox toolbox;
        private ns1.BunifuFlatButton btnDelete;
        private ns1.BunifuFlatButton btnCapNhat;
    }
}