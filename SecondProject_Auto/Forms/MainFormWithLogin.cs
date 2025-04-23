using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondProject_Auto.Forms
{
    public partial class MainFormWithLogin : Form
    {
        public List<Auto> Autos { get; set; }
        public MainFormWithLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AutosListForm autosList = new AutosListForm(autos);
            if (autosList.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private List<Auto> autos = new List<Auto>
        {
            new Auto
            {
                Name = "Tesla Model S",
                PhotoFilePath = "tesla.jpg",
                AutoType = "Electric luxury sedan.",
                Price = 89990m
            },
            new Auto
            {
                Name = "BMW M3",
                PhotoFilePath = "bmw.jpg",
                AutoType = "High-performance sports car.",
                Price = 72800m
            },
            new Auto
            {
                Name = "Ford F-150",
                PhotoFilePath = "ford.jpg",
                AutoType = "Durable and powerful pickup truck.",
                Price = 34550m
            },
            new Auto
            {
                Name = "Audi Q5",
                PhotoFilePath = "audi.jpg",
                AutoType = "Compact luxury SUV.",
                Price = 43500m
            }
        };
    }
}
