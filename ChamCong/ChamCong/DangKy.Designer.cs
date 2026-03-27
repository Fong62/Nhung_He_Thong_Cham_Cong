namespace ChamCong
{
    partial class DangKy
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
            label1 = new Label();
            label2 = new Label();
            textID = new TextBox();
            textTenNV = new TextBox();
            label3 = new Label();
            grid_NV = new DataGridView();
            label4 = new Label();
            buttonCapNhat = new Button();
            btn_LamMoi = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)grid_NV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 32);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(132, 98);
            label2.Name = "label2";
            label2.Size = new Size(39, 13);
            label2.TabIndex = 1;
            label2.Text = "ID thẻ:";
            // 
            // textID
            // 
            textID.Anchor = AnchorStyles.Top;
            textID.Location = new Point(232, 96);
            textID.Margin = new Padding(3, 2, 3, 2);
            textID.Name = "textID";
            textID.Size = new Size(178, 23);
            textID.TabIndex = 2;
            // 
            // textTenNV
            // 
            textTenNV.Anchor = AnchorStyles.Top;
            textTenNV.Location = new Point(232, 140);
            textTenNV.Margin = new Padding(3, 2, 3, 2);
            textTenNV.Name = "textTenNV";
            textTenNV.Size = new Size(178, 23);
            textTenNV.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(132, 143);
            label3.Name = "label3";
            label3.Size = new Size(79, 13);
            label3.TabIndex = 3;
            label3.Text = "Tên nhân viên:";
            // 
            // grid_NV
            // 
            grid_NV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            grid_NV.BackgroundColor = Color.White;
            grid_NV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_NV.Location = new Point(519, 96);
            grid_NV.Margin = new Padding(3, 2, 3, 2);
            grid_NV.Name = "grid_NV";
            grid_NV.RowHeadersWidth = 51;
            grid_NV.Size = new Size(297, 147);
            grid_NV.TabIndex = 5;
            grid_NV.CellContentClick += grid_NV_CellContentClick;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(519, 64);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Thông tin :";
            // 
            // buttonCapNhat
            // 
            buttonCapNhat.Anchor = AnchorStyles.Top;
            buttonCapNhat.Location = new Point(132, 219);
            buttonCapNhat.Margin = new Padding(3, 2, 3, 2);
            buttonCapNhat.Name = "buttonCapNhat";
            buttonCapNhat.Size = new Size(130, 64);
            buttonCapNhat.TabIndex = 7;
            buttonCapNhat.Text = "Cập nhật";
            buttonCapNhat.UseVisualStyleBackColor = true;
            buttonCapNhat.Click += buttonCapNhat_Click;
            // 
            // btn_LamMoi
            // 
            btn_LamMoi.Anchor = AnchorStyles.Top;
            btn_LamMoi.Location = new Point(315, 219);
            btn_LamMoi.Margin = new Padding(3, 2, 3, 2);
            btn_LamMoi.Name = "btn_LamMoi";
            btn_LamMoi.Size = new Size(130, 64);
            btn_LamMoi.TabIndex = 8;
            btn_LamMoi.Text = "Làm mới";
            btn_LamMoi.UseVisualStyleBackColor = true;
            btn_LamMoi.Click += btn_LamMoi_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 338);
            Controls.Add(btn_LamMoi);
            Controls.Add(buttonCapNhat);
            Controls.Add(label4);
            Controls.Add(grid_NV);
            Controls.Add(textTenNV);
            Controls.Add(label3);
            Controls.Add(textID);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangKy";
            Load += DangKy_Load;
            ((System.ComponentModel.ISupportInitialize)grid_NV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textID;
        private TextBox textTenNV;
        private Label label3;
        private DataGridView grid_NV;
        private Label label4;
        private Button buttonCapNhat;
        private Button btn_LamMoi;
        private System.Windows.Forms.Timer timer1;
    }
}