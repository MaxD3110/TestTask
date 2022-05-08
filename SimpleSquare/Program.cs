using SquareLib;
using System;
using System.Linq;

namespace SimpleSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            string Values;

            Console.WriteLine("Введите значения через запятую:");
            Console.WriteLine("Enter comma separated values:");

            Values = Console.ReadLine();

            string[] ValArray = Values.Split(new char[] { ',' });

            double[] ConvertedValues = ValArray.Select(double.Parse).ToArray();

            switch (ValArray.Length)
            {
                case (1):
                    Circle circle = new(ConvertedValues[0]);
                    circle.Print();
                    break;

                case (3):
                    Triangle triangle = new(ConvertedValues[0], ConvertedValues[1], ConvertedValues[2]);

                    triangle.Print();

                    if(triangle.IsRight() == true)
                    {
                        Console.WriteLine("Triangle is right");
                    }

                    break;

                default:
                    Console.WriteLine("Not triangle or circle parameters");
                    break;
            }

            

           
            
        }
    }
}
