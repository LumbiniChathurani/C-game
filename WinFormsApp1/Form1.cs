namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random r = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
            x = r.Next(0, 600);
            y = r.Next(200, 400);
            pictureBox1.Location = new Point(x, y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
