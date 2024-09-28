using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class MouseForm : Form
    {
        public MouseForm()
        {
            InitializeComponent();
        }

        private void MouseForm_Load(object sender, EventArgs e)
        {
            header.Text = ConfigMouse.Header;
            description.Text = ConfigMouse.Description;
            image.Image = Image.FromFile(ConfigMouse.Image);
        }

        private void BackBox1_Click_1(object sender, EventArgs e)
        {
            Hide();
            ListForm mainForm = new ListForm();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
