using Xunit;
using SquareLib;
using System;

namespace UnitTest.Test
{
    public class BasicTests
    {
        [Fact]
        public void CreateTriangle() //Вычисление площади треугольника
        {
            //Arrange
            double a = 3.00;
            double b = 4.00;
            double c = 5.00;

            //Act
            Triangle triangle = new(a, b, c);

            //Assert
            Assert.Equal(6, triangle.Square());
        }

        [Fact]
        public void CreateInvalidTriangle() //Вычисление площади треугольника с неверным параметром
        {
            //Arrange
            double a = -3.00;
            double b = 4.00;
            double c = 5.00;

            //Act
            Triangle triangle;

            //Assert
            var ex = Assert.Throws<Exception>(() => triangle = new(a,b,c));
            Assert.Equal("Invalid triangle", ex.Message);
        }

        [Fact]
        public void CreateWrongTriangle() //Вычисление площади неправильного треугольника
        {
            //Arrange
            double a = 3.00;
            double b = 3.00;
            double c = 30.00;

            //Act
            Triangle triangle;

            //Assert
            var ex = Assert.Throws<Exception>(() => triangle = new(a, b, c));
            Assert.Equal("Invalid triangle", ex.Message);
        }

        [Fact]
        public void CreateRightTriangle() //Проверка на прямоугольный треугольник
        {
            //Arrange
            double a = 3.00;
            double b = 4.00;
            double c = 5.00;

            //Act
            Triangle triangle = new(a, b, c);

            //Assert
            Assert.True(triangle.IsRight());
        }


        [Fact]
        public void CreateValidCircle() //Вычисление площади круга
        {
            //Arrange
            double r = 5.00;

            //Act
            Circle circle = new(r);

            //Assert
            Assert.Equal(78.53981633974483, circle.Square());
        }

        [Fact]
        public void CreateInvalidCircle() //Вычисление площади круга с неверным параметром
        {
            //Arrange
            double r = -5.00;

            //Act
            Circle circle;

            //Assert
            var ex = Assert.Throws<Exception>(() => circle = new(r));
            Assert.Equal("Invalid radius", ex.Message);
        }


    }
}
