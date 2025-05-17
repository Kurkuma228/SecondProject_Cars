namespace SecondProject_Auto.Forms
{
    partial class EditDescriptionCar_Form
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
            this.photo_btn = new System.Windows.Forms.Button();
            this.car_pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.car_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // photo_btn
            // 
            this.photo_btn.Location = new System.Drawing.Point(596, 323);
            this.photo_btn.Name = "photo_btn";
            this.photo_btn.Size = new System.Drawing.Size(167, 23);
            this.photo_btn.TabIndex = 0;
            this.photo_btn.Text = "Изменить фотографию";
            this.photo_btn.UseVisualStyleBackColor = true;
            this.photo_btn.Click += new System.EventHandler(this.photo_btn_Click);
            // 
            // car_pbx
            // 
            this.car_pbx.Location = new System.Drawing.Point(386, 36);
            this.car_pbx.Name = "car_pbx";
            this.car_pbx.Size = new System.Drawing.Size(477, 281);
            this.car_pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car_pbx.TabIndex = 1;
            this.car_pbx.TabStop = false;
            // 
            // EditDescriptionCar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 562);
            this.Controls.Add(this.car_pbx);
            this.Controls.Add(this.photo_btn);
            this.Name = "EditDescriptionCar_Form";
            this.Text = "editDescriptionCar_Form";
            ((System.ComponentModel.ISupportInitialize)(this.car_pbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button photo_btn;
        private System.Windows.Forms.PictureBox car_pbx;
    }
}