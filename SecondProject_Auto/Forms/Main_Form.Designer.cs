namespace SecondProject_Auto
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_lbl = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.car_pbox = new System.Windows.Forms.PictureBox();
            this.icon_pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.car_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_lbl.Location = new System.Drawing.Point(47, 7);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(119, 24);
            this.title_lbl.TabIndex = 2;
            this.title_lbl.Text = "Car-Search";
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(106)))), ((int)(((byte)(232)))));
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.start_btn.Font = new System.Drawing.Font("Lato Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(75, 275);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(122, 40);
            this.start_btn.TabIndex = 5;
            this.start_btn.Text = "Начать";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lato", 30.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(758, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = "Подбери себе идеальный автомобиль";
            // 
            // car_pbox
            // 
            this.car_pbox.Image = global::SecondProject_Auto.Properties.Resources._123;
            this.car_pbox.Location = new System.Drawing.Point(-3, 37);
            this.car_pbox.Name = "car_pbox";
            this.car_pbox.Size = new System.Drawing.Size(955, 528);
            this.car_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car_pbox.TabIndex = 9;
            this.car_pbox.TabStop = false;
            // 
            // icon_pbox
            // 
            this.icon_pbox.Image = global::SecondProject_Auto.Properties.Resources.Icon;
            this.icon_pbox.Location = new System.Drawing.Point(16, 6);
            this.icon_pbox.Name = "icon_pbox";
            this.icon_pbox.Size = new System.Drawing.Size(25, 25);
            this.icon_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.icon_pbox.TabIndex = 1;
            this.icon_pbox.TabStop = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 562);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.icon_pbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.car_pbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Стартовое окно";
            ((System.ComponentModel.ISupportInitialize)(this.car_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox icon_pbox;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox car_pbox;
    }
}

