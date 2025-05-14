namespace SecondProject_Auto.Forms
{
    partial class Registration_Form
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
            this.loginPassword_txtb = new System.Windows.Forms.TextBox();
            this.loginEmail_txtb = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.loginName_txtb = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.register_lbl = new System.Windows.Forms.Label();
            this.white_pbox = new System.Windows.Forms.PictureBox();
            this.back_pbox = new System.Windows.Forms.PictureBox();
            this.email_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.loginSecPassword_txtb = new System.Windows.Forms.TextBox();
            this.secPassword_lbl = new System.Windows.Forms.Label();
            this.photo_pbox = new System.Windows.Forms.PictureBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.white_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPassword_txtb
            // 
            this.loginPassword_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginPassword_txtb.Location = new System.Drawing.Point(363, 311);
            this.loginPassword_txtb.Multiline = true;
            this.loginPassword_txtb.Name = "loginPassword_txtb";
            this.loginPassword_txtb.Size = new System.Drawing.Size(227, 34);
            this.loginPassword_txtb.TabIndex = 12;
            this.loginPassword_txtb.Enter += new System.EventHandler(this.loginPassword_txtb_Enter);
            this.loginPassword_txtb.Leave += new System.EventHandler(this.loginPassword_txtb_Leave);
            // 
            // loginEmail_txtb
            // 
            this.loginEmail_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginEmail_txtb.Location = new System.Drawing.Point(363, 271);
            this.loginEmail_txtb.Multiline = true;
            this.loginEmail_txtb.Name = "loginEmail_txtb";
            this.loginEmail_txtb.Size = new System.Drawing.Size(227, 34);
            this.loginEmail_txtb.TabIndex = 9;
            this.loginEmail_txtb.Enter += new System.EventHandler(this.loginEmail_txtb_Enter);
            this.loginEmail_txtb.Leave += new System.EventHandler(this.loginEmail_txtb_Leave);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.BackColor = System.Drawing.Color.White;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.name_lbl.ForeColor = System.Drawing.Color.Gray;
            this.name_lbl.Location = new System.Drawing.Point(374, 242);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(38, 13);
            this.name_lbl.TabIndex = 8;
            this.name_lbl.Text = "Логин";
            // 
            // loginName_txtb
            // 
            this.loginName_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginName_txtb.Location = new System.Drawing.Point(363, 231);
            this.loginName_txtb.Multiline = true;
            this.loginName_txtb.Name = "loginName_txtb";
            this.loginName_txtb.Size = new System.Drawing.Size(227, 34);
            this.loginName_txtb.TabIndex = 7;
            this.loginName_txtb.Enter += new System.EventHandler(this.loginName_txtb_Enter);
            this.loginName_txtb.Leave += new System.EventHandler(this.loginName_txtb_Leave);
            // 
            // register_btn
            // 
            this.register_btn.AutoSize = true;
            this.register_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(106)))), ((int)(((byte)(232)))));
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_btn.ForeColor = System.Drawing.Color.White;
            this.register_btn.Location = new System.Drawing.Point(363, 412);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(227, 28);
            this.register_btn.TabIndex = 13;
            this.register_btn.Text = "Зарегистрироваться";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // register_lbl
            // 
            this.register_lbl.AutoSize = true;
            this.register_lbl.BackColor = System.Drawing.Color.White;
            this.register_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F);
            this.register_lbl.Location = new System.Drawing.Point(343, 63);
            this.register_lbl.Name = "register_lbl";
            this.register_lbl.Size = new System.Drawing.Size(277, 33);
            this.register_lbl.TabIndex = 14;
            this.register_lbl.Text = "Создание профиля";
            // 
            // white_pbox
            // 
            this.white_pbox.BackColor = System.Drawing.Color.White;
            this.white_pbox.Location = new System.Drawing.Point(296, 0);
            this.white_pbox.Name = "white_pbox";
            this.white_pbox.Size = new System.Drawing.Size(372, 563);
            this.white_pbox.TabIndex = 15;
            this.white_pbox.TabStop = false;
            // 
            // back_pbox
            // 
            this.back_pbox.Image = global::SecondProject_Auto.Properties.Resources.LoginAndRegistration;
            this.back_pbox.Location = new System.Drawing.Point(0, 0);
            this.back_pbox.Name = "back_pbox";
            this.back_pbox.Size = new System.Drawing.Size(948, 563);
            this.back_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_pbox.TabIndex = 16;
            this.back_pbox.TabStop = false;
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.BackColor = System.Drawing.Color.White;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.email_lbl.ForeColor = System.Drawing.Color.Gray;
            this.email_lbl.Location = new System.Drawing.Point(374, 282);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(37, 13);
            this.email_lbl.TabIndex = 17;
            this.email_lbl.Text = "Почта";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.BackColor = System.Drawing.Color.White;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.password_lbl.ForeColor = System.Drawing.Color.Gray;
            this.password_lbl.Location = new System.Drawing.Point(374, 322);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(45, 13);
            this.password_lbl.TabIndex = 18;
            this.password_lbl.Text = "Пароль";
            // 
            // loginSecPassword_txtb
            // 
            this.loginSecPassword_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginSecPassword_txtb.Location = new System.Drawing.Point(363, 351);
            this.loginSecPassword_txtb.Multiline = true;
            this.loginSecPassword_txtb.Name = "loginSecPassword_txtb";
            this.loginSecPassword_txtb.Size = new System.Drawing.Size(227, 34);
            this.loginSecPassword_txtb.TabIndex = 19;
            this.loginSecPassword_txtb.Enter += new System.EventHandler(this.loginSecPassword_txtb_Enter);
            this.loginSecPassword_txtb.Leave += new System.EventHandler(this.loginSecPassword_txtb_Leave);
            // 
            // secPassword_lbl
            // 
            this.secPassword_lbl.AutoSize = true;
            this.secPassword_lbl.BackColor = System.Drawing.Color.White;
            this.secPassword_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.secPassword_lbl.ForeColor = System.Drawing.Color.Gray;
            this.secPassword_lbl.Location = new System.Drawing.Point(374, 362);
            this.secPassword_lbl.Name = "secPassword_lbl";
            this.secPassword_lbl.Size = new System.Drawing.Size(100, 13);
            this.secPassword_lbl.TabIndex = 20;
            this.secPassword_lbl.Text = "Повторите пароль";
            // 
            // photo_pbox
            // 
            this.photo_pbox.Image = global::SecondProject_Auto.Properties.Resources.ProfileCircle;
            this.photo_pbox.Location = new System.Drawing.Point(432, 121);
            this.photo_pbox.Name = "photo_pbox";
            this.photo_pbox.Size = new System.Drawing.Size(90, 90);
            this.photo_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo_pbox.TabIndex = 21;
            this.photo_pbox.TabStop = false;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(207)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(363, 446);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(227, 28);
            this.login_btn.TabIndex = 22;
            this.login_btn.Text = "Войти в логин";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(458, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Слива";
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.photo_pbox);
            this.Controls.Add(this.secPassword_lbl);
            this.Controls.Add(this.loginSecPassword_txtb);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.register_lbl);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.loginPassword_txtb);
            this.Controls.Add(this.loginEmail_txtb);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.loginName_txtb);
            this.Controls.Add(this.white_pbox);
            this.Controls.Add(this.back_pbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Registration_Form";
            this.Text = "Форма регистрации";
            ((System.ComponentModel.ISupportInitialize)(this.white_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photo_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginPassword_txtb;
        private System.Windows.Forms.TextBox loginEmail_txtb;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox loginName_txtb;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label register_lbl;
        private System.Windows.Forms.PictureBox white_pbox;
        private System.Windows.Forms.PictureBox back_pbox;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox loginSecPassword_txtb;
        private System.Windows.Forms.Label secPassword_lbl;
        private System.Windows.Forms.PictureBox photo_pbox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label1;
    }
}