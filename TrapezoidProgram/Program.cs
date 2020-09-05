using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrapezoidCore;
using ValidationLib;

namespace TrapezoidProgram
{
    class Program
    {
        public static int WriteIntValue(string ValueName)
        {
            int WritingValue;

            do
            {
                Console.WriteLine("Give me correct " + ValueName + ": ");

                WritingValue = Validation.IntValidation(Console.ReadLine());
            }
            while (WritingValue == int.MinValue);

            return WritingValue;
        }
        static void Main(string[] args)
        {
            bool isIsosceles;

            int trapezoidCount;

            int countOfSoughtTrapezoid = 0;

            double averageSquare = 0;

            Point[] pointArray = new Point[Trapezoid.ArraySize];

            Trapezoid[] UserTrapezoidArray;

            Console.WriteLine("Add count of trapezoid");
            trapezoidCount = WriteIntValue("count of trapezoid");

            UserTrapezoidArray = new Trapezoid[trapezoidCount];

            for (int i = 0; i < trapezoidCount;)
            {
                Console.WriteLine("Enter A, B, C, D points of trapezoid");

                for (int j = 0; j < Trapezoid.ArraySize; j++)
                {
                    pointArray[j] = new Point(WriteIntValue("x coord"), WriteIntValue("y coord"));
                }

                UserTrapezoidArray[i] = new Trapezoid(pointArray);

                UserTrapezoidArray[i].CalculateLength();

                isIsosceles = UserTrapezoidArray[i].isIsosceles();

                if (isIsosceles)
                {
                    UserTrapezoidArray[i].CalculateSquare();

                    averageSquare += UserTrapezoidArray[i].Square;

                    i++;
                }
                else
                {
                    Console.WriteLine("Your trapezoid is not isosceles");
                }

                Console.WriteLine();
            }

            averageSquare /= trapezoidCount;

            for (int i = 0; i < trapezoidCount; i++)
            {
                if (UserTrapezoidArray[i].Square > averageSquare)
                {
                    countOfSoughtTrapezoid++;
                }
            }

            Console.WriteLine("Count of sought trapezoid = {0}", countOfSoughtTrapezoid);

            Console.ReadKey();
        }
    }
}
