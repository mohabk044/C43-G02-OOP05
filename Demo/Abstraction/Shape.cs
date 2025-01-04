using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    abstract class Shape
    {
        public Shape(decimal dim1, decimal dim2)
        {
            Dim1 = dim1;
            Dim2 = dim2;
        }
        public decimal Dim1 { get; set; }
        public decimal Dim2 { get; set; }
        public abstract decimal Premiter { get; }  // read only
        public abstract decimal CalcArea();
    }
    class Rectangle : Area
    {
        public Rectangle(decimal dim1, decimal dim2) : base(dim1, dim2)
        {
        }
        public override decimal Premiter
        {
            get
            {
                return (Dim1 + Dim2) * 2;
            }
        }
    }

    abstract class Area : Shape
    {
        public Area(decimal dim1, decimal dim2) : base(dim1, dim2)
        {
        }
        public override decimal CalcArea()
        {
            return Dim1 * Dim2;
        }
    }

    class Square : Area
    {
        public Square(int Dim) : base(Dim, Dim)
        {
        }
        public override decimal Premiter => Dim1 * 4;
    }

    class Circle : Shape
    {
        public Circle(decimal Redius) : base(Redius, Redius)
        {
        }
        public override decimal Premiter => 2 * 3.14m * Dim1;

        public override decimal CalcArea()
        {
            return Dim1 * Dim1 * 3.14m;
        }
    }
}