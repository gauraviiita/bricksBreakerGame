namespace bricsBreaker
{
    public partial class frmAranoid : Form
    {
        List<Brick> bricks;
        const int NumOfBricks = 20;
        Paddle paddle;
        Ball ball;

        public frmAranoid()
        {
            InitializeComponent();
            bricks = new List<Brick>();
            paddle = new Paddle(this);
            ball = new Ball(this, picBall, paddle);
            DoubleBuffered = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < NumOfBricks; i++)
            {
                bricks.Add(new Brick(this));
                Thread.Sleep(10);
            }
        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            paddle.PaddleMove(e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Score.GameOver)
            {
                timer.Enabled = false;
                return;
            }

            ball.MoveBall();
            if (Score.GetScore >= 20)
            {
                ball.IncreaseSpeed = 7;
                paddle.Speed = 7;
            }
            else if (Score.GetScore >= 15)
            {
                ball.IncreaseSpeed = 5;
                paddle.Speed = 6;
            }
            else if (Score.GetScore >= 10)
            {
                ball.IncreaseSpeed = 3;
            }
            else if (Score.GetScore >= 5)
                ball.IncreaseSpeed = 1;
        }
    }
}
