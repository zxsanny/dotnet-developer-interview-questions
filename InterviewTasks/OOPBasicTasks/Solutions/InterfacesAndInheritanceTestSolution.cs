using System;

namespace OOPBasicTasks.Solutions
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
}
