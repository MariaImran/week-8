using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week8.bl
{
    class Cylinder : Circle
    {
        private double height = 1.0;
        public Cylinder()
        {

        }
        public Cylinder(double radius)
        {
            this.radius = radius;
        }
        public Cylinder(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public Cylinder(double radius, string color, double height)
        {
            this.radius = radius;
            this.color = color;
            this.height = height;
        }
        public double getHeight()
        {
            return height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            double volume = 0.0;
            volume = 2*3.14*radius* height;
            return volume;
        }
        public string toString()
        {
            return "Radius : " + radius + "\n" + "Color : " + color + "\n" + "Height : " + height + "\n" + "Volume : " + getVolume();
        }
    }
}
