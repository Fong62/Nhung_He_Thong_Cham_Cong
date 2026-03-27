namespace ChamCong
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (ThongKe form = new ThongKe())
            {
                form.ShowDialog();
            }
            this.Show();
        }
    }
}
