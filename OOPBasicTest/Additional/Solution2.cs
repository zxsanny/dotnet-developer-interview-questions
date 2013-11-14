using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication5.Additional
{
	abstract class Shape
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
	
	class Program
	{
		//static void Main(string[] args)
		//{
		//    var shapes = new List<Shape>
		//    {
		//        new Rectangle(1,1),
		//        new Circle(2)
		//    };
		//    Console.WriteLine(CalculateSumOfAreas(shapes));
		//    Console.ReadKey(true);
		//}

	    public static double CalculateSumOfAreas(List<Shape> shapes)
	    {
	        return shapes.Sum(x => x.Area);
	    }
	}
}
