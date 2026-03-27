namespace ChamCong
{
    partial class DangNhap
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
            label1 = new Label();
            label2 = new Label();
            textTenDN = new TextBox();
            label3 = new Label();
            textMK = new TextBox();
            buttonDN = new Button();
            buttonThoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 23);
            label1.Name = "label1";
            label1.Size = new Size(142, 31);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(201, 104);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            label2.Click += label2_Click;
            // 
            // textTenDN
            // 
            textTenDN.Anchor = AnchorStyles.Top;
            textTenDN.Location = new Point(316, 104);
            textTenDN.Margin = new Padding(3, 2, 3, 2);
            textTenDN.Name = "textTenDN";
            textTenDN.Size = new Size(154, 23);
            textTenDN.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(229, 144);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            // 
            // textMK
            // 
            textMK.Anchor = AnchorStyles.Top;
            textMK.Location = new Point(316, 141);
            textMK.Margin = new Padding(3, 2, 3, 2);
            textMK.Name = "textMK";
            textMK.Size = new Size(154, 23);
            textMK.TabIndex = 4;
            // 
            // buttonDN
            // 
            buttonDN.Anchor = AnchorStyles.Top;
            buttonDN.Location = new Point(269, 202);
            buttonDN.Margin = new Padding(3, 2, 3, 2);
            buttonDN.Name = "buttonDN";
            buttonDN.Size = new Size(82, 42);
            buttonDN.TabIndex = 5;
            buttonDN.Text = "Đăng nhập";
            buttonDN.UseVisualStyleBackColor = true;
            buttonDN.Click += buttonDN_Click;
            // 
            // buttonThoat
            // 
            buttonThoat.Anchor = AnchorStyles.Top;
            buttonThoat.Location = new Point(397, 202);
            buttonThoat.Margin = new Padding(3, 2, 3, 2);
            buttonThoat.Name = "buttonThoat";
            buttonThoat.Size = new Size(82, 42);
            buttonThoat.TabIndex = 6;
            buttonThoat.Text = "Thoát";
            buttonThoat.UseVisualStyleBackColor = true;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 298);
            Controls.Add(buttonThoat);
            Controls.Add(buttonDN);
            Controls.Add(textMK);
            Controls.Add(label3);
            Controls.Add(textTenDN);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textTenDN;
        private Label label3;
        private TextBox textMK;
        private Button buttonDN;
        private Button buttonThoat;
    }
}