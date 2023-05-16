﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema12_6._1_
{
    public partial class Form1 : Form
    {
        
        SolidBrush mySolidBrush;
        TextureBrush myBrushTexture;
        HatchBrush myHatchBrush;
        LinearGradientBrush myBrushGrad;
        HatchStyle myHatchStyle;
        LinearGradientMode myLinearGradientMode;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Bitmap/*Image*/ theImage;
        private Bitmap/*Image*/ smallImg;
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, ClientRectangle);
            
            theImage = new Bitmap("C:\\\\Users\\USER\\Desktop\\\\T2.bmp");
            smallImg = new Bitmap(theImage, new Size(theImage.Width / 2, theImage.Height / 2));

            Brush tBrush = new TextureBrush(smallImg, new Rectangle(0, 0, smallImg.Width, smallImg.Height));
            g.FillEllipse(tBrush, ClientRectangle);
            tBrush.Dispose();
            theImage.Dispose();
            smallImg.Dispose();

        }
    }
}
