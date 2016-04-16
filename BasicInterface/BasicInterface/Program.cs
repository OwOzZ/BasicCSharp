using System;

namespace BasicInterface
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			BasketBallPlayer player = new BasketBallPlayer ();
			player.Name = "James Harden";
//			explicitly interface, cannot call interface member directly
//			player.PlayDesc (player.Name);
			((IPlay)player).PlayDes(player.Name);

			Student student = new Student ();
			student.Name = "Stephen Curry";
			student.PlayDes(student.Name);
		}
	}
		
	interface IPlay
	{
		void PlayDes(string Name);
	}

	interface ILearn
	{
		void Learning();
	}

	interface IDo: ILearn
	{
		void doSomething();
	}

	public abstract class Person
	{
		public virtual string Name{ get; set;}

		public abstract void GetSummary ();
	}

	public class BasketBallPlayer: Person, IPlay
	{
		public string FirstName{get; set;}
		public string LastName{ get; set;}

		public override string Name {
			get {
				return $"{FirstName} {LastName}";
			}
			set {
				string[] tempStrArr = value.Split (' ');
				FirstName = tempStrArr [0];
				LastName = tempStrArr [1];
			}
		}

		void IPlay.PlayDes(string name)
		{
			Console.WriteLine ($"I'm {name}, I'm a basketball player");
		}

		public override void GetSummary()
		{
			// do something
		}
	}

	public class Student: Person, IPlay
	{
//		public string FirstName{get; set;}
//		public string LastName{ get; set;}
//
//		public override string Name {
//			get {
//				return $"{FirstName} {LastName}";
//			}
//			set {
//				string[] tempStrArr = value.Split (' ');
//				FirstName = tempStrArr [0];
//				LastName = tempStrArr [1];
//			}
//		}

		public void PlayDes(string name)
		{
			Console.WriteLine ($"I'm {name}, I'm a student");
		}

		public override void GetSummary()
		{
			// do something
		}
	}

	public class Baby: Person, IDo, IPlay
	{
//		IDo derived from ILearning
//		must implement the whole interface hierachy
		public void Learning()
		{
			// do something
		}

		public void doSomething()
		{
			// do something
		}

		public override void GetSummary()
		{
			// do something
		}

		public void PlayDes(string name)
		{
			
		}
	}
}
