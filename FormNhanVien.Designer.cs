namespace QLBV
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            label1 = new Label();
            dtgvNV = new DataGridView();
            btnSearch = new Button();
            txbSearch = new TextBox();
            cbbSearch = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            btnExportExcel = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dtgvNV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(566, 19);
            label1.Name = "label1";
            label1.Size = new Size(188, 50);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên";
            // 
            // dtgvNV
            // 
            dtgvNV.BackgroundColor = Color.FromArgb(192, 255, 255);
            dtgvNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvNV.Location = new Point(514, 185);
            dtgvNV.Margin = new Padding(3, 2, 3, 2);
            dtgvNV.Name = "dtgvNV";
            dtgvNV.RowHeadersWidth = 51;
            dtgvNV.RowTemplate.Height = 29;
            dtgvNV.Size = new Size(560, 322);
            dtgvNV.TabIndex = 1;
            dtgvNV.CellClick += dtgvNV_CellClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(128, 255, 255);
            btnSearch.Location = new Point(927, 101);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 58);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(739, 136);
            txbSearch.Margin = new Padding(3, 2, 3, 2);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(133, 23);
            txbSearch.TabIndex = 3;
            // 
            // cbbSearch
            // 
            cbbSearch.FormattingEnabled = true;
            cbbSearch.Items.AddRange(new object[] { "maNV", "hoTen", "gioiTinh", "chucVu", "sdt", "queQuan", "diaChi" });
            cbbSearch.Location = new Point(739, 98);
            cbbSearch.Margin = new Padding(3, 2, 3, 2);
            cbbSearch.Name = "cbbSearch";
            cbbSearch.Size = new Size(133, 23);
            cbbSearch.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 255);
            btnAdd.Location = new Point(402, 271);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 58);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 255, 255);
            btnUpdate.Location = new Point(402, 185);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 58);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 255, 255);
            btnDelete.Location = new Point(402, 361);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 58);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 255, 255);
            btnExit.Location = new Point(402, 449);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 58);
            btnExit.TabIndex = 9;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.FromArgb(192, 255, 255);
            btnExportExcel.Location = new Point(402, 116);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(94, 29);
            btnExportExcel.TabIndex = 10;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.doctor;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1234, 707);
            Controls.Add(btnExportExcel);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbbSearch);
            Controls.Add(txbSearch);
            Controls.Add(btnSearch);
            Controls.Add(dtgvNV);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân viên";
            Load += FormNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgvNV;
        private Button btnSearch;
        private TextBox txbSearch;
        private ComboBox cbbSearch;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Button btnExportExcel;
        private SaveFileDialog saveFileDialog1;
    }
}