using System;

namespace Exercise11 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			Write a program that displays the sum of all numbers from 0 to 100.
			*/
			#endregion

			int counter = 0;
			int sum = 0;

			while (counter <= 100) {
				sum += counter; // Same as sum = sum + counter;
				counter++;
			}

			Console.WriteLine($"The sum of all numbers between 0 and 100 is {sum}.");
		}
	}
}
