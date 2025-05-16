using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GiuaKi_LT_Desktop
{
    public partial class Form1 : Form
    {
        private string filePath = @"C:\Users\Administrator\source\repos\GK_LTdesktop1\GiuaKi_LT_Desktop\dulieu.txt";

        private List<NhanVien> danhSachNhanVien = new();
        private bool isAdding = false;

        public class NhanVien
        {
            public string MaSo { get; set; }
            public string HoTen { get; set; }
            public string NgaySinh { get; set; }
            public string Email { get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("MaSo", "Mã số");
                dataGridView1.Columns.Add("HoTen", "Họ tên");
                dataGridView1.Columns.Add("NgaySinh", "Ngày sinh");
                dataGridView1.Columns.Add("Email", "Email");
            }

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            Them_BT.Click += Them_BT_Click;
            Luu_BT.Click += Luu_BT_Click;
            Luu_BT.Enabled = false;
            LoadDataFromFile();
        }

        private void LoadDataFromFile()
        {
            danhSachNhanVien.Clear();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 4)
                    {
                        danhSachNhanVien.Add(new NhanVien
                        {
                            MaSo = parts[0],
                            HoTen = parts[1],
                            NgaySinh = parts[2],
                            Email = parts[3]
                        });
                    }
                }
            }
            HienThiLenDataGridView();
        }

        private void HienThiLenDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (var nv in danhSachNhanVien)
            {
                dataGridView1.Rows.Add(nv.MaSo, nv.HoTen, nv.NgaySinh, nv.Email);
            }
        }

        private void SaveDataToFile()
        {
            using (var writer = new StreamWriter(filePath, false))
            {
                foreach (var nv in danhSachNhanVien)
                {
                    writer.WriteLine($"{nv.MaSo};{nv.HoTen};{nv.NgaySinh};{nv.Email}"); // Đã sửa thành dấu ';'
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value?.ToString() ?? "";
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value?.ToString() ?? "";
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value?.ToString() ?? "";
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value?.ToString() ?? "";
            }
        }

        private void Them_BT_Click(object sender, System.EventArgs e)
        {
            if (!isAdding)
            {
                isAdding = true;
                Them_BT.Text = "Hủy";
                Luu_BT.Enabled = true;
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
                textBox1.Focus();
                dataGridView1.ClearSelection();
            }
            else
            {
                isAdding = false;
                Them_BT.Text = "Thêm";
                Luu_BT.Enabled = false;
                dataGridView1_SelectionChanged(null, null);
            }
        }

        private void Luu_BT_Click(object sender, System.EventArgs e)
        {
            if (isAdding)
            {
                var nv = new NhanVien
                {
                    MaSo = textBox1.Text.Trim(),
                    HoTen = textBox2.Text.Trim(),
                    NgaySinh = textBox3.Text.Trim(),
                    Email = textBox4.Text.Trim()
                };
                danhSachNhanVien.Add(nv);
                HienThiLenDataGridView();
                isAdding = false;
                Them_BT.Text = "Thêm";
                Luu_BT.Enabled = false;
            }
            SaveDataToFile();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveDataToFile();
            base.OnFormClosing(e);
        }

        private void label1_Click(object sender, System.EventArgs e) { }
        private void button1_Click(object sender, System.EventArgs e) { }
        private void button1_Click_1(object sender, System.EventArgs e) {
            SaveDataToFile();
            Environment.Exit(0);
        }
        private void HoTen_label_Click(object sender, System.EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void Form1_Load(object sender, System.EventArgs e) { }
    }
}
