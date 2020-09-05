using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidCore
{
    public class Point
    {
        public int x;

        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
    public class Trapezoid
    {
        public static int ArraySize = 4;

        private Point[] pointArray = new Point[ArraySize];

        private int[] lengthOfSide = new int[ArraySize];

        private double perimeter = 0;

        private double height = 0;
        public double Square { get; private set; } = 0;

        public Trapezoid(Point[] customPointArray)
        {
            pointArray = customPointArray;
        }

        public void CalculateLength()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                if (i!=3)
                {
                    Math.Sqrt(Math.Pow((pointArray[i + 1].x - pointArray[i].x), 2) + Math.Pow((pointArray[i + 1].y - pointArray[i].y), 2));
                }
                else
                {
                    Math.Sqrt(Math.Pow((pointArray[i + 1].x - pointArray[0].x), 2) + Math.Pow((pointArray[i + 1].y - pointArray[0].y), 2));
                }
            }

        }

        public double CalculateSquare()
        {
            Square = ((lengthOfSide[0] + lengthOfSide[2]) / 2) * height;

            return Square;
        }

        public double CalculatePerimeter()
        {
            for (int i = 0; i < ArraySize; i++)
            {
                perimeter += lengthOfSide[i];
            }

            return perimeter;
        }

        public bool isIsosceles()
        {
            height = 0.5 * Math.Sqrt(4 * Math.Pow(lengthOfSide[1], 2) - Math.Pow((lengthOfSide[0] - lengthOfSide[2]), 2));

            if (Math.Abs(height - ((lengthOfSide[0] + lengthOfSide[2])/2)) < Double.Epsilon)
            {
                return true;
            }

            return false;
        }

    }
}
