namespace ChamCong
{
    partial class ThongKe
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
            components = new System.ComponentModel.Container();
            btn_In = new Button();
            grid_TK = new DataGridView();
            label1 = new Label();
            btn_TimKiem = new Button();
            cbo_Ngay = new ComboBox();
            notifyIcon1 = new NotifyIcon(components);
            txt_TimKiem = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grid_TK).BeginInit();
            SuspendLayout();
            // 
            // btn_In
            // 
            btn_In.Anchor = AnchorStyles.Bottom;
            btn_In.Location = new Point(325, 376);
            btn_In.Name = "btn_In";
            btn_In.Size = new Size(163, 62);
            btn_In.TabIndex = 0;
            btn_In.Text = "In";
            btn_In.UseVisualStyleBackColor = true;
            btn_In.Click += btn_In_Click;
            // 
            // grid_TK
            // 
            grid_TK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            grid_TK.BackgroundColor = Color.White;
            grid_TK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_TK.Location = new Point(12, 129);
            grid_TK.Margin = new Padding(3, 2, 3, 2);
            grid_TK.Name = "grid_TK";
            grid_TK.RowHeadersWidth = 51;
            grid_TK.Size = new Size(757, 184);
            grid_TK.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 21);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 2;
            label1.Text = "Thống kê";
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Anchor = AnchorStyles.Top;
            btn_TimKiem.Location = new Point(654, 84);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(117, 40);
            btn_TimKiem.TabIndex = 3;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // cbo_Ngay
            // 
            cbo_Ngay.Anchor = AnchorStyles.Top;
            cbo_Ngay.FormattingEnabled = true;
            cbo_Ngay.Location = new Point(12, 101);
            cbo_Ngay.Name = "cbo_Ngay";
            cbo_Ngay.Size = new Size(172, 23);
            cbo_Ngay.TabIndex = 4;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Anchor = AnchorStyles.Top;
            txt_TimKiem.Location = new Point(190, 101);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(279, 23);
            txt_TimKiem.TabIndex = 5;
            // 
            // ThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 450);
            Controls.Add(txt_TimKiem);
            Controls.Add(cbo_Ngay);
            Controls.Add(btn_TimKiem);
            Controls.Add(label1);
            Controls.Add(grid_TK);
            Controls.Add(btn_In);
            Name = "ThongKe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThongKe";
            Load += ThongKe_Load;
            ((System.ComponentModel.ISupportInitialize)grid_TK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_In;
        private DataGridView grid_TK;
        private Label label1;
        private Button btn_TimKiem;
        private ComboBox cbo_Ngay;
        private NotifyIcon notifyIcon1;
        private TextBox txt_TimKiem;
    }
}