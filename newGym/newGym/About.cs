using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace newGym
{
    public partial class About : Form
    {
        KnownColor[] names;
        Random randomGen;

        aboutme[] arr;
        public About()
        {
            InitializeComponent();
            label1.AutoSize = false;
            label1.Height = 2;
            label1.BorderStyle = BorderStyle.Fixed3D;
            randomGen = new Random();
            names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            arr = new aboutme[8];
            string[] coders = { "Guy Gelber", "Matan Ramazker", "Vadim Mar", "Nick Yeshayev", "Arthur", "Itzik Ben Zaken", "Yossi Elashvili", "Michael Gershberg" };
            for (int i = 0,y=70; i < 8; i++)
            {
                arr[i] = new aboutme(coders[i],randomGen,y,names);
                arr[i].setX(randomGen.Next(0, Width));
                arr[i].setSpeed();
                arr[i].setSize();
                y+=20;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();

            for (int i = 0; i < 8; i++)
            {
                Graphics gra = this.CreateGraphics();
                gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                Color cl1 = Color.FromKnownColor(arr[i].getColor());
                gra.DrawString(arr[i].getName(), new Font("Calibri", arr[i].getSize()), new SolidBrush(cl1), arr[i].getX(), arr[i].getY());
                arr[i].setX(arr[i].getX()+arr[i].getSpeed());

            }
            for (int i = 0; i < 8; i++)
            {
                if (arr[i].getX() >= this.Width)
                {
                    arr[i].setX(arr[i].getName().Length * arr[i].getSize() * -1);
                    arr[i].setColor();
                    arr[i].setSpeed();
                    arr[i].setSize();
                }
            }
        }

        private void About_Load(object sender, EventArgs e)
        {

        }



    }
}
