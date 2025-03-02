using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD3_APP
{
    public partial class FormLich : Form
    {
        private string connectionString = "Data Source=DESKTOP-AB2IUOS;Initial Catalog=\"Quanly CD3\";Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public FormLich()
        {
            InitializeComponent();
            load_data();
        }

        private void load_data()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Lichtiemchung";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Lichtiemchung (ngayTiem, loaiVacXin, bacSiPhuTrach, lieuluong, Note) 
                                     VALUES (@ngayTiem, @loaiVacXin, @bacSiPhuTrach, @lieuluong, @Note)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ngayTiem", dtDate.Value);
                        cmd.Parameters.AddWithValue("@loaiVacXin", txtLoai.Text);
                        cmd.Parameters.AddWithValue("@bacSiPhuTrach", txtPhutrach.Text);
                        cmd.Parameters.AddWithValue("@lieuluong", txtLL.Text);
                        cmd.Parameters.AddWithValue("@Note", txtNote.Text);
                        
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Thêm lịch tiêm thành công!" : "Thêm thất bại!");
                    }
                }
                load_data(); // Load lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }
        private void btnFix_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTiem.Text))
            {
                MessageBox.Show("Vui lòng chọn lịch tiêm cần sửa!");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Lichtiemchung 
                                     SET ngayTiem = @ngayTiem, loaiVacXin = @loaiVacXin, 
                                         bacSiPhuTrach = @bacSiPhuTrach, lieuluong = @lieuluong, 
                                         Note = @Note
                                     WHERE maTiem = @maTiem";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@maTiem", txtMaTiem.Text);
                        cmd.Parameters.AddWithValue("@ngayTiem", dtDate.Value);
                        cmd.Parameters.AddWithValue("@loaiVacXin", txtLoai.Text);
                        cmd.Parameters.AddWithValue("@bacSiPhuTrach", txtPhutrach.Text);
                        cmd.Parameters.AddWithValue("@lieuluong", txtLL.Text);
                        cmd.Parameters.AddWithValue("@Note", txtNote.Text);
               

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Cập nhật thành công!" : "Cập nhật thất bại!");
                    }
                }
                load_data(); // Load lại dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTiem.Text))
            {
                MessageBox.Show("Vui lòng chọn lịch tiêm cần xóa!");
                return;
            }

            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa lịch tiêm này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM LichTiemChung WHERE maTiem = @maTiem";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@maTiem", txtMaTiem.Text);

                            con.Open();
                            int rows = cmd.ExecuteNonQuery();
                            MessageBox.Show(rows > 0 ? "Xóa thành công!" : "Xóa thất bại!");
                        }
                    }
                    load_data(); // Load lại dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }
        private void btnQlTT_Click(object sender, EventArgs e)
        {
            FormTT frmQLTT = new FormTT();
            frmQLTT.Show();
            this.Hide();
        }

        private void btnQlLich_Click(object sender, EventArgs e)
        {
            FormLich frmLich = new FormLich();
            frmLich.Show();
            this.Hide();
        }

        private void btnQlthuoc_Click(object sender, EventArgs e)
        {

            FormThuoc frmThuoc = new FormThuoc();
            frmThuoc.Show();
            this.Hide();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            FormDo frmDo = new FormDo();
            frmDo.Show();
            this.Hide();
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            FormBao frmBao = new FormBao();
            frmBao.Show();
            this.Hide();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            FormMenu frmmenu = new FormMenu();
            frmmenu.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaTiem.Text = row.Cells["maTiem"].Value.ToString();
                dtDate.Value = Convert.ToDateTime(row.Cells["ngayTiem"].Value);
                txtLoai.Text = row.Cells["loaiVacXin"].Value.ToString();
                txtPhutrach.Text = row.Cells["bacSiPhuTrach"].Value.ToString();
                txtLL.Text = row.Cells["lieuluong"].Value.ToString();
                txtNote.Text = row.Cells["Note"].Value.ToString();
            }
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void FormLich_Load(object sender, EventArgs e)
        {


        }
    }
}
