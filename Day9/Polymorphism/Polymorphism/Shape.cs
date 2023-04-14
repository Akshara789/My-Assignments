using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
     class Shape
    {
        public virtual void DrawShape()
        {
            Shape s1 = new Shape();
            Console.WriteLine("Drawing shape");
        }

    }
    class Circle:Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Drawing circle");
        }
    }

    class Rectangle:Shape
    {
        public override void DrawShape() { Console.WriteLine("Drawing Rectangle"); }
    }
}
