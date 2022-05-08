using System;
using System.Linq;

namespace SquareLib
{
    public class Triangle
    {
        double A;
        double B;
        double C;

        public Triangle(double a, double b, double c)
        {
            if((a + b < c || a + c < b || b + c < a)
                || (a <= 0 || b <= 0 || c <= 0))
            {
                throw new Exception("Invalid triangle");
            }
            else
            {
                A = a;
                B = b;
                C = c;
            }
        }

        public bool IsRight()
        {
            bool Right = false;

            double[] Sides = { A, B, C };

            int IndexGypotenusa = Array.IndexOf(Sides, Sides.Max());

            double Gypotenusa = 0;
            double Katets = 0;

            for (int i = 0; i < Sides.Length; i++)
            {
                if (i != IndexGypotenusa)
                {
                    Katets += Math.Pow(Sides[i], 2);
                }
                else
                {
                    Gypotenusa = Math.Pow(Sides[i], 2);
                }
            }

            if (Gypotenusa == Katets)
            {
                Right = true;
            }

            return Right;
        }

        public double Square()
        {
            double Square;

            double p = (A + B + C) / 2;
            Square = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return Square;
        }

        public void Print() => Console.WriteLine("Triangle area: " + Square());
    }
}
