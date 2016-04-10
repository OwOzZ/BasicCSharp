using System;

namespace BasicPartialKeyword
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			partial class example
			Person person1 = new Person(){LastName = "Harden", FirstName = "harden"};
			person1.LastName = "Bond";
		}
	}


	partial class Person
	{
		partial void OnLastNameChanged(string lastName);
		partial void OnFirstNameChanged(string firstName);

		private string _LastName;
		public string LastName
		{
			get
			{
				return _LastName;
			}
			set
			{
				OnLastNameChanged (value);
				_LastName = value;
			}
		}

		private string _FirstName;
		public string FirstName
		{
			get
			{
				return _FirstName;
			}
			set
			{
				OnFirstNameChanged (value);
				_FirstName = value;
			}
		}
	}

	partial class Person
	{
		partial void OnLastNameChanged(string lastName)
		{
			if(lastName == null)
			{
				throw new ArgumentNullException("value");
			}else
			{
				if(lastName.Trim().Length != 0)
				{
					Console.WriteLine("the new LastName is:{0}", lastName);
				}
			}
		}
	}
}
