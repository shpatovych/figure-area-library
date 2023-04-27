//using FigureAreaLibrary;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;

namespace FigureAreaLibrary.Tests
{

    [TestFixture]
    public class FigureTests
    {
        const double pi = Math.PI;

        [TestCase(5, pi * 5 * 5)]
        [TestCase(10, pi * 10 * 10)]
        [TestCase(2.5, pi * 2.5 * 2.5)]
        public void CircleAreaTest(double radius, double expectedArea)
        {
            Circle circle = new Circle(radius);
            Assert.AreEqual(expectedArea, circle.CalculateArea(), 1e-10);
        }

        [TestCase(3, 4, 5, 6)]
        [TestCase(6, 8, 10, 24)]
        [TestCase(5, 12, 13, 30)]
        public void TriangleAreaTest(double a, double b, double c, double expectedArea)
        {
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(expectedArea, triangle.CalculateArea(), 1e-10);
        }

        [TestCase(3, 4, 5, true)]
        [TestCase(6, 8, 10, true)]
        [TestCase(5, 12, 13, true)]
        [TestCase(3, 4, 6, false)]
        [TestCase(5, 5, 5, false)]
        public void TriangleIsRightTest(double a, double b, double c, bool expectedResult)
        {
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(expectedResult, triangle.IsRightTriangle());
        }
    }
}