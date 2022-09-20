using System;

namespace Exercise04 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			Make a console application that prompts the user for two numbers, 
			and displays the result of the division number1 / number2.
			*/
			#endregion

			Console.WriteLine("Please input the first number: ");
			double number1 = double.Parse(Console.ReadLine());

			Console.WriteLine("Please input the second number: ");
			double number2 = double.Parse(Console.ReadLine());

			Console.WriteLine($"{number1} divided by {number2} equals {number1 / number2}.");
		}
	}
}
