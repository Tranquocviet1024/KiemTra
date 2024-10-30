using System.Windows.Forms;

namespace KiemTra
{
    public partial class Form1 : Form
    {
        private List<Product> listSanPham = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private string? selectedProductImagePath = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo DataGridView với danh sách sản phẩm ban đầu (rỗng)
            dataGridView1.DataSource = listSanPham;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenSanPham = txtTen.Text;
                decimal giaSanPham = decimal.Parse(txtGia.Text);
                int soLuong = int.Parse(txtSoLuong.Text);

                Product product = new Product(tenSanPham, giaSanPham, soLuong, selectedProductImagePath);
                listSanPham.Add(product);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = listSanPham;

            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng cho giá và số lượng.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnChonAnh_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn Ảnh Sản Phẩm";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(imagePath);

                   
                    selectedProductImagePath = imagePath;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                
                int rowIndex = dataGridView1.CurrentRow.Index;

                
                if (rowIndex >= 0 && rowIndex < listSanPham.Count)
                {
                    
                    listSanPham.RemoveAt(rowIndex);

                   
                    dataGridView1.DataSource = null; 
                    dataGridView1.DataSource = listSanPham; 

                    MessageBox.Show("Sản phẩm đã được xóa.");
                }
                else
                {
                    MessageBox.Show("Chỉ số không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (var product in listSanPham)
            {
                total += product.Price * product.Quantity;
            }
            MessageBox.Show($"Tổng tiền thanh toán: {total:C}", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listSanPham.Clear(); // Xóa sạch giỏ hàng sau khi thanh toán
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listSanPham;

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
