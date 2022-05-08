using System;

namespace SquareLib
{
    public class Circle
    {
        double Radius;

        public Circle(double radius)
        {
           if(radius > 0)
            {
                Radius = radius;
            }
            else
            {
                throw new Exception("Invalid radius");
            }
        }

        public double Square()
        {
            double Square;

            Square = Math.PI * Math.Pow(Radius, 2);

            return Square;
        }

        public void Print() => Console.WriteLine("Circle area: " + Square());
    }
}
