namespace QLBV
{
    partial class FormQuanLyBenhNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyBenhNhan));
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cbbSearch = new ComboBox();
            txbSearch = new TextBox();
            btnSearch = new Button();
            dtgvBN = new DataGridView();
            label1 = new Label();
            btnBenhAn = new Button();
            btnHoaDon = new Button();
            label2 = new Label();
            Reloadform = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgvBN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.FromArgb(192, 255, 255);
            btnExit.Location = new Point(1028, 511);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(85, 24);
            btnExit.TabIndex = 18;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.FromArgb(192, 255, 255);
            btnDelete.Location = new Point(917, 446);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(64, 27);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.FromArgb(192, 255, 255);
            btnUpdate.Location = new Point(839, 447);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(72, 26);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.FromArgb(192, 255, 255);
            btnAdd.Location = new Point(772, 448);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 26);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbbSearch
            // 
            cbbSearch.Anchor = AnchorStyles.None;
            cbbSearch.FormattingEnabled = true;
            cbbSearch.Items.AddRange(new object[] { "maBN", "hoTen", "gioiTinh", "ngaySinh", "cccd", "ngheNghiep", "sdt", "bhyt", "diaChi" });
            cbbSearch.Location = new Point(796, 74);
            cbbSearch.Margin = new Padding(3, 2, 3, 2);
            cbbSearch.Name = "cbbSearch";
            cbbSearch.Size = new Size(133, 23);
            cbbSearch.TabIndex = 14;
            cbbSearch.Text = "Chọn giá trị tìm kiếm";
            // 
            // txbSearch
            // 
            txbSearch.Anchor = AnchorStyles.None;
            txbSearch.Location = new Point(796, 127);
            txbSearch.Margin = new Padding(3, 2, 3, 2);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(133, 23);
            txbSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.BackColor = Color.FromArgb(192, 255, 255);
            btnSearch.Location = new Point(954, 74);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 76);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtgvBN
            // 
            dtgvBN.Anchor = AnchorStyles.None;
            dtgvBN.BackgroundColor = Color.FromArgb(192, 255, 255);
            dtgvBN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBN.Location = new Point(30, 74);
            dtgvBN.Margin = new Padding(3, 2, 3, 2);
            dtgvBN.Name = "dtgvBN";
            dtgvBN.RowHeadersWidth = 51;
            dtgvBN.RowTemplate.Height = 29;
            dtgvBN.Size = new Size(727, 461);
            dtgvBN.TabIndex = 11;
            dtgvBN.CellClick += dtgvBN_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, -76);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 10;
            label1.Text = "Nhân viên";
            // 
            // btnBenhAn
            // 
            btnBenhAn.Anchor = AnchorStyles.None;
            btnBenhAn.BackColor = Color.FromArgb(192, 255, 255);
            btnBenhAn.Location = new Point(987, 446);
            btnBenhAn.Margin = new Padding(3, 2, 3, 2);
            btnBenhAn.Name = "btnBenhAn";
            btnBenhAn.Size = new Size(61, 29);
            btnBenhAn.TabIndex = 19;
            btnBenhAn.Text = "Bệnh án";
            btnBenhAn.UseVisualStyleBackColor = false;
            btnBenhAn.Click += btnBenhAn_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Anchor = AnchorStyles.None;
            btnHoaDon.BackColor = Color.FromArgb(192, 255, 255);
            btnHoaDon.Location = new Point(1062, 446);
            btnHoaDon.Margin = new Padding(3, 2, 3, 2);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(61, 29);
            btnHoaDon.TabIndex = 20;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(499, 9);
            label2.Name = "label2";
            label2.Size = new Size(284, 43);
            label2.TabIndex = 21;
            label2.Text = "Quản lý bệnh nhân";
            label2.Click += label2_Click;
            // 
            // Reloadform
            // 
            Reloadform.Anchor = AnchorStyles.None;
            Reloadform.BackColor = Color.FromArgb(128, 255, 255);
            Reloadform.Location = new Point(30, 42);
            Reloadform.Margin = new Padding(3, 2, 3, 2);
            Reloadform.Name = "Reloadform";
            Reloadform.Size = new Size(118, 28);
            Reloadform.TabIndex = 22;
            Reloadform.Text = "Reload";
            Reloadform.UseVisualStyleBackColor = false;
            Reloadform.Click += Reloadform_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.pngtree_avatar_vector_icon_white_background_png_image_1884971;
            pictureBox2.Location = new Point(796, 189);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // FormQuanLyBenhNhan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources._0834_jpg_wh1200;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1135, 551);
            Controls.Add(pictureBox2);
            Controls.Add(Reloadform);
            Controls.Add(label2);
            Controls.Add(btnHoaDon);
            Controls.Add(btnBenhAn);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cbbSearch);
            Controls.Add(txbSearch);
            Controls.Add(btnSearch);
            Controls.Add(dtgvBN);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormQuanLyBenhNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý bênh nhân";
            Load += FormQuanLyBenhNhan_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvBN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cbbSearch;
        private TextBox txbSearch;
        private Button btnSearch;
        private DataGridView dtgvBN;
        private Label label1;
        private Button btnBenhAn;
        private Button btnHoaDon;
        private Label label2;
        private Button Reloadform;
        private PictureBox pictureBox2;
        private DataGridView dataGridView2;
    }
}