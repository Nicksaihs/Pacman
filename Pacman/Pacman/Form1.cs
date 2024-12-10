namespace Pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool up = false;
        bool down = false;
        bool left = false;
        bool right = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Enabled = true;


        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            up = down = left = right = false;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    PicMan.Image = Image.FromFile("pacmanup.png");
                    up = true;
                    break;
                case Keys.Down:
                    PicMan.Image = Image.FromFile("pacmandown.png");
                    down = true;
                    break;
                case Keys.Left:
                    PicMan.Image = Image.FromFile("pacmanleft.png");
                    left = true;
                    break;
                case Keys.Right:
                    PicMan.Image = Image.FromFile("pacman.png");
                    right = true;
                    break;
            }

        }

        int speed = 1;
        int score = 0;
        bool[] iscoin = { false, false, false, false, false, false, false, false };
        
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (PicMan.Location.Y >= 80 && PicMan.Location.Y <= 630 || PicMan.Location.X >= 30 && PicMan.Location.X <= 980)
            {
                if (up)
                {
                    PicMan.Top -= speed;
                    if (PicMan.Location.Y < 81) { up = false; }
                }
                else if (down)
                {
                    PicMan.Top += speed;
                    if (PicMan.Location.Y > 579) { down = false; }
                }
                else if (left)
                {
                    PicMan.Left -= speed;
                    if (PicMan.Location.X < 31) { left = false; }
                }
                else if (right)
                {
                    PicMan.Left += speed;
                    if (PicMan.Location.X > 929) { right = false; }
                }

            }



            if (PicMan.Bounds.IntersectsWith(coin0.Bounds))
            {
                coin0.Visible = false;
                if (!iscoin[0])
                {
                    score = score + 1;
                    iscoin[0] = true;
                }
            }
            if (PicMan.Bounds.IntersectsWith(coin1.Bounds))
            {
                coin1.Visible = false;
                if (!iscoin[1])
                {
                    score = score + 1;
                    iscoin[1] = true;
                }
            }
            if (PicMan.Bounds.IntersectsWith(coin2.Bounds))
            {
                coin2.Visible = false;
                if (!iscoin[2])
                {
                    score = score + 1;
                    iscoin[2] = true;
                }
            }
            if (PicMan.Bounds.IntersectsWith(coin3.Bounds))
            {
                coin3.Visible = false;
                if (!iscoin[3])
                {
                    score = score + 1;
                    iscoin[3] = true;
                }
            }
            if (PicMan.Bounds.IntersectsWith(coin4.Bounds))
            {
                coin4.Visible = false;
                if (!iscoin[4])
                {
                    score = score + 1;
                    iscoin[4] = true;
                }
            }
            if (PicMan.Bounds.IntersectsWith(coin5.Bounds))
            {
                coin5.Visible = false;
                if (!iscoin[5])
                {
                    score = score + 1;
                    iscoin[5] = true;
                }
            }
            if (PicMan.Bounds.IntersectsWith(coin6.Bounds))
            {
                coin6.Visible = false;
                if (!iscoin[6])
                {
                    score = score + 1;
                    iscoin[6] = true;
                }
            }
            if (PicMan.Bounds.IntersectsWith(coin7.Bounds))
            {
                coin7.Visible = false;
                if (!iscoin[7])
                {
                    score = score + 1;
                    iscoin[7] = true;
                }
            }
           

            label2.Text = "X¡G" + PicMan.Location.X + " Y¡G" + PicMan.Location.Y;
            label1.Text = "Score " + score;
        }
        private void iseating(PictureBox pictureBox1,PictureBox pictureBox2)
        {
            
        }

    }
}