using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace CD3_APP
{
    public partial class FormThuoc : Form
    {
        private string connectionString = "Data Source=DESKTOP-AB2IUOS;Initial Catalog=\"Quanly CD3\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True"; // Thay bằng chuỗi kết nối của bạn

        public FormThuoc()
        {
            InitializeComponent();
            LoadData();
        }

        // 🔹 Hàm tải dữ liệu lên DataGridView
        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Thuocdieutri";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // 🔹 Thêm thuốc vào CSDL
        private void btnAddTT_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Thuocdieutri (tenThuoc, lieuLuong, cachDung, ghiChu) VALUES (@ten, @ll, @cd, @gc)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", txtten.Text);
                cmd.Parameters.AddWithValue("@ll", txtLL.Text);
                cmd.Parameters.AddWithValue("@cd", string.IsNullOrEmpty(txtDC.Text) ? (object)DBNull.Value : txtDC.Text);
                cmd.Parameters.AddWithValue("@gc", string.IsNullOrEmpty(txtNote.Text) ? (object)DBNull.Value : txtNote.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm thuốc thành công!");
                    LoadData();
                }
                else
                    MessageBox.Show("Lỗi khi thêm thuốc.");
            }
        }

        // 🔹 Sửa thông tin thuốc
        private void btnFixTT_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int maThuoc = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["maThuoc"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Thuocdieutri SET tenThuoc=@ten, lieuLuong=@ll, cachDung=@cd, ghiChu=@gc WHERE maThuoc=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", maThuoc);
                    cmd.Parameters.AddWithValue("@ten", txtten.Text);
                    cmd.Parameters.AddWithValue("@ll", txtLL.Text);
                    cmd.Parameters.AddWithValue("@cd", string.IsNullOrEmpty(txtDC.Text) ? (object)DBNull.Value : txtDC.Text);
                    cmd.Parameters.AddWithValue("@gc", string.IsNullOrEmpty(txtNote.Text) ? (object)DBNull.Value : txtNote.Text);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Cập nhật thuốc thành công!");
                        LoadData();
                    }
                    else
                        MessageBox.Show("Lỗi khi cập nhật thuốc.");
                }
            }
        }

        // 🔹 Xóa thuốc
        private void btnDelTT_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int maThuoc = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["maThuoc"].Value);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Thuocdieutri WHERE maThuoc=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", maThuoc);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Xóa thuốc thành công!");
                        LoadData();
                    }
                    else
                        MessageBox.Show("Lỗi khi xóa thuốc.");
                }
            }
        }

        // 🔹 Tìm kiếm thuốc theo tên
        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Thuocdieutri WHERE tenThuoc LIKE @keyword";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@keyword", "%" + txtSearch.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        // 🔹 Làm mới danh sách
        private void btnF5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // 🔹 Khi click vào hàng trên DataGridView, đổ dữ liệu lên các TextBox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtten.Text = row.Cells["tenThuoc"].Value.ToString();
                txtLL.Text = row.Cells["lieuLuong"].Value.ToString();
                txtDC.Text = row.Cells["cachDung"].Value?.ToString();
                txtNote.Text = row.Cells["ghiChu"].Value?.ToString();
            }
     
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    txtMaThuoc.Text = row.Cells["maThuoc"].Value.ToString(); // Mã thuốc
                    txtten.Text = row.Cells["tenThuoc"].Value.ToString(); // Tên thuốc
                    txtLL.Text = row.Cells["lieuLuong"].Value.ToString(); // Liều lượng
                    txtDC.Text = row.Cells["cachDung"].Value != DBNull.Value ? row.Cells["cachDung"].Value.ToString() : ""; // Cách dùng
                    txtNote.Text = row.Cells["ghiChu"].Value != DBNull.Value ? row.Cells["ghiChu"].Value.ToString() : ""; // Ghi chú
                }
            


        }
    }
}
