using System;

namespace Exercise12 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			Write a program that displays the factorial of a number provided by the user. 
			The calculation logic should be in a dedicated method called CalculateFactorial.
			Example: 5! = 5 * 4 * 3 * 2 * 1.
			*/
			#endregion

			Console.WriteLine("Please input a number: ");
			int input = int.Parse(Console.ReadLine());

			int factorial = CalculateFactorial(input);

			Console.WriteLine($"{input}! = {factorial}");
		}

		public static int CalculateFactorial(int number) {
			int result = 1;
			int count = 1;

			do {
				result *= count; // Same as result = result * count;
				count++;
			} while (count <= number);

			return result;
		}
	}
}
