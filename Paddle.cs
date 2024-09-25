using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bricsBreaker
{
    public class Paddle
    {
        public int Speed {  get; set; }
        public List<PictureBox> PlayerPaddles { get; set; }
        private frmAranoid form;

        public Paddle(frmAranoid form)
        {
            this.form = form;
            Speed = 5;
            PlayerPaddles = new List<PictureBox>();
            Init();
        }

        private void Init()
        {
            for (int i = 0; i < 3; i++)
            {
                PlayerPaddles.Add(new PictureBox()
                {
                    BackColor = Color.DarkOrange,
                    Height = 11,
                    Visible = true,
                    Width = 30,
                    Top = form.ClientSize.Height - 11,
                    Left = (form.ClientSize.Width - 30) / 2
                });

                if (i == 0)
                    PlayerPaddles[i].Left -= 30;
                if (i == 2)
                    PlayerPaddles[i].Left += 30;

                form.Controls.Add(PlayerPaddles[i]);

            }
        }
        public void PaddleMove(KeyEventArgs e)
        {
            for (int i=0; i<3; i++)
            {
                if (e.KeyCode == Keys.Left)
                    PlayerPaddles[i].Left -= Speed;
                if(e.KeyCode == Keys.Right)
                {
                    PlayerPaddles[i].Left += Speed;
                }
            }
            PaddleAtEdge();

        }

        private void PaddleAtEdge()
        {
            if (PlayerPaddles[0].Left <= 0)
            {
                PlayerPaddles[0].Left = 0;
                PlayerPaddles[1].Left = PlayerPaddles[0].Width;
                PlayerPaddles[2].Left = PlayerPaddles[0].Width + PlayerPaddles[1].Width;

            }
            else if (PlayerPaddles[2].Right >= form.ClientSize.Width)
            {
                PlayerPaddles[0].Left = form.ClientSize.Width - PlayerPaddles[0].Width - PlayerPaddles[1].Width -
                    PlayerPaddles[2].Width;
                PlayerPaddles[1].Left = form.ClientSize.Width - PlayerPaddles[1].Width - PlayerPaddles[2].Width;
                PlayerPaddles[2].Left = form.ClientSize.Width - PlayerPaddles[2].Width;


            }
        }
    }
}
