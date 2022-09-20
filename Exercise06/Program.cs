using System;

namespace Exercise06 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			You are a programmer working for a census company. 
			Write an application that prompts the user for the number of TV's they have in their homes. 

			If each TV costs $500, how much money has this person spent on TVs? 
			
			Your program must calculate and display the answer.
			*/
			#endregion

			Console.WriteLine("How many TV's do you have at home? ");
			int count = int.Parse(Console.ReadLine());

			double amount = 500.00 * count;

			Console.WriteLine($"Assuming a TV costs $500.00, you have spent {amount:C}.");
		}
	}
}
