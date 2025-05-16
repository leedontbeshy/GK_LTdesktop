using Microsoft.Data.Sqlite;
using System.IO;


namespace GiuaKi_LT_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataFromFile();
            ConnectToDatabase();
            SaveDataToFile();
        }
        private string filePath = "dulieu.txt";


        private void LoadDataFromFile()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                dataGridView1.Rows.Clear();
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        dataGridView1.Rows.Add(parts[0], parts[1], parts[2], parts[3]);
                    }
                }
            }
        }


        private void SaveDataToFile()
        {
            using (var writer = new StreamWriter(filePath, false))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var values = new string[]
                        {
                    row.Cells[0].Value?.ToString() ?? "",
                    row.Cells[1].Value?.ToString() ?? "",
                    row.Cells[2].Value?.ToString() ?? "",
                    row.Cells[3].Value?.ToString() ?? ""
                        };
                        writer.WriteLine(string.Join("|", values));
                    }
                }
            }
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
