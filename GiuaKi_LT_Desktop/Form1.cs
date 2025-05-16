using Microsoft.Data.Sqlite;
//using Microsoft.EntityFrameworkCore;

namespace GiuaKi_LT_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConnectToDatabase();
        }

        private void ConnectToDatabase()
        {
            // Path to your SQLite database file
            var connectionString = "Data Source=your_database_file.db";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // Example: create a table if it doesn't exist
                var command = connection.CreateCommand();
                command.CommandText =
                @"
                        CREATE TABLE IF NOT EXISTS SampleTable (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT
                        );
                    ";
                command.ExecuteNonQuery();

                // You can now execute queries using this connection
            }
        }
    }
}
