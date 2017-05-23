using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace EllipseDrawingAndStats
{
    class GraphicsEllipse
    {                
        public GraphicsEllipse(PaintEventArgs e, int xCorner, int yCorner, 
            int width, int height, int xOriginOffset, int yOriginOffset)
        {
            Graphics g = e.Graphics;
            Pen drawPen = new Pen(Color.Black);
            Brush fillerBrush = new SolidBrush(Color.Red); //not used yet

            //decides major/minor axes  --> make height always greater than width/always major to orient            
            //majorAxis = GetMajorAxis(orientation, width, height);
                        
            g.DrawEllipse(drawPen, (xCorner + (height / 2)) + xOriginOffset, yCorner + (height / 2) - yOriginOffset, height, width);
            // replace (width / 2) with center location varibles
        } 

        private string GetMajorAxis(char orientation, int width, int height) //not used yet
        {
            string majorAxis = "not set";

            switch (orientation)
            {
                case 'h':
                        if(width > height)
                    {
                        majorAxis = "width";
                    }
                    break;
                case 'v':
                        if(height > width)
                    {
                        majorAxis = "height";
                    }
                    break;                
                default:
                    majorAxis = "not set";
                    break;
            }
            return majorAxis;
        }
    }
}
