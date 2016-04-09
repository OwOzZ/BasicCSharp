using System;

namespace BasicStatic
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			static field example
			Player player1 = new Player ("James", "26", "SG");
			Player player2 = new Player ("Curry", "28", "PG");

			Console.WriteLine (player1.Id);
			Console.WriteLine (player2.Id);

//			static method example
			Player.ClearNextId();
			Player player3 = new Player ("Cousins", "25", "C");
			Console.WriteLine (player3.Id);
		}
	}
	public class Player
	{
		public string Name{ get; set;}
		public string Age{ get; set;}
		public string Des{ get; set;}
		public int Id{ get; set;}

//		static field
		private static int NextId;

		public Player(string newName, string newAge, string newDes)
		{
			Name = newName;
			Age = newAge;
			Des = newDes;
			Id = NextId;

			NextId++;
		}

//		static property
		private static string _Team;
		private static string Team
		{
			get
			{
				return _Team;
			}
			private set
			{
				_Team = value;
			}
		}

//		static method
		public static void ClearNextId()
		{
			NextId = 0;
//			You cant use 'this' keyword reference current instance, because static methods are not referenced through a paticular instance
//			this is invalid
//			this.Age = 0;
		}

//		static constructor
//		static constructor are provided as a mean to initialize the class itself, rather than the instances of a class.
//		static constructor are not called explicitly, instead the runtime call static method automatically upon first access to the class.
		static Player()
		{
			NextId = 9999;
		}
	}

//	static class
//	static class do not have any fields
	public static class CompareTool
	{
		public static void Compare()
		{
			// do something
		}
	}
}
