using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public abstract class Shape
    {
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }
        public virtual double Area { get; set; }
    }

    public class Rectangle : Shape
    {
        public Rectangle(double height, double width) {
            Height = height;
            Width = width;
        }

        public override double Area { get => base.Height * base.Width; }

    }

    public class Square : Shape
    {
        public Square(double v) {
            Height = v;
            Width = v;
        }

        public override double Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Height
        {
            get => base.Height;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Area { get => base.Height * base.Height; }

    }

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Width = radius;
            Height = radius;
        }

        public override double Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Height
        {
            get => base.Height;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Area { get => Math.Pow(base.Height,2) * Math.PI; }

    }

}
