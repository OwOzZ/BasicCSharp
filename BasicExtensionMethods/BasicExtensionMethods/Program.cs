using System;
using BasicExtensionMethods;

namespace BasicExtensionMethods
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			extension methods example
			Directory directory = new Directory();
			directory.Copy ("hehe");
		}
	}

	public class Directory 
	{
		public static void Move()
		{
			// do something
		}
		public static void Delete()
		{
			// do something
		}
	}

//	extention methods
	public static class DirectoryExtension
	{
		public static void Copy(this Directory sourceDirectory, string secondParameter)
		{
			// do something
			Console.WriteLine("extension method are called");
		}
	}
}
