 namespace KiemTra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            txtGia = new TextBox();
            label3 = new Label();
            txtSoLuong = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnXoa = new Button();
            btnThanhToan = new Button();
            label4 = new Label();
            btnChonAnh = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 39);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên Sản Phẩm:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(177, 36);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(154, 23);
            txtTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 73);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "Giá:";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(177, 73);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(154, 23);
            txtGia.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 115);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(177, 115);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(93, 23);
            txtSoLuong.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(177, 173);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(356, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(382, 169);
            dataGridView1.TabIndex = 7;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(105, 322);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(303, 322);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(501, 322);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(97, 23);
            btnThanhToan.TabIndex = 10;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 173);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 11;
            label4.Text = "Ảnh :";
            label4.Click += label4_Click;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(67, 238);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(75, 23);
            btnChonAnh.TabIndex = 12;
            btnChonAnh.Text = "Chọn Ảnh";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click_1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(303, 384);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 451);
            Controls.Add(btnThoat);
            Controls.Add(btnChonAnh);
            Controls.Add(label4);
            Controls.Add(btnThanhToan);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(txtSoLuong);
            Controls.Add(label3);
            Controls.Add(txtGia);
            Controls.Add(label2);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtGia;
        private Label label3;
        private TextBox txtSoLuong;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThanhToan;
        private Label label4;
        private Button btnChonAnh;
        private Button btnThoat;
    }
}
