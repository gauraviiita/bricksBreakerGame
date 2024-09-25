using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace bricsBreaker
{
    public class Brick
    {
        private Random rand;
        private PictureBox brick;
        private frmAranoid form;
        private List<PictureBox> bricks;

        public Brick(frmAranoid form)
        {
            rand = new Random();
            this.form = form;
            bricks = new List<PictureBox>();
            brick = new PictureBox()
            {
                BackColor = GetColor(rand.Next(1, 7)),
                Width = rand.Next(50, 101),
                Height = rand.Next(10, 26),
                Tag = "Brick",
                Visible = true,
            };

            init();

        }


        private Color GetColor(int c)
        {
            Color color;
            switch (c)
            {
                case 1:
                    color = Color.Blue;
                    break;
                case 2:
                    color = Color.Red;
                    break;
                case 3:
                    color = Color.Purple;
                    break;
                case 4:
                    color = Color.Yellow;
                    break;
                case 5:
                    color = Color.Green;
                    break;
                default:
                    color = Color.Black;
                    break;

            }
            return color;
        }

        private void init()
        {
            GetAllBricks();
            SetBrickLeftTop();
            form.Controls.Add(brick);
        }
        private void SetBrickLeftTop()
        {
            do
            {
                brick.Left = rand.Next(0, (form.ClientSize.Width - brick.Width));
                brick.Top = rand.Next(0, (form.ClientSize.Height / 2));

            } while (!CheckIntersect());
            bricks.Add(brick);
        }
        private bool CheckIntersect()
        {
            for (int i=0; i<bricks.Count; i++)
            {
                if (this.brick.Bounds.IntersectsWith(bricks[i].Bounds))
                    return false;
            }
            return true;
        }

        private void GetAllBricks()
        {
            foreach (var item in form.Controls.OfType<PictureBox>().Where(t  => t.Tag == "Brick"))
            {
                bricks.Add(item);
            }
        }
    }
}
