using System;
using System.Drawing;
using System.Windows.Forms;

namespace KGM1
{
    public partial class Form1 : Form
    {
        static private Graphics g;
        static private Random rnd;

        //Инициализация
        public Form1()
        {
            InitializeComponent();
            g = pb1.CreateGraphics();
            rnd = new Random();
        }

        //Кнопка точки
        private void btnPnt_Click(object sender, EventArgs e) 
        {
            SolidBrush sb = new SolidBrush(getRndCol());
            g.FillEllipse(sb, new Rectangle( 10+ rnd.Next(380), 10 + rnd.Next(380), 3,3));
            sb.Dispose();
        }

        //Кнопка линии
        private void btnLine_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(getRndCol());
            g.DrawLine(myPen, 10 + rnd.Next(380), 10 + rnd.Next(380), 10 + rnd.Next(380), 10 + rnd.Next(380));
            myPen.Dispose();
        }

        //Кнопка прямоугольник
        private void btnRect_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(getRndCol());
            g.FillRectangle(sb, new Rectangle(10 + rnd.Next(220), 10 + rnd.Next(220), rnd.Next(200), rnd.Next(200)));
            sb.Dispose();
        }

        //Кнопка квадрата
        private void btnSqr_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(200);
            SolidBrush sb = new SolidBrush(getRndCol());
            g.FillRectangle(sb, new Rectangle(10 + rnd.Next(220), 10 + rnd.Next(220), a, a ));
            sb.Dispose();
        }

        //Кнопка круга
        private void btnCircle_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(200);
            SolidBrush sb = new SolidBrush(getRndCol());
            g.FillEllipse(sb, new Rectangle(10 + rnd.Next(220), 10 + rnd.Next(220), a, a));
            sb.Dispose();
        }

        //Кнопка очистки
        private void btnClr_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        //Рандомный цвет
        private Color getRndCol()
        {
            return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }
    }
}
