using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        private bool ShowDrawing;
        int x;
        int y;
        int diameter = 70;
        public Form1()
        {
            InitializeComponent();
            ShowDrawing = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (ShowDrawing)
            {
                Graphics graphics = e.Graphics;

                diameter++;

                graphics.DrawEllipse(Pens.Black, x, y, diameter, diameter);
                graphics.DrawLine(Pens.Blue, ClientSize.Width - 1, 0, 0,ClientSize.Height - 1);
                graphics.DrawLine(Pens.Red, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);

            }
            
        }

        private void btDraw_Click(object sender, EventArgs e)
        {
            ShowDrawing = true;
            x = (this.ClientSize.Width - diameter) / 2;
            y = (this.ClientSize.Height - diameter) / 2;
            Refresh();
        }
    }
}
