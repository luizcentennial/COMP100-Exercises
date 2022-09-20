using System;

namespace Exercise07 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			Write a program that prompts the user for their hourly pay and the number of hours 
			worked in a month. Calculate and display the salary for that month.
			*/
			#endregion

			Console.WriteLine("Please input your hourly pay: ");
			double rate = double.Parse(Console.ReadLine());

			Console.WriteLine("How many hours have you worked this month? ");
			double hours = double.Parse(Console.ReadLine());

			double result = rate * hours;

			Console.WriteLine($"Your payout this month is {result:C}.");
		}
	}
}
