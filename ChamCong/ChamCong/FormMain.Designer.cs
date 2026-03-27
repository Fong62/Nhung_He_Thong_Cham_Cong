using System.Drawing.Printing;

namespace ChamCong
{
    partial class FormMain
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

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (DangKy form = new DangKy())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        private void buttonChamCong_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ChamCong form = new ChamCong())
            {
                form.ShowDialog();
            }
            this.Show();
        }

        #region Windows Form Designer generated code



        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDangKy = new Button();
            buttonThongKe = new Button();
            buttonChamCong = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnDangKy
            // 
            btnDangKy.Anchor = AnchorStyles.Top;
            btnDangKy.Location = new Point(142, 93);
            btnDangKy.Margin = new Padding(3, 2, 3, 2);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(103, 67);
            btnDangKy.TabIndex = 0;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // buttonThongKe
            // 
            buttonThongKe.Anchor = AnchorStyles.Top;
            buttonThongKe.Location = new Point(477, 93);
            buttonThongKe.Margin = new Padding(3, 2, 3, 2);
            buttonThongKe.Name = "buttonThongKe";
            buttonThongKe.Size = new Size(103, 67);
            buttonThongKe.TabIndex = 1;
            buttonThongKe.Text = "Thông kê";
            buttonThongKe.UseVisualStyleBackColor = true;
            buttonThongKe.Click += buttonThongKe_Click;
            // 
            // buttonChamCong
            // 
            buttonChamCong.Anchor = AnchorStyles.Top;
            buttonChamCong.Location = new Point(303, 93);
            buttonChamCong.Margin = new Padding(3, 2, 3, 2);
            buttonChamCong.Name = "buttonChamCong";
            buttonChamCong.Size = new Size(103, 67);
            buttonChamCong.TabIndex = 2;
            buttonChamCong.Text = "Chấm công";
            buttonChamCong.UseVisualStyleBackColor = true;
            buttonChamCong.Click += buttonChamCong_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(316, 21);
            label1.Name = "label1";
            label1.Size = new Size(81, 31);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 230);
            Controls.Add(label1);
            Controls.Add(buttonChamCong);
            Controls.Add(buttonThongKe);
            Controls.Add(btnDangKy);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangKy;
        private Button buttonThongKe;
        private Button buttonChamCong;
        private Label label1;
    }
}
