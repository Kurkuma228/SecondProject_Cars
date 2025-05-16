namespace SecondProject_Auto.Forms
{
    partial class Login_Form
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
            this.loginNameEmail_txtb = new System.Windows.Forms.TextBox();
            this.login_lbl = new System.Windows.Forms.Label();
            this.loginPassword_txtb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.loginAndEmail_lbl = new System.Windows.Forms.Label();
            this.passwrod_lbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.white_pbox = new System.Windows.Forms.PictureBox();
            this.back_pbox = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.white_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginNameEmail_txtb
            // 
            this.loginNameEmail_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginNameEmail_txtb.Location = new System.Drawing.Point(367, 231);
            this.loginNameEmail_txtb.Multiline = true;
            this.loginNameEmail_txtb.Name = "loginNameEmail_txtb";
            this.loginNameEmail_txtb.Size = new System.Drawing.Size(227, 34);
            this.loginNameEmail_txtb.TabIndex = 0;
            this.loginNameEmail_txtb.Enter += new System.EventHandler(this.loginNameEmail_txtb_Enter);
            this.loginNameEmail_txtb.Leave += new System.EventHandler(this.loginNameEmail_txtb_Leave);
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.BackColor = System.Drawing.Color.White;
            this.login_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F);
            this.login_lbl.Location = new System.Drawing.Point(371, 63);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(233, 33);
            this.login_lbl.TabIndex = 1;
            this.login_lbl.Text = "Вход в профиль";
            // 
            // loginPassword_txtb
            // 
            this.loginPassword_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginPassword_txtb.Location = new System.Drawing.Point(367, 271);
            this.loginPassword_txtb.Multiline = true;
            this.loginPassword_txtb.Name = "loginPassword_txtb";
            this.loginPassword_txtb.PasswordChar = '*';
            this.loginPassword_txtb.Size = new System.Drawing.Size(227, 34);
            this.loginPassword_txtb.TabIndex = 6;
            this.loginPassword_txtb.Enter += new System.EventHandler(this.loginPassword_txtb_Enter);
            this.loginPassword_txtb.Leave += new System.EventHandler(this.loginPassword_txtb_Leave);
            // 
            // login_btn
            // 
            this.login_btn.AutoSize = true;
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(106)))), ((int)(((byte)(232)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(367, 334);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(227, 28);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Войти";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(207)))));
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(367, 368);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(227, 28);
            this.register_btn.TabIndex = 8;
            this.register_btn.Text = "Зарегистрироваться";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginAndEmail_lbl
            // 
            this.loginAndEmail_lbl.AutoSize = true;
            this.loginAndEmail_lbl.BackColor = System.Drawing.Color.White;
            this.loginAndEmail_lbl.ForeColor = System.Drawing.Color.Gray;
            this.loginAndEmail_lbl.Location = new System.Drawing.Point(374, 242);
            this.loginAndEmail_lbl.Name = "loginAndEmail_lbl";
            this.loginAndEmail_lbl.Size = new System.Drawing.Size(90, 13);
            this.loginAndEmail_lbl.TabIndex = 12;
            this.loginAndEmail_lbl.Text = "Логин или почта";
            // 
            // passwrod_lbl
            // 
            this.passwrod_lbl.AutoSize = true;
            this.passwrod_lbl.BackColor = System.Drawing.Color.White;
            this.passwrod_lbl.ForeColor = System.Drawing.Color.Gray;
            this.passwrod_lbl.Location = new System.Drawing.Point(374, 282);
            this.passwrod_lbl.Name = "passwrod_lbl";
            this.passwrod_lbl.Size = new System.Drawing.Size(45, 13);
            this.passwrod_lbl.TabIndex = 13;
            this.passwrod_lbl.Text = "Пароль";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SecondProject_Auto.Properties.Resources.ProfileCircle;
            this.pictureBox3.Location = new System.Drawing.Point(433, 121);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // white_pbox
            // 
            this.white_pbox.BackColor = System.Drawing.Color.White;
            this.white_pbox.Location = new System.Drawing.Point(296, 0);
            this.white_pbox.Name = "white_pbox";
            this.white_pbox.Size = new System.Drawing.Size(372, 563);
            this.white_pbox.TabIndex = 9;
            this.white_pbox.TabStop = false;
            // 
            // back_pbox
            // 
            this.back_pbox.Image = global::SecondProject_Auto.Properties.Resources.LoginAndRegistration;
            this.back_pbox.Location = new System.Drawing.Point(0, 0);
            this.back_pbox.Name = "back_pbox";
            this.back_pbox.Size = new System.Drawing.Size(948, 563);
            this.back_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_pbox.TabIndex = 10;
            this.back_pbox.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(367, 311);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 562);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.passwrod_lbl);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.loginAndEmail_lbl);
            this.Controls.Add(this.loginNameEmail_txtb);
            this.Controls.Add(this.loginPassword_txtb);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.white_pbox);
            this.Controls.Add(this.back_pbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login_Form";
            this.Text = "Вход в профиль";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.white_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox loginNameEmail_txtb;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.TextBox loginPassword_txtb;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.PictureBox white_pbox;
        private System.Windows.Forms.PictureBox back_pbox;
        private System.Windows.Forms.Label loginAndEmail_lbl;
        private System.Windows.Forms.Label passwrod_lbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}