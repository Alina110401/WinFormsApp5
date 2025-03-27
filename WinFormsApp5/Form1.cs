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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button90_Click(object sender, EventArgs e)
        {
           
        }

        private void button180_Click(object sender, EventArgs e)
        {
       

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_rotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                // zmiana 
                pictureBox1.Refresh();
            }

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                // zmiana 
                pictureBox1.Refresh();
            }
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                // zmiana 
                pictureBox1.Refresh();
            }
        }

        private void button270_Click(object sender, EventArgs e)
        {
           


        }
    }
}
