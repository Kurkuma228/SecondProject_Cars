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
            this.name_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.loginPassword_txtb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginNameEmail_txtb
            // 
            this.loginNameEmail_txtb.Location = new System.Drawing.Point(80, 56);
            this.loginNameEmail_txtb.Name = "loginNameEmail_txtb";
            this.loginNameEmail_txtb.Size = new System.Drawing.Size(201, 20);
            this.loginNameEmail_txtb.TabIndex = 0;
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.login_lbl.Location = new System.Drawing.Point(77, 10);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(63, 26);
            this.login_lbl.TabIndex = 1;
            this.login_lbl.Text = "Вход";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.name_lbl.Location = new System.Drawing.Point(77, 36);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(101, 17);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "Имя или Email";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.password_lbl.Location = new System.Drawing.Point(79, 79);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(57, 17);
            this.password_lbl.TabIndex = 5;
            this.password_lbl.Text = "Пароль";
            // 
            // loginPassword_txtb
            // 
            this.loginPassword_txtb.Location = new System.Drawing.Point(80, 99);
            this.loginPassword_txtb.Name = "loginPassword_txtb";
            this.loginPassword_txtb.Size = new System.Drawing.Size(201, 20);
            this.loginPassword_txtb.TabIndex = 6;
            // 
            // login_btn
            // 
            this.login_btn.AutoSize = true;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_btn.Location = new System.Drawing.Point(80, 125);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(125, 25);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Войти";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 562);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.loginPassword_txtb);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.loginNameEmail_txtb);
            this.Name = "Login_Form";
            this.Text = "цв";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginNameEmail_txtb;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.TextBox loginPassword_txtb;
        private System.Windows.Forms.Button login_btn;
    }
}