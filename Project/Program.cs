using System;
using System.Windows.Forms;

namespace Project
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    public static class Database
    {
        public static string connectionString = @"Data Source=Mouse.db;Integrated Security=False; MultipleActiveResultSets=True";
    }
    public static class ConfigMouse
    {
        public static string ID_Mouse { get; set; }
        public static string Header { get; set; }
        public static string Description { get; set; }
        public static string Image { get; set; }
    }
    public static class MouseTable
    {
        public static string Main = "Mouse";
        public static string ID_Mouse = "ID_Mouse";
        public static string Header = "Header";
        public static string Description = "Description";
        public static string Image = "Image";
    }
}
