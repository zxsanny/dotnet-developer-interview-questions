using System;
using System.Collections;

namespace ConsoleApplication5
{
	class Rectangle
	{
		public double A { get; set; }
		public double B { get; set; }
		public Rectangle(double a, double b) { A = a; B = b; }
	}

	class Circle
	{
		public double R { get; set; }
		public Circle(double radius) { R = radius; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			var shapes = new ArrayList
		    {
		        new Rectangle(1,1),
		        new Circle(2)
		    };
			Console.WriteLine(OldAndTerribleCalculateSumOfAreas(shapes));
			Console.ReadKey(true);
		}

		/*
		   Please improve this piece of ... code in OldAndTerribleCalculateSumOfAreas method
		   Feel free to change anything, any class and methods,
		   the only one thing to do - return Sum of real areas of all shapes which are defined in Main
		*/

		//public static double BetterCalculateSumOfAreas

		public static double OldAndTerribleCalculateSumOfAreas(ArrayList objects)
		{
			double s1 = 0;
			double s2 = 0;

			for (var i = 0; i < objects.Count; i++)
			{
				object o = objects[i];
				if (o is Circle)
				{
					Circle oCircle = (o as Circle);
					s1 += 3.14 * oCircle.R * oCircle.R;
				}
				else if (objects[i] is Rectangle)
				{
					Rectangle oRectangle = (o as Rectangle);
					s2 += oRectangle.A * oRectangle.B;
				}
			}
			return s1 + s2;
		}
	}
}
