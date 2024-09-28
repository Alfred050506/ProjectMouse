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
    public partial class ZowieForm : Form
    {
        public ZowieForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            GamesMouseForm gamesMouse = new GamesMouseForm();
            gamesMouse.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            GamesMouseForm gamesMouse = new GamesMouseForm();
            gamesMouse.ShowDialog();
            this.Close();
        }
    }
}
