namespace SecondProject_Auto
{
    partial class Profile_Form
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
            this.loginName_txtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginEmail_txtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginPassword_txtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.loginSecPassword_txtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // loginName_txtb
            // 
            this.loginName_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginName_txtb.Location = new System.Drawing.Point(367, 231);
            this.loginName_txtb.Multiline = true;
            this.loginName_txtb.Name = "loginName_txtb";
            this.loginName_txtb.Size = new System.Drawing.Size(227, 34);
            this.loginName_txtb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(377, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя";
            // 
            // loginEmail_txtb
            // 
            this.loginEmail_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginEmail_txtb.Location = new System.Drawing.Point(367, 271);
            this.loginEmail_txtb.Multiline = true;
            this.loginEmail_txtb.Name = "loginEmail_txtb";
            this.loginEmail_txtb.Size = new System.Drawing.Size(227, 34);
            this.loginEmail_txtb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(377, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Почта";
            // 
            // loginPassword_txtb
            // 
            this.loginPassword_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginPassword_txtb.Location = new System.Drawing.Point(367, 311);
            this.loginPassword_txtb.Multiline = true;
            this.loginPassword_txtb.Name = "loginPassword_txtb";
            this.loginPassword_txtb.PasswordChar = '*';
            this.loginPassword_txtb.Size = new System.Drawing.Size(227, 34);
            this.loginPassword_txtb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(377, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(296, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 563);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SecondProject_Auto.Properties.Resources.Profile;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(948, 563);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(106)))), ((int)(((byte)(232)))));
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.Location = new System.Drawing.Point(367, 416);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(227, 34);
            this.save_btn.TabIndex = 13;
            this.save_btn.Text = "Сохранить изменения";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // loginSecPassword_txtb
            // 
            this.loginSecPassword_txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.loginSecPassword_txtb.Location = new System.Drawing.Point(367, 351);
            this.loginSecPassword_txtb.Multiline = true;
            this.loginSecPassword_txtb.Name = "loginSecPassword_txtb";
            this.loginSecPassword_txtb.PasswordChar = '*';
            this.loginSecPassword_txtb.Size = new System.Drawing.Size(227, 34);
            this.loginSecPassword_txtb.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(377, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F);
            this.label5.Location = new System.Drawing.Point(338, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 33);
            this.label5.TabIndex = 16;
            this.label5.Text = "Изменение профиля";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SecondProject_Auto.Properties.Resources.ProfileCircle;
            this.pictureBox3.Location = new System.Drawing.Point(433, 121);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(90, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Brown;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(367, 456);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(227, 34);
            this.delete_btn.TabIndex = 18;
            this.delete_btn.Text = "Удалить профиль";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(367, 391);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Profile_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 562);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginSecPassword_txtb);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginPassword_txtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginEmail_txtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginName_txtb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Profile_Form";
            this.Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginName_txtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginEmail_txtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginPassword_txtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox loginSecPassword_txtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}