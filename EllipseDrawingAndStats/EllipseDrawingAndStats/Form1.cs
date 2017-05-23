using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EllipseDrawingAndStats
{
    public partial class Form1 : Form
    {                
        int x = 20;  //for graph
        int y = 16;
        int height = 400;
        int width = 400;
        int notchWidth = 10;

        int eHeight; //for ellipse
        int eWidth;        

        int xOriginOffset; //to be passed into ellipse drawer
        int yOriginOffset;

        public Form1()
        {
            InitializeComponent();
            GetEllipseSize(); 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsGraphMaker graph = new GraphicsGraphMaker(e, x, y, height, 
                width, notchWidth);

            GraphicsEllipse ellipse = new GraphicsEllipse(e, x, y, eHeight,
                                eWidth, xOriginOffset, yOriginOffset); 
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (nonZeroCenterBox.Checked)
            {
                centerXBox.Enabled = false;
                centerYBox.Enabled = false; 
            }
            else if (!nonZeroCenterBox.Checked)
            {
                centerXBox.Enabled = true;
                centerYBox.Enabled = true; 
            }
        }

        private void centerXBox_ValueChanged(object sender, EventArgs e)
        {                         
            xOriginOffset = (int)centerXBox.Value;
            Invalidate();
        }

        private void centerYBox_ValueChanged(object sender, EventArgs e)
        {            
            yOriginOffset = (int)centerYBox.Value;
            Invalidate();
        }

        private void GetEllipseSize() //updates 
        {
            eHeight = (int)heightUpDown.Value;
            eWidth = (int)widthUpDown.Value;
        }

        private void heightUpDown_ValueChanged(object sender, EventArgs e)
        {
            GetEllipseSize();
            Invalidate();
        }

        private void widthUpDown_ValueChanged(object sender, EventArgs e)
        {
            GetEllipseSize();
            Invalidate();
        }
    }
}