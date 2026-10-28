using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using BaiLam.Models;


// ---------------------------------------------------
// APP BỊ ĐƠ, MỖI LẦN THÊM SỬA XÓA XONG PHẢI TẮT APP MỞ LẠI MỚI CẬP NHẬT DỮ LIỆU
// ---------------------------------------------------  








namespace BaiLam
{
    public partial class Form1 : Form
    {
        private DuLieuContext _context;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        // yêu cầu 1
        private async void Form1_Load(object sender, EventArgs e)
        {
            _context = new DuLieuContext();
            await LoadDataAsync();

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }


        private async Task LoadDataAsync()
        {
            dataGridView1.DataSource = await _context.MonHoc.Select(m => new { m.MaMonHoc, m.TenMonHoc, m.SoTinChi }).ToListAsync();
        }





        // yêu cầu 3

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtSoTin_TextChanged(object sender, EventArgs e)
        {

        }

        // yêu cầu 5
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                txtMa.Text = selectedRow.Cells["MaMonHoc"].Value.ToString();
                txtTen.Text = selectedRow.Cells["TenMonHoc"].Value.ToString();
                txtSoTin.Text = selectedRow.Cells["SoTinChi"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // yêu cầu 6
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var maMonHoc = selectedRow.Cells["MaMonHoc"].Value.ToString();

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    var monHoc = _context.MonHoc.FirstOrDefault(m => m.MaMonHoc == maMonHoc);
                    if (monHoc != null)
                    {
                        _context.MonHoc.Remove(monHoc);
                        _context.SaveChanges();
                        LoadDataAsync().Wait();
                        txtMa.Clear();
                        txtTen.Clear();
                        txtSoTin.Clear();
                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                    }
                }
            }
        }

        // yêu cầu 4 và yêu cầu 2
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMonHoc = txtMa.Text.Trim();
            string tenMonHoc = txtTen.Text.Trim();
            string soTinChi = txtSoTin.Text.Trim();

            if (string.IsNullOrEmpty(maMonHoc) || string.IsNullOrEmpty(tenMonHoc) || string.IsNullOrEmpty(soTinChi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_context.MonHoc.Any(m => m.MaMonHoc == maMonHoc))
            {
                MessageBox.Show("Mã môn học đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //yêu cầu 2
            if (!decimal.TryParse(soTinChi, out decimal soTinChiValue))
            {
                MessageBox.Show("Số tín chỉ phải là số thực hoặc số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newMonHoc = new MonHoc
            {
                MaMonHoc = maMonHoc,
                TenMonHoc = tenMonHoc,
                SoTinChi = soTinChi
            };
            _context.MonHoc.Add(newMonHoc);
            _context.SaveChanges();
            LoadDataAsync().Wait();
            txtMa.Clear();
            txtTen.Clear();
            txtSoTin.Clear();
        }

        // yêu cầu 7
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var maMonHoc = selectedRow.Cells["MaMonHoc"].Value.ToString();
                var monHoc = _context.MonHoc.FirstOrDefault(m => m.MaMonHoc == maMonHoc);
                if (monHoc != null)
                {
                    string tenMonHoc = txtTen.Text.Trim();
                    string soTinChi = txtSoTin.Text.Trim();
                    if (string.IsNullOrEmpty(tenMonHoc) || string.IsNullOrEmpty(soTinChi))
                    {
                        MessageBox.Show("Vui lòng điền đầy đủ thông tin môn học.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!decimal.TryParse(soTinChi, out decimal soTinChiValue))
                    {
                        MessageBox.Show("Số tín chỉ phải là số thực hoặc số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    monHoc.TenMonHoc = tenMonHoc;
                    monHoc.SoTinChi = soTinChi;
                    _context.SaveChanges();
                    LoadDataAsync().Wait();
                }
            }
        }
    }
}
