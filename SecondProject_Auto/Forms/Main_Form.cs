using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SecondProject_Auto.Forms;

namespace SecondProject_Auto
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            LoadData();

            #region AdditionalSettingsForm
            label2.Parent = pictureBox2;
            label3.Parent = pictureBox2;
            #endregion
        }
        public void LoadData()
        {
            using (AutoContext db = new AutoContext())
            {
                var autos = db.Autos.ToList();
            }
            using (UserContext db2 = new UserContext())
            {
                var users = db2.Users.ToList(); 
            }
        }
        private void start_btn_Click(object sender, EventArgs e)
        {
            if (Login_Form.IsLoggedIn)
            {
                var form = new MainWithLogin_Form();

                ApplicationContext context = (ApplicationContext)Application.OpenForms[0].Tag;
                context.MainForm = form;

                form.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Войдите в систему");
            }
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            var form = new Login_Form();
            form.ShowDialog();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            var form = new Registration_Form();
            form.ShowDialog();
        }
        private void PictureBox2_Resize(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                using (Graphics g = Graphics.FromImage(pictureBox2.Image))
                {
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.CompositingQuality = CompositingQuality.HighQuality;
                }
                pictureBox2.Invalidate(); 
            }
        }
    }
 }
