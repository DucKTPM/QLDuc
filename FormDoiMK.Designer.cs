namespace QLBV
{
    partial class FormDoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMK));
            label1 = new Label();
            txbUserName = new TextBox();
            txbPass = new TextBox();
            label2 = new Label();
            txbNewPass = new TextBox();
            label3 = new Label();
            txbReNewPass = new TextBox();
            label4 = new Label();
            label6 = new Label();
            btnUpdate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 96);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(301, 96);
            txbUserName.Margin = new Padding(3, 2, 3, 2);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(160, 23);
            txbUserName.TabIndex = 1;
            // 
            // txbPass
            // 
            txbPass.Location = new Point(301, 146);
            txbPass.Margin = new Padding(3, 2, 3, 2);
            txbPass.Name = "txbPass";
            txbPass.PasswordChar = '*';
            txbPass.Size = new Size(160, 23);
            txbPass.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 146);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // txbNewPass
            // 
            txbNewPass.Location = new Point(301, 190);
            txbNewPass.Margin = new Padding(3, 2, 3, 2);
            txbNewPass.Name = "txbNewPass";
            txbNewPass.PasswordChar = '*';
            txbNewPass.Size = new Size(160, 23);
            txbNewPass.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 190);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu mới";
            // 
            // txbReNewPass
            // 
            txbReNewPass.Location = new Point(301, 237);
            txbReNewPass.Margin = new Padding(3, 2, 3, 2);
            txbReNewPass.Name = "txbReNewPass";
            txbReNewPass.PasswordChar = '*';
            txbReNewPass.Size = new Size(160, 23);
            txbReNewPass.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 237);
            label4.Name = "label4";
            label4.Size = new Size(128, 15);
            label4.TabIndex = 6;
            label4.Text = "Nhập lại mật khẩu mới";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(255, 40);
            label6.Name = "label6";
            label6.Size = new Size(138, 30);
            label6.TabIndex = 10;
            label6.Text = "Đổi mật khẩu";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(129, 299);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 32);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(329, 299);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 32);
            btnExit.TabIndex = 12;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // FormDoiMK
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(591, 414);
            Controls.Add(btnExit);
            Controls.Add(btnUpdate);
            Controls.Add(label6);
            Controls.Add(txbReNewPass);
            Controls.Add(label4);
            Controls.Add(txbNewPass);
            Controls.Add(label3);
            Controls.Add(txbPass);
            Controls.Add(label2);
            Controls.Add(txbUserName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDoiMK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi mật khẩu";
            Load += FormTTCaNhan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbUserName;
        private TextBox txbPass;
        private Label label2;
        private TextBox txbNewPass;
        private Label label3;
        private TextBox txbReNewPass;
        private Label label4;
        private Label label6;
        private Button btnUpdate;
        private Button btnExit;
    }
}