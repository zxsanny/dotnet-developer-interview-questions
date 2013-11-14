using System;

namespace ConsoleApplication5.Solution
{
	// This file provides solution on your question
	interface IWalkable
	{
		void Walk();
	}

	interface IFliable
	{
		void Fly();
	}

	class Bear : IWalkable
	{
		public void Walk()
		{
			Console.WriteLine("Bear is walking now");
		}
	}

	class Bat : IFliable
	{
		public void Fly()
		{
			Console.WriteLine("Bat is flying now");
		}
	}

	class Eagle : IFliable, IWalkable
	{
		public void Walk()
		{
			Console.WriteLine("Eagle is walking now");
		}

		public void Fly()
		{
			Console.WriteLine("Eagle is flying now");
		}
	}

	class Program
	{
		//private static void Main(string[] args)
		//{
		//    var bat = new Bat();
		//    var eagle = new Eagle();
		//    var bear = new Bear();
		//    bat.Fly();
		//    eagle.Fly();
		//    eagle.Walk();
		//    bear.Walk();
		//    Console.ReadKey(true);
		//}
	}
}
