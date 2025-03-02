using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CD3_APP
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        // Sự kiện khi FormMenu load
        private void FormMenu_Load(object sender, EventArgs e)
        {
           
        }

        // Quản lý thông tin hồ sơ
        private void btnQlTT_Click(object sender, EventArgs e)
        {
            FormTT frmQLTT = new FormTT();
            frmQLTT.Show();
            this.Hide();  // Ẩn FormMenu hiện tại
        }

        // Quản lý lịch tiêm chủng
        private void btnQlLich_Click(object sender, EventArgs e)
        {
            FormLich frmLich = new FormLich();
            frmLich.Show();
            this.Hide();
        }

        // Quản lý thuốc và chế độ điều trị
        private void btnQlthuoc_Click(object sender, EventArgs e)
        {
            FormThuoc frmThuoc = new FormThuoc();
            frmThuoc.Show();
            this.Hide();
        }

        // Quản lý dữ liệu đo lường
        private void btnDo_Click(object sender, EventArgs e)
        {
            FormDo frmDo = new FormDo();
            frmDo.Show();
            this.Hide();
        }

        // Báo cáo sức khoẻ
        private void btnBao_Click(object sender, EventArgs e)
        {
            FormBao frmBao = new FormBao();
            frmBao.Show();
            this.Hide();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            FormMenu frmmenu= new FormMenu();
            frmmenu.Show();
            this.Hide();
        }
    }
}

