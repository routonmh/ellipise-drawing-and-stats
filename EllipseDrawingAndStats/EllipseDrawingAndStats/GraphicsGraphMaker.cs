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
        ///x and y are the coordinates of the top-left corner (extra pixels for border) 
        /// NOTE: numOfNotches is not yet implemented         
                
        public GraphicsGraphMaker(PaintEventArgs e, int x, int y, int height, int width, int notchWidth)
        {
            Graphics g = e.Graphics;
            Pen drawPen = new Pen(Color.Black);
            Brush fillerBrush = new SolidBrush(Color.Red); //not used yet            

            //draw outside border rectangle 
            g.DrawRectangle(drawPen, x, y, width, height);
            g.DrawRectangle(drawPen, x - 5, y - 5, width + 10, height + 10); //hard-coded border width

            //draw axes -->> need to use even numbers to be on exact pixels
            int horizontalCenter = (width / 2) + x;
            int verticalCenter = (height / 2) + y;

            //draw y-axis line          
            g.DrawLine(drawPen, horizontalCenter, y, horizontalCenter, y + height);
            //draw x-axis line
            g.DrawLine(drawPen, x, verticalCenter, x + width, verticalCenter);           

            //draw notches fix to draw from left edge to right edge, allowing space in the middle if necessary            
            //would have to put in another if conditions            
            

            for (int location = x; location < width + x; location += 20) //20 can be changed to a mulitpule of the resolution
            {
                g.DrawLine(drawPen, location, verticalCenter - notchWidth, location,
                    verticalCenter + notchWidth);
            }

            for (int location = y; location < height + y; location += 20)
            {
                g.DrawLine(drawPen, horizontalCenter - notchWidth, location, horizontalCenter + notchWidth, location);
            }
        }              
    }
  }

