namespace BaiLam
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
            txtMa = new TextBox();
            txtTen = new TextBox();
            txtSoTin = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtMa
            // 
            txtMa.Location = new Point(27, 89);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(150, 31);
            txtMa.TabIndex = 0;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(27, 172);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(150, 31);
            txtTen.TabIndex = 1;
            // 
            // txtSoTin
            // 
            txtSoTin.Location = new Point(27, 244);
            txtSoTin.Name = "txtSoTin";
            txtSoTin.Size = new Size(150, 31);
            txtSoTin.TabIndex = 2;
            txtSoTin.TextChanged += txtSoTin_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(290, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(467, 388);
            dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 4;
            label1.Text = "Thông tin môn học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 50);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 5;
            label2.Text = "Mã môn học:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 132);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 6;
            label3.Text = "Tên môn học:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 216);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 7;
            label4.Text = "Số tín chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 9);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 8;
            label5.Text = "Danh sách môn học";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(142, 299);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 58);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(27, 363);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 58);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(142, 363);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(90, 58);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 299);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 58);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThem);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtSoTin);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtSoTin;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}
