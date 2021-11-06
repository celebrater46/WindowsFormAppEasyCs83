using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs83
{
    public partial class Form1 : Form
    {
        private List<Ball> ls;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "Math Random";
            this.Paint += new PaintEventHandler(FormPaint);

            ls = new List<Ball>();
            Random random = new Random();

            for (int i = 0; i < 30; i++)
            {
                Ball ball = new Ball();
                int x = random.Next(this.Width);
                int y = random.Next(this.Height);

                int r = random.Next(256);
                int g = random.Next(256);
                int b = random.Next(256);

                Point p = new Point(x, y);
                Color c = Color.FromArgb(r, g, b);

                ball.Point = p;
                ball.Color = c;

                ls.Add(ball);
            }
        }

        public void FormPaint(Object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Ball ball in ls)
            {
                Point p = ball.Point;
                Color c = ball.Color;
                SolidBrush brush = new SolidBrush(c);
                
                g.FillEllipse(brush, p.X, p.Y, 10, 10);
            }
        }
    }
}