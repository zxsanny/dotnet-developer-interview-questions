using System.Collections;
using NUnit.Framework;

namespace OOPBasicTasks
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

	public class ShapesManager
	{
        /*
           Please improve this piece of ... code in OldAndTerribleCalculateSumOfAreas method
           Feel free to change anything, any class and methods even in tests,
           the only one thing to do - return Sum of real areas should be for Rectangle with a = 1 and b = 2 and Circle with radius = 2 should be = 1*2 + Pi*2^2 = 14.56
        */

        //Better method
		//public double CalculateSumOfAreas

        //OldAndTerrible
		public double CalculateSumOfAreas(ArrayList objects)
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

    [TestFixture]
    public class ShapeManagerTest
    {
        [Test]
        public void CalculateSumOfAreas_Test()
        {
            var shapes = new ArrayList
		    {
		        new Rectangle(1, 2),
		        new Circle(2)
		    };

            var sum = new ShapesManager().CalculateSumOfAreas(shapes); 
            Assert.That(14.56, Is.EqualTo(sum).Within(0.1));
        }
    }
}
