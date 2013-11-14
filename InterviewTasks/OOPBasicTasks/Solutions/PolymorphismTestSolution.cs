using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace OOPBasicTasks.Solutions
{
    public abstract class Shape
	{
		public abstract double Area { get; }
	}

	class Rectangle : Shape
	{
		public double A { get; set; }
		public double B { get; set; }

		public Rectangle(double a, double b) { A = a; B = b; }

		public override double Area
		{
			get { return A*B; }
		}
	}

	class Circle : Shape
	{
		public double R { get; set; }
		public Circle(double radius) { R = radius; }

		public override double Area
		{
			get { return Math.PI*R*R; }
		}
	}

    public class ShapesManager
    {
		public double CalculateSumOfAreas(List<Shape> shapes)
	    {
	        return shapes.Sum(x => x.Area);
	    }
	}
    [TestFixture]
    public class ShapeManagerTest
    {
        [Test]
        public void CalculateSumOfAreas_Test()
        {
            var shapes = new List<Shape>()
		    {
		        new Rectangle(1, 2),
		        new Circle(2)
		    };

            var sum = new ShapesManager().CalculateSumOfAreas(shapes);
            Assert.That(14.56, Is.EqualTo(sum).Within(0.1));
        }
    }
}
