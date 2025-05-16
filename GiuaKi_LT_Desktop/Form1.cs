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

            var connectionString = "Data Source=your_database_file.db";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();


                var command = connection.CreateCommand();
                command.CommandText =
                @"
                        CREATE TABLE IF NOT EXISTS SampleTable (
                            Id INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT
                        );
                    ";
                command.ExecuteNonQuery();


            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void HoTen_label_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
