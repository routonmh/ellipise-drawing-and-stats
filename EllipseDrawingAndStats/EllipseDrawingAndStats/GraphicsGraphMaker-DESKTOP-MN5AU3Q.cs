using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; 

namespace EllipseDrawingAndStats
{
    class GraphicsGraphMaker
    {
        public GraphicsGraphMaker(PaintEventArgs e)
        {
            Graphics g = e.Graphics; 
            Pen drawPen = new Pen(Color.Black);
            Brush fillerBrush = new SolidBrush(Color.Red);

            int startingEdge = 350; // horizontal values
            int endingEdge = 750;

            int startHeight = 8; //vertical values
            int endHeight = 400;

            int lengthOfOutline = endingEdge - startingEdge; //use for reusability 
            int heightOfOutline = endHeight - startHeight;

            int xAxisLine = 200;
            int yAxisLine = 550;

            //outside border rectangle
            g.DrawRectangle(drawPen, startingEdge, startHeight, lengthOfOutline, endHeight); //main graph
            g.DrawRectangle(drawPen, 345, 3, 410, 410); //outside of graph

            //draw y-axis      


            g.DrawLine(drawPen, yAxisLine, 8, yAxisLine, 408); // fill in with new variables 
            //draw x-axis 
            g.DrawLine(drawPen, startingEdge, 200, endingEdge, 200);

            //draws notches right side of x-axis
            // 190 and 210 specify the height of notches            
            for (int i = yAxisLine; i < endingEdge; i++) // i is the current location of the notch drawer
            {
                if (i % 20 == 0 && i > yAxisLine + 11)
                {
                    g.DrawLine(drawPen, i, 190, i, 210);
                }
            }
            //draws notches on left side of x-axis 
            for (int i = yAxisLine; i > startingEdge; i--)
            {
                if (i % 20 == 0 && i < yAxisLine - 11)
                {
                    g.DrawLine(drawPen, i, xAxisLine - 10, i, xAxisLine + 10);
                }
            }

            //draws y-axis notches

            //use x-axis as starting point for up/down
            //use x-axis as starting point for up/down
            for (int i = xAxisLine; i < endHeight; i++)
            {
                if (i % 20 == 0) // 11 is a safety pixel
                {
                    g.DrawLine(drawPen, yAxisLine - 10, i, yAxisLine + 10, i);
                }
            }

            for (int i = xAxisLine; i > startHeight; i--)
            {
                if (i % 20 == 0) // 11 is a safety pixel
                {
                    g.DrawLine(drawPen, yAxisLine - 10, i, yAxisLine + 10, i);
                }
            }

            //g.DrawEllipse(drawPen, 300, 10, 400, 500);
            //g.DrawLine(drawPen, 300, 10, 400, 500);
        }
    }
}
