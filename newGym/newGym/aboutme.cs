using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace newGym
{
    class aboutme
    {
        String name;
        int x;
        int y;
        int speed;
        int size;
        KnownColor color;
        KnownColor[] colors;
        Random rnd;

        public aboutme(String name,Random rnd,int y,KnownColor[] colors)
        {
            this.name = name;
            this.rnd = rnd;
            this.y = y;
            this.colors = colors;
            color = colors[rnd.Next(colors.Length)];
        }
        public void setSpeed()
        {
            speed=rnd.Next(5, 10);
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setSize()
        {
            size=rnd.Next(10, 20);
        }
        public int getSpeed()
        {
            return speed;
        }
        public int getSize()
        {
            return size;
        }
        public int getX()
        {
            return x;
        }
        public String getName()
        {
            return name;
        }
        public int getY()
        {
            return y;
        }
        public void setColor()
        {
            color = colors[rnd.Next(colors.Length)];
        }
        public KnownColor getColor()
        {
            return color;
        }
    }
}
