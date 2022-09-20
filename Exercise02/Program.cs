using System;

namespace Exercise02 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			Make a console application that prompts the user for their name and age, 
			and then prints out a friendly message containing that data.
			*/
			#endregion

			Console.WriteLine("Please input your name: ");
			string name = Console.ReadLine();

			Console.WriteLine("How old are you? ");
			int age = int.Parse(Console.ReadLine());

			Console.WriteLine($"Hello, {name}! You don't look {age} to me!");
		}
	}
}
