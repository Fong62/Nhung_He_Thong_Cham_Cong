namespace ChamCong
{
    partial class ChamCong
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
            grid_CC = new DataGridView();
            buttonLamMoi = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)grid_CC).BeginInit();
            SuspendLayout();
            // 
            // grid_CC
            // 
            grid_CC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            grid_CC.BackgroundColor = Color.White;
            grid_CC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_CC.Location = new Point(12, 102);
            grid_CC.Margin = new Padding(3, 2, 3, 2);
            grid_CC.Name = "grid_CC";
            grid_CC.RowHeadersWidth = 51;
            grid_CC.Size = new Size(656, 184);
            grid_CC.TabIndex = 0;
            // 
            // buttonLamMoi
            // 
            buttonLamMoi.Anchor = AnchorStyles.Bottom;
            buttonLamMoi.Location = new Point(270, 387);
            buttonLamMoi.Margin = new Padding(3, 2, 3, 2);
            buttonLamMoi.Name = "buttonLamMoi";
            buttonLamMoi.Size = new Size(163, 62);
            buttonLamMoi.TabIndex = 1;
            buttonLamMoi.Text = "Làm mới";
            buttonLamMoi.UseVisualStyleBackColor = true;
            buttonLamMoi.Click += buttonLamMoi_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 34);
            label1.Name = "label1";
            label1.Size = new Size(154, 31);
            label1.TabIndex = 2;
            label1.Text = "Chấm Công";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // ChamCong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 460);
            Controls.Add(label1);
            Controls.Add(buttonLamMoi);
            Controls.Add(grid_CC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChamCong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chấm công";
            Load += ChamCong_Load;
            ((System.ComponentModel.ISupportInitialize)grid_CC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grid_CC;
        private Button buttonLamMoi;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}