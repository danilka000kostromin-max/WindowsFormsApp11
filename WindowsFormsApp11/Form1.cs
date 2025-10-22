using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6, x7, y7, x8, y8;
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            timer1.Interval = 20;
            int a = rnd.Next(-10,10);
            int b = rnd.Next(0,4);
            if (b == 0)
            {


                if (x1 > 0 && x5 < 500 && y3 > 0 && y7 < 500)
                {
                    x1 = x1 + a;
                    y1 = y1 + a;
                    x2 = x2 + a;
                    y2 = y2 + a;
                    x3 = x3 + a;
                    y3 = y3 + a;
                    x4 = x4 + a;
                    y4 = y4 + a;
                    x5 = x5 + a;
                    y5 = y5 + a;
                    x6 = x6 + a;
                    y6 = y6 + a;
                    x7 = x7 + a;
                    y7 = y7 + a;
                    x8 = x8 + a;
                    y8 = y8 + a;
                }
                else
                {
                    x1 = 300;
                    y1 = 300;
                    x2 = 320;
                    y2 = 293;
                    x3 = 330;
                    y3 = 275;
                    x4 = 340;
                    y4 = 293;
                    x5 = 360;
                    y5 = 300;
                    x6 = 340;
                    y6 = 307;
                    x7 = 330;
                    y7 = 325;
                    x8 = 320;
                    y8 = 307;


                }
            }
            else
            if (b == 1)
            {


                if (x1 > 0 && x5 < 500 && y3 > 0 && y7 < 500)
                {
                    x1 = x1 + a;
                    y1 = y1 ;
                    x2 = x2 + a;
                    y2 = y2 ;
                    x3 = x3 + a;
                    y3 = y3 ;
                    x4 = x4 + a;
                    y4 = y4 ;
                    x5 = x5 + a;
                    y5 = y5 ;
                    x6 = x6 + a;
                    y6 = y6;
                    x7 = x7 + a;
                    y7 = y7;
                    x8 = x8 + a;
                    y8 = y8 ;
                }
                else
                {
                    x1 = 300;
                    y1 = 300;
                    x2 = 320;
                    y2 = 293;
                    x3 = 330;
                    y3 = 275;
                    x4 = 340;
                    y4 = 293;
                    x5 = 360;
                    y5 = 300;
                    x6 = 340;
                    y6 = 307;
                    x7 = 330;
                    y7 = 325;
                    x8 = 320;
                    y8 = 307;


                }
            }
            else
            if (b == 2)
            {


                if (x1 > 0 && x5 < 500 && y3 > 0 && y7 < 500)
                {
                    x1 = x1 ;
                    y1 = y1 + a;
                    x2 = x2 ;
                    y2 = y2 + a;
                    x3 = x3 ;
                    y3 = y3 + a;
                    x4 = x4;
                    y4 = y4 + a;
                    x5 = x5;
                    y5 = y5 + a;
                    x6 = x6 ;
                    y6 = y6 + a;
                    x7 = x7;
                    y7 = y7 + a;
                    x8 = x8;
                    y8 = y8 + a;
                }
                else
                {
                    x1 = 300;
                    y1 = 300;
                    x2 = 320;
                    y2 = 293;
                    x3 = 330;
                    y3 = 275;
                    x4 = 340;
                    y4 = 293;
                    x5 = 360;
                    y5 = 300;
                    x6 = 340;
                    y6 = 307;
                    x7 = 330;
                    y7 = 325;
                    x8 = 320;
                    y8 = 307;


                }
            }
            else
            if (b == 3)
            {


                if (x1 > 0 && x5 < 500 && y3 > 0 && y7 < 500)
                {
                    x1 = x1 + a;
                    y1 = y1 - a;
                    x2 = x2 + a;
                    y2 = y2 - a;
                    x3 = x3 + a;
                    y3 = y3 - a;
                    x4 = x4 + a;
                    y4 = y4 - a;
                    x5 = x5 + a;
                    y5 = y5 - a;
                    x6 = x6 + a;
                    y6 = y6 - a;
                    x7 = x7 + a;
                    y7 = y7 - a;
                    x8 = x8 + a;
                    y8 = y8 - a;
                }
                else
                {
                    x1 = 300;
                    y1 = 300;
                    x2 = 320;
                    y2 = 293;
                    x3 = 330;
                    y3 = 275;
                    x4 = 340;
                    y4 = 293;
                    x5 = 360;
                    y5 = 300;
                    x6 = 340;
                    y6 = 307;
                    x7 = 330;
                    y7 = 325;
                    x8 = 320;
                    y8 = 307;


                }
            }
     
    


                
            

            Invalidate();
        }

        
        private Pen pen = new Pen(Color.DarkRed, 5);

        private void Form1_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawPolygon(pen,new Point[] {new Point(x1,y1),new Point(x2,y2), new Point(x3,y3),
                new Point(x4,y4), new Point(x5,y5), new Point(x6,y6), new Point(x7,y7), new Point(x8,y8)
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            
            x1 = 300;
            y1 = 300;
            x2 = 320;
            y2 = 293;
            x3 = 330;
            y3 = 275;
            x4 = 340;
            y4 = 293;
            x5 = 360;
            y5 = 300;
            x6 = 340;
            y6 = 307;
            x7 = 330;
            y7 = 325;
            x8 = 320;
            y8 = 307;

        }
        

    }
}
