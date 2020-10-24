namespace QuanLySach
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.passworld = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exitprogram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Arial Narrow", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lable.Location = new System.Drawing.Point(25, 9);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(351, 53);
            this.lable.TabIndex = 4;
            this.lable.Text = "Bookstore Manger";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(95, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account Login";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(61, 204);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(259, 22);
            this.username.TabIndex = 7;
            this.username.Text = "Username";
            this.username.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username_MouseClick);
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
            // 
            // passworld
            // 
            this.passworld.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.passworld.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passworld.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passworld.ForeColor = System.Drawing.Color.White;
            this.passworld.Location = new System.Drawing.Point(64, 268);
            this.passworld.Name = "passworld";
            this.passworld.Size = new System.Drawing.Size(259, 22);
            this.passworld.TabIndex = 8;
            this.passworld.Text = "Passworld";
            this.passworld.UseSystemPasswordChar = true;
            this.passworld.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passworld_MouseClick);
            this.passworld.TextChanged += new System.EventHandler(this.passworld_TextChanged);
            this.passworld.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passworld_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(23, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 1);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(23, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 1);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(201, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đăng nhập bằng thẻ nhân viên.";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.MediumAquamarine;
            this.signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signin.FlatAppearance.BorderSize = 0;
            this.signin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.signin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.Black;
            this.signin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signin.Location = new System.Drawing.Point(26, 315);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(350, 40);
            this.signin.TabIndex = 11;
            this.signin.Text = "Sign In";
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::QuanLySach.Properties.Resources.icons8_password_25px;
            this.pictureBox3.Location = new System.Drawing.Point(26, 265);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::QuanLySach.Properties.Resources.icons8_user_account_40px_3;
            this.pictureBox2.Location = new System.Drawing.Point(26, 201);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // exitprogram
            // 
            this.exitprogram.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitprogram.FlatAppearance.BorderSize = 0;
            this.exitprogram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exitprogram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exitprogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitprogram.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitprogram.ForeColor = System.Drawing.Color.White;
            this.exitprogram.Image = global::QuanLySach.Properties.Resources.shutdown;
            this.exitprogram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitprogram.Location = new System.Drawing.Point(12, 468);
            this.exitprogram.Name = "exitprogram";
            this.exitprogram.Size = new System.Drawing.Size(108, 26);
            this.exitprogram.TabIndex = 0;
            this.exitprogram.Text = "Exit Program";
            this.exitprogram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitprogram.UseVisualStyleBackColor = true;
            this.exitprogram.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(401, 506);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passworld);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.exitprogram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(417, 545);
            this.MinimumSize = new System.Drawing.Size(417, 545);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Sách Phương Nam - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitprogram;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox passworld;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Label label3;
    }
}

