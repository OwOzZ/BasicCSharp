using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicPolymorphism
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person person1 = new Player ("James Harden");
			Person person2 = new Student ("Stephen Curry");

			List<Person> personList = new List<Person> ();
			personList.Add (person1);
			personList.Add (person2);

			foreach (Person person in personList) 
			{
				Console.WriteLine (person.GetSummary ());
			}
		}
	}

	public abstract class Person
	{
		public Person(string name)
		{
			Name = name;
		}
		public virtual string Name{ get; set;}
		public abstract string GetSummary();
	}

	public class Player: Person
	{
		public Player(string name): base(name){}
		
		public string FirstName{ get; set; }
		public string LastName{ get; set; }
		public override string Name
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
			set
			{
				string[] strArr= value.Split (' ');
				FirstName = strArr [0];
				LastName = strArr [1];
			}
		}

		public override string GetSummary ()
		{
			return "This is a player class";
		}
	}

	public class Student: Person
	{
		public Student (string name) : base (name){}
		public override string GetSummary ()
		{
			return "This is a student class";
		}
	}
}
