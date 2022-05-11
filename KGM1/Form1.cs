using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGM1
{
    public partial class Form1 : Form
    {
        static private Graphics g;
        static private Random rnd;
        public Form1()
        {
            InitializeComponent();
            g = pb1.CreateGraphics();
            rnd = new Random();
        }

        private void btnPnt_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(getRndCol());
            g.FillEllipse(sb, new Rectangle( 10+ rnd.Next(380), 10 + rnd.Next(380), 3,3));
            //g.DrawEllipse(myPen, new Rectangle(0, 0, 200, 300));
            sb.Dispose();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            Pen myPen = new Pen(getRndCol());
            g.DrawLine(myPen, 10 + rnd.Next(380), 10 + rnd.Next(380), 10 + rnd.Next(380), 10 + rnd.Next(380));
            myPen.Dispose();
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(getRndCol());
            g.FillRectangle(sb, new Rectangle(10 + rnd.Next(220), 10 + rnd.Next(220), rnd.Next(200), rnd.Next(200)));
            sb.Dispose();
        }

        private void btnSqr_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(200);
            SolidBrush sb = new SolidBrush(getRndCol());
            g.FillRectangle(sb, new Rectangle(10 + rnd.Next(220), 10 + rnd.Next(220), a, a ));
            sb.Dispose();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(200);
            SolidBrush sb = new SolidBrush(getRndCol());
            g.FillEllipse(sb, new Rectangle(10 + rnd.Next(220), 10 + rnd.Next(220), a, a));
            sb.Dispose();
        }

        private Color getRndCol()
        {
            return Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }
    }
}
