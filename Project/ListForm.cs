using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Project
{
    public partial class ListForm : Form
    {
        private SQLiteConnection DB;

        public ListForm()
        {
            InitializeComponent();
        }
        private async void ListForm_Load(object sender, EventArgs e)
        {
            DB = new SQLiteConnection(Database.connectionString);
            await DB.OpenAsync();
        }

        private async void LogBox_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{MouseTable.Main}] WHERE ID_Mouse=1", DB);
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                var name = sqlReader.GetValue(2);
                var description = sqlReader.GetValue(3);
                var image = sqlReader.GetValue(4);
                ConfigMouse.Header = (string)name;
                ConfigMouse.Description = (string)description;
                ConfigMouse.Image = (string)image;
            }
            Hide();
            MouseForm listForm = new MouseForm();
            listForm.ShowDialog();
            this.Close();
        }

        private async void HyperXBox_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{MouseTable.Main}] WHERE ID_Mouse=2", DB);
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                var name = sqlReader.GetValue(2);
                var description = sqlReader.GetValue(3);
                var image = sqlReader.GetValue(4);
                ConfigMouse.Header = (string)name;
                ConfigMouse.Description = (string)description;
                ConfigMouse.Image = (string)image;
            }
            Hide();
            MouseForm listForm = new MouseForm();
            listForm.ShowDialog();
            this.Close();
        }

        private async void RazerBox_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{MouseTable.Main}] WHERE ID_Mouse=3", DB);
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                var name = sqlReader.GetValue(2);
                var description = sqlReader.GetValue(3);
                var image = sqlReader.GetValue(4);
                ConfigMouse.Header = (string)name;
                ConfigMouse.Description = (string)description;
                ConfigMouse.Image = (string)image;
            }
            Hide();
            MouseForm listForm = new MouseForm();
            listForm.ShowDialog();
            this.Close();
        }

        private async void ZowieBox_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{MouseTable.Main}] WHERE ID_Mouse=4", DB);
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                var name = sqlReader.GetValue(2);
                var description = sqlReader.GetValue(3);
                var image = sqlReader.GetValue(4);
                ConfigMouse.Header = (string)name;
                ConfigMouse.Description = (string)description;
                ConfigMouse.Image = (string)image;
            }
            Hide();
            MouseForm listForm = new MouseForm();
            listForm.ShowDialog();
            this.Close();
        }
        private async void SteelBox_Click(object sender, EventArgs e)
        {
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{MouseTable.Main}] WHERE ID_Mouse=5", DB);
            sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                var name = sqlReader.GetValue(2);
                var description = sqlReader.GetValue(3);
                var image = sqlReader.GetValue(4);
                ConfigMouse.Header = (string)name;
                ConfigMouse.Description = (string)description;
                ConfigMouse.Image = (string)image;
            }
            Hide();
            MouseForm listForm = new MouseForm();
            listForm.ShowDialog();
            this.Close();
        }

        private void BackBox_Click_1(object sender, EventArgs e)
        {
            Hide();
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
            this.Close();
        }

        private void ListForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
