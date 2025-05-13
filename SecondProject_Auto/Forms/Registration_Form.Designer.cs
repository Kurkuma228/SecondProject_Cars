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
            this.password_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.loginEmail_txtb = new System.Windows.Forms.TextBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.loginName_txtb = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.register_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // loginPassword_txtb
            // 
            this.loginPassword_txtb.Location = new System.Drawing.Point(138, 195);
            this.loginPassword_txtb.Name = "loginPassword_txtb";
            this.loginPassword_txtb.Size = new System.Drawing.Size(201, 20);
            this.loginPassword_txtb.TabIndex = 12;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.password_lbl.Location = new System.Drawing.Point(137, 175);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(57, 17);
            this.password_lbl.TabIndex = 11;
            this.password_lbl.Text = "Пароль";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.email_lbl.Location = new System.Drawing.Point(137, 132);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(49, 17);
            this.email_lbl.TabIndex = 10;
            this.email_lbl.Text = "Почта";
            // 
            // loginEmail_txtb
            // 
            this.loginEmail_txtb.Location = new System.Drawing.Point(138, 152);
            this.loginEmail_txtb.Name = "loginEmail_txtb";
            this.loginEmail_txtb.Size = new System.Drawing.Size(201, 20);
            this.loginEmail_txtb.TabIndex = 9;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.name_lbl.Location = new System.Drawing.Point(135, 89);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 17);
            this.name_lbl.TabIndex = 8;
            this.name_lbl.Text = "Имя";
            // 
            // loginName_txtb
            // 
            this.loginName_txtb.Location = new System.Drawing.Point(138, 109);
            this.loginName_txtb.Name = "loginName_txtb";
            this.loginName_txtb.Size = new System.Drawing.Size(201, 20);
            this.loginName_txtb.TabIndex = 7;
            // 
            // register_btn
            // 
            this.register_btn.AutoSize = true;
            this.register_btn.FlatAppearance.BorderSize = 0;
            this.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register_btn.Location = new System.Drawing.Point(140, 237);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(125, 25);
            this.register_btn.TabIndex = 13;
            this.register_btn.Text = "Зарегистрироваться";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // register_lbl
            // 
            this.register_lbl.AutoSize = true;
            this.register_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.register_lbl.Location = new System.Drawing.Point(135, 50);
            this.register_lbl.Name = "register_lbl";
            this.register_lbl.Size = new System.Drawing.Size(141, 26);
            this.register_lbl.TabIndex = 14;
            this.register_lbl.Text = "Регистрация";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(296, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 563);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SecondProject_Auto.Properties.Resources.LoginAndRegistration;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(948, 563);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 562);
            this.Controls.Add(this.register_lbl);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.loginPassword_txtb);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.loginEmail_txtb);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.loginName_txtb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Registration_Form";
            this.Text = "Registration_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginPassword_txtb;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.TextBox loginEmail_txtb;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox loginName_txtb;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label register_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}