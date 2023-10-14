namespace QLBV
{
    partial class FormTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            menuStrip1 = new MenuStrip();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            btnQLBN = new Button();
            btnQLNV = new Button();
            button3 = new Button();
            btnQLThuoc = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            btnThongKe = new Button();
            btThoat = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thôngTinToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1870, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(70, 20);
            thôngTinToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(145, 22);
            thôngTinCáNhânToolStripMenuItem.Text = "Đổi mật khẩu";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(145, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // btnQLBN
            // 
            btnQLBN.Anchor = AnchorStyles.None;
            btnQLBN.AutoSize = true;
            btnQLBN.BackColor = Color.FromArgb(128, 255, 255);
            btnQLBN.Location = new Point(709, 184);
            btnQLBN.Margin = new Padding(3, 2, 3, 2);
            btnQLBN.Name = "btnQLBN";
            btnQLBN.Size = new Size(164, 50);
            btnQLBN.TabIndex = 2;
            btnQLBN.Text = "Quản lý Bệnh nhân";
            btnQLBN.UseVisualStyleBackColor = false;
            btnQLBN.Click += btnQLBN_Click;
            // 
            // btnQLNV
            // 
            btnQLNV.Anchor = AnchorStyles.None;
            btnQLNV.AutoSize = true;
            btnQLNV.BackColor = Color.FromArgb(128, 255, 255);
            btnQLNV.Location = new Point(709, 306);
            btnQLNV.Margin = new Padding(3, 2, 3, 2);
            btnQLNV.Name = "btnQLNV";
            btnQLNV.Size = new Size(164, 50);
            btnQLNV.TabIndex = 3;
            btnQLNV.Text = "Quản lý Nhân viên";
            btnQLNV.UseVisualStyleBackColor = false;
            btnQLNV.Click += btnQLNV_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Location = new Point(992, 184);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(164, 50);
            button3.TabIndex = 4;
            button3.Text = "Quản lý Giường bênh";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnQLThuoc
            // 
            btnQLThuoc.Anchor = AnchorStyles.None;
            btnQLThuoc.AutoSize = true;
            btnQLThuoc.BackColor = Color.FromArgb(128, 255, 255);
            btnQLThuoc.Location = new Point(992, 306);
            btnQLThuoc.Margin = new Padding(3, 2, 3, 2);
            btnQLThuoc.Name = "btnQLThuoc";
            btnQLThuoc.Size = new Size(164, 50);
            btnQLThuoc.TabIndex = 5;
            btnQLThuoc.Text = "Quản lý Thuốc";
            btnQLThuoc.UseVisualStyleBackColor = false;
            btnQLThuoc.Click += btnQLThuoc_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.AutoSize = true;
            groupBox1.BackColor = Color.FromArgb(192, 255, 255);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(422, 503);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1048, 304);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giới thiệu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(145, 29);
            label1.Name = "label1";
            label1.Size = new Size(682, 252);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 255);
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(626, 104);
            label2.Name = "label2";
            label2.Size = new Size(623, 47);
            label2.TabIndex = 7;
            label2.Text = "PHẦN MỀM QUẢN LÝ BỆNH VIỆN ICTU";
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor = AnchorStyles.None;
            btnThongKe.AutoSize = true;
            btnThongKe.BackColor = Color.FromArgb(128, 255, 255);
            btnThongKe.Location = new Point(709, 413);
            btnThongKe.Margin = new Padding(3, 2, 3, 2);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(164, 50);
            btnThongKe.TabIndex = 8;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btThoat
            // 
            btThoat.Anchor = AnchorStyles.None;
            btThoat.AutoSize = true;
            btThoat.BackColor = Color.FromArgb(128, 255, 255);
            btThoat.Location = new Point(992, 413);
            btThoat.Margin = new Padding(3, 2, 3, 2);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(164, 50);
            btThoat.TabIndex = 9;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = false;
            btThoat.Click += btThoat_Click;
            // 
            // FormTrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_579484323_waaeF98BnKROG1Ez3iMVbkavZrPToMut;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1870, 857);
            Controls.Add(btThoat);
            Controls.Add(btnThongKe);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(btnQLThuoc);
            Controls.Add(button3);
            Controls.Add(btnQLNV);
            Controls.Add(btnQLBN);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ";
            Resize += FormTrangChu_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Button btnQLBN;
        private Button btnQLNV;
        private Button button3;
        private Button btnQLThuoc;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button btnThongKe;
        private Button btThoat;
    }
}