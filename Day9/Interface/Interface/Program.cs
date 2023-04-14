using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IFigure
    {
        int Dimension { get; set; }
        double Area();
        double Perimeter();
    }
    class Circle : IFigure
    {
        private int Radius;
        public int Dimension
        {
            get { return Radius; }
            set { Radius = value; }
        }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
        class Square : IFigure
        {
            private int Side;
            public int Dimension
            {
                get { return Side; }
                set { Side = value; }
            }

            public double Area()
            {
                return Side * Side;
            }
            public double Perimeter()
            {
                return 4 * Side;
            }

            internal class Program
            {
                static void Main(string[] args)
                {
                    IFigure fig = null;
                    Console.WriteLine("Enter 'C' for Circle or 'S' for Square");
                    string ch = Console.ReadLine();
                    if (ch == "S")
                        fig = new Square();
                    else if (ch == "C")
                        fig = new Circle();
                    fig.Dimension = 10;
                    Console.WriteLine(fig.Area());
                    Console.WriteLine(fig.Perimeter());
                }
            }
        }
    }

