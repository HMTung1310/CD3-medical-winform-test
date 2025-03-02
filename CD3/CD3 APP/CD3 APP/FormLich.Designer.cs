namespace CD3_APP
{
    partial class FormLich
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLich));
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.menu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPhutrach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnF5 = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.btnQlthuoc = new System.Windows.Forms.Button();
            this.btnQlTT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBao = new System.Windows.Forms.Button();
            this.btnQlLich = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDo = new System.Windows.Forms.Button();
            this.txtMaTiem = new System.Windows.Forms.TextBox();
            this.txtLL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(261, 143);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(320, 26);
            this.dtDate.TabIndex = 43;
            // 
            // menu
            // 
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.Location = new System.Drawing.Point(-2, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(218, 123);
            this.menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menu.TabIndex = 35;
            this.menu.TabStop = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtPhutrach
            // 
            this.txtPhutrach.Location = new System.Drawing.Point(858, 62);
            this.txtPhutrach.Name = "txtPhutrach";
            this.txtPhutrach.Size = new System.Drawing.Size(270, 26);
            this.txtPhutrach.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(854, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Bác sĩ phụ trách";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnF5);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnFix);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(261, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 299);
            this.panel2.TabIndex = 40;
            // 
            // btnF5
            // 
            this.btnF5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnF5.Location = new System.Drawing.Point(0, 155);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(141, 53);
            this.btnF5.TabIndex = 3;
            this.btnF5.Text = "F5";
            this.btnF5.UseVisualStyleBackColor = true;
            this.btnF5.Click += new System.EventHandler(this.btnF5_Click);
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDel.Location = new System.Drawing.Point(0, 102);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(141, 53);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnFix
            // 
            this.btnFix.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFix.Location = new System.Drawing.Point(0, 51);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(141, 51);
            this.btnFix.TabIndex = 1;
            this.btnFix.Text = "Sửa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 51);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ngày tiêm chủng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(436, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(717, 318);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(261, 62);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(320, 26);
            this.txtLoai.TabIndex = 37;
            // 
            // btnQlthuoc
            // 
            this.btnQlthuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQlthuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQlthuoc.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQlthuoc.Location = new System.Drawing.Point(0, 264);
            this.btnQlthuoc.Name = "btnQlthuoc";
            this.btnQlthuoc.Size = new System.Drawing.Size(216, 69);
            this.btnQlthuoc.TabIndex = 3;
            this.btnQlthuoc.Text = "Quản lý thuốc và chế độ điều trị";
            this.btnQlthuoc.UseVisualStyleBackColor = true;
            this.btnQlthuoc.Click += new System.EventHandler(this.btnQlthuoc_Click);
            // 
            // btnQlTT
            // 
            this.btnQlTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQlTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQlTT.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQlTT.Location = new System.Drawing.Point(0, 123);
            this.btnQlTT.Name = "btnQlTT";
            this.btnQlTT.Size = new System.Drawing.Size(216, 71);
            this.btnQlTT.TabIndex = 1;
            this.btnQlTT.Text = "Quản lý thông tin cơ bản ";
            this.btnQlTT.UseVisualStyleBackColor = true;
            this.btnQlTT.Click += new System.EventHandler(this.btnQlTT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Loại vắc xin";
            // 
            // btnBao
            // 
            this.btnBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBao.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBao.Location = new System.Drawing.Point(0, 410);
            this.btnBao.Name = "btnBao";
            this.btnBao.Size = new System.Drawing.Size(216, 77);
            this.btnBao.TabIndex = 5;
            this.btnBao.Text = "Báo cáo tổng quan hệ thống";
            this.btnBao.UseVisualStyleBackColor = true;
            this.btnBao.Click += new System.EventHandler(this.btnBao_Click);
            // 
            // btnQlLich
            // 
            this.btnQlLich.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQlLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQlLich.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnQlLich.Location = new System.Drawing.Point(0, 194);
            this.btnQlLich.Name = "btnQlLich";
            this.btnQlLich.Size = new System.Drawing.Size(216, 70);
            this.btnQlLich.TabIndex = 2;
            this.btnQlLich.Text = "Quản lý lịch tiêm chủng";
            this.btnQlLich.UseVisualStyleBackColor = true;
            this.btnQlLich.Click += new System.EventHandler(this.btnQlLich_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.menu);
            this.panel1.Controls.Add(this.btnBao);
            this.panel1.Controls.Add(this.btnDo);
            this.panel1.Controls.Add(this.btnQlthuoc);
            this.panel1.Controls.Add(this.btnQlLich);
            this.panel1.Controls.Add(this.btnQlTT);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 542);
            this.panel1.TabIndex = 35;
            // 
            // btnDo
            // 
            this.btnDo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDo.Location = new System.Drawing.Point(0, 333);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(216, 77);
            this.btnDo.TabIndex = 4;
            this.btnDo.Text = "Quản lý dữ liệu đo lường";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // txtMaTiem
            // 
            this.txtMaTiem.Location = new System.Drawing.Point(368, 12);
            this.txtMaTiem.Name = "txtMaTiem";
            this.txtMaTiem.Size = new System.Drawing.Size(133, 26);
            this.txtMaTiem.TabIndex = 44;
            // 
            // txtLL
            // 
            this.txtLL.Location = new System.Drawing.Point(641, 62);
            this.txtLL.Name = "txtLL";
            this.txtLL.Size = new System.Drawing.Size(167, 26);
            this.txtLL.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Liều lượng";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(641, 143);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(270, 26);
            this.txtNote.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(642, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Nhắc nhở";
            // 
            // FormLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 542);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaTiem);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.txtPhutrach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FormLich";
            this.Text = "FormLich";
            this.Load += new System.EventHandler(this.FormLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.PictureBox menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPhutrach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.Button btnQlthuoc;
        private System.Windows.Forms.Button btnQlTT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBao;
        private System.Windows.Forms.Button btnQlLich;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.TextBox txtMaTiem;
        private System.Windows.Forms.TextBox txtLL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnF5;
    }
}