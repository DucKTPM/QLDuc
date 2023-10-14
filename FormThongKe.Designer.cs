namespace QLBV
{
    partial class FormThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            label1 = new Label();
            dtgvThongKe = new DataGridView();
            dtpkFrom = new DateTimePicker();
            dtpkTo = new DateTimePicker();
            btnThongKe = new Button();
            btnExport = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(526, 9);
            label1.Name = "label1";
            label1.Size = new Size(233, 37);
            label1.TabIndex = 0;
            label1.Text = "Thống kê hóa đơn";
            // 
            // dtgvThongKe
            // 
            dtgvThongKe.BackgroundColor = Color.White;
            dtgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvThongKe.Location = new Point(10, 128);
            dtgvThongKe.Margin = new Padding(3, 2, 3, 2);
            dtgvThongKe.Name = "dtgvThongKe";
            dtgvThongKe.RowHeadersWidth = 51;
            dtgvThongKe.RowTemplate.Height = 29;
            dtgvThongKe.Size = new Size(1355, 534);
            dtgvThongKe.TabIndex = 1;
            // 
            // dtpkFrom
            // 
            dtpkFrom.Location = new Point(147, 70);
            dtpkFrom.Margin = new Padding(3, 2, 3, 2);
            dtpkFrom.Name = "dtpkFrom";
            dtpkFrom.Size = new Size(135, 23);
            dtpkFrom.TabIndex = 2;
            // 
            // dtpkTo
            // 
            dtpkTo.Location = new Point(371, 70);
            dtpkTo.Margin = new Padding(3, 2, 3, 2);
            dtpkTo.Name = "dtpkTo";
            dtpkTo.Size = new Size(135, 23);
            dtpkTo.TabIndex = 3;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(128, 255, 255);
            btnThongKe.Location = new Point(601, 70);
            btnThongKe.Margin = new Padding(3, 2, 3, 2);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(82, 22);
            btnThongKe.TabIndex = 4;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(128, 255, 255);
            btnExport.Location = new Point(768, 70);
            btnExport.Margin = new Padding(3, 2, 3, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(82, 22);
            btnExport.TabIndex = 5;
            btnExport.Text = "Xuất Excel";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 74);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 74);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 7;
            label3.Text = "Đến ngày:";
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1377, 664);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnExport);
            Controls.Add(btnThongKe);
            Controls.Add(dtpkTo);
            Controls.Add(dtpkFrom);
            Controls.Add(dtgvThongKe);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)dtgvThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgvThongKe;
        private DateTimePicker dtpkFrom;
        private DateTimePicker dtpkTo;
        private Button btnThongKe;
        private Button btnExport;
        private Label label2;
        private Label label3;
    }
}