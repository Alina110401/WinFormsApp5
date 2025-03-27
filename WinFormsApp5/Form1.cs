namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sciezkaObrazu = @"C:\Users\User\Desktop\wizual\Obrazek_Piesek.jpg";

            pictureBox1.Image = Image.FromFile(sciezkaObrazu);
pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button_image_Click(object sender, EventArgs e)
        {
 

        }
    }
}
