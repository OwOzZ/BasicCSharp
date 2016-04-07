using System;
using System.Collections.Generic;


namespace BasicInitialize
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			Player player1 = new Player () { Name = "James", Des = "Best Player" };

			Player player2 = new Player ("curry", "try");

//			Collection Initializer, added in C#3.0
			List<Player> playerList = new List<Player> () {
				new Player ("Lenard", "SF"),
				new Player ("Geoge", "SG/SF/PF")
			};

			Console.WriteLine (playerList);

//			Anonymous type
			var player3 = new{Name = "Howard", Des="C"};
			Console.WriteLine (player3);
		} 
	}
	public class Player
	{
		public string Name{ get; set; }
		public string Des{get; set;}
		public int Id{ get; set;}


		public Player(string newName, string newDes)
		{
			Name = newName;
			Des = newDes;
		}

//		 overloading constructor
//		 you can have more than one constructor as long as the numbers or types of parameters vary
		public Player(int id)
		{
			Id = id;
		}

		public Player(int id, string newName)
		{
			Id = id;
			Name = newName;
		}

//		Constructor Chaining
//		Calling another constructor using this keyword
		public Player(int id, string newName, string newDes):this(newName, newDes)
		{
			Id = id;
		}

//		Centralizing Initialization
		public Player(string newDes)
		{
			int id = 12;
			string newName = "parsens";
			Initialize (id, newName, newDes);
		}

		private void Initialize(int id, string newName, string newDesc)
		{
			Id = id;
			Name = newName;
			Des = newDesc;
		}
	}
}
