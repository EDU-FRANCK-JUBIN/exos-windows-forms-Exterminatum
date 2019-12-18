using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        //  for (int i = 0; i < 8; i++)
       //     {
        //        for (int j = 0; j < 8; j++)
         //          e.Graphics.DrawPolygon(Pens.Red, HexToPoints(40, i, j));
         //   }
         e.Graphics.DrawPolygon(Pens.Red, HexToPoints(70, 1, 1));
            e.Graphics.DrawPolygon(Pens.Red, HexToPoints(70, 1, 2));
            e.Graphics.DrawPolygon(Pens.Red, HexToPoints(70, 2, 1));
           e.Graphics.DrawPolygon(Pens.Red, HexToPoints(70, 2, 2));
          e.Graphics.DrawPolygon(Pens.Red, HexToPoints(70, 2, 3));
           e.Graphics.DrawPolygon(Pens.Red, HexToPoints(70, 1, 3));
            e.Graphics.DrawPolygon(Pens.Red, HexToPoints(70, 1, 4));
            e.Graphics.DrawPolygon(Pens.Red, HexToPoints(70, 3, 1));
            e.Graphics.DrawPolygon(Pens.Red, HexToPoints(70, 4, 1));
            e.Graphics.DrawPolygon(Pens.Red, HexToPoints(70, 5, 1));
            // DrawHexagon(e, 340, 270, 70);
        }

        private PointF[] HexToPoints(float height, float row, float col)
        {
            // Start with the leftmost corner of the upper left hexagon.
            float width = HexWidth(height);
            float y = height/2;
            float x = 0;

            // Move down the required number of rows.
          y += row * 140 ;

            // If the column is odd, move down half a hex more.
          //  if (row % 2 == 1) x += width / 2;

            // Move over for the column number.
            x += col * (width*2);
            if (row % 2 == 1)
            {
                x += width;
              y += 35;
            }
            // Generate the points.
            //  return new PointF[]
            //       {
            //   new PointF(x, y),
            //   new PointF(x + width * 0.25f, y - height / 2),
            //   new PointF(x + width * 0.75f, y - height / 2),
            //  new PointF(x + width, y),
            //  new PointF(x + width * 0.75f, y + height / 2),
            //  new PointF(x + width * 0.25f, y + height / 2),
            //       };
            float a = x + width;
            return new PointF[]
               {
        //    new PointF(x, y),
       
             
            // new PointF( a+ 200, 200),
                new PointF((70 * (float) Math.Cos(30*Math.PI/180f))+a, (70 * (float) Math.Sin(30*Math.PI/180f)) +y),
                 new PointF((70 * (float) Math.Cos(90*Math.PI/180f))+ a , (70 * (float) Math.Sin(90*Math.PI/180f)) +y ),
                    new PointF((70 * (float) Math.Cos(150*Math.PI/180f))+ a , (70 * (float) Math.Sin(150*Math.PI/180f)) +y ),
              new PointF((70 * (float) Math.Cos(210*Math.PI/180f))+ a , (70 * (float) Math.Sin(210*Math.PI/180)) +y ),
              new PointF((70 * (float) Math.Cos(270*Math.PI/180f))+ a , (70 * (float) Math.Sin(270*Math.PI/180f)) +y ),
              new PointF((70 * (float) Math.Cos(330*Math.PI/180f))+ a , (70 * (float) Math.Sin(330*Math.PI/180f)) +y ),
              new PointF((70 * (float) Math.Cos(30*Math.PI/180f))+ a, (70 * (float) Math.Sin(30*Math.PI/180f)) +y )
              // new PointF( 200-a, 200)  
                 //  new PointF((70 * (float) Math.Cos(a*108*Math.PI/180f))+200, (70 * (float) Math.Sin(a*180*Math.PI/180f)) +200 ),
                 //     new PointF(a * (float) Math.Cos(120), a * (float) Math.Sin(120 ))
              // new PointF(x + width, y - height * 0.75f),
             //  new PointF(x - width/4, y - height),
             //  new PointF(x - width/2, y + height*0.25f)
                      //   new PointF(x + width, y),
           
          
          
           
               };
        }
        private float HexWidth(float height)
        {
            return (float)( Math.Sqrt(3) * (height/2));
        }
    }
}
