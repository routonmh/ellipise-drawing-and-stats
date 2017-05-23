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
        public Form1()
        {
            InitializeComponent();            
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (nonZeroCenterBox.Checked)
            {
                centerXbox.Enabled = false;
                centerYbox.Enabled = false; 
            }
            else if (!nonZeroCenterBox.Checked)
            {
                centerXbox.Enabled = true;
                centerYbox.Enabled = true; 
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e) 
        {
            // turn this into a reusable class
            //going to need to feed the Paint event to a reusable class
            //or find another way to start the graph
            //add constructors that specify the size of the graph 


            //Graphics g = e.Graphics;

            GraphicsGraphMaker g = new GraphicsGraphMaker(e);
            // = new GraphicsGraphMaker(g);

        }
    }
}
