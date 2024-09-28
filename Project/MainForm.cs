using System;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region Переход к мышкам
        private void ListButton_Click_1(object sender, EventArgs e)
        {
            Hide();
            ListForm listForm = new ListForm();
            listForm.ShowDialog();
            this.Close();
        }
        #endregion
    }
}
