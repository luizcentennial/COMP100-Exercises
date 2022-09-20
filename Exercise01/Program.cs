using System;

namespace Exercise01 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			Make a console application that prompts the user for their name, 
			and welcomes them with a warm greeting.
			*/
			#endregion

			Console.WriteLine("Please input your name: ");
			string name = Console.ReadLine();

			Console.WriteLine($"Hello, {name}! It's nice to see you!");
		}
	}
}
