using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class GamesMouseForm : Form
    {
        public GamesMouseForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            LogForm logForm = new LogForm();
            logForm.ShowDialog();
            this.Close();
        }

        private void GamesMouseForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            HyperXForm hypForm = new HyperXForm();
            hypForm.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hide();
            RazerVip razForm = new RazerVip();
            razForm.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hide();
            ZowieForm zowForm = new ZowieForm();
            zowForm.ShowDialog();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Hide();
            SteelForm steelForm = new SteelForm();
            steelForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.Show();
        }
    }
}
