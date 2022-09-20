using System;

namespace Exercise09 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/* 
			Write a program that prompts the user for how many gallons of water he or she drinks per day. 
			If the answer is lower than 1 galon, display the message "You should drink more water!". 
			If the answer is greater than or equal to 1 galon, display the message "Good!".
			*/
			#endregion

			Console.WriteLine("How many galons of water do you drink per day? ");
			double galons = double.Parse(Console.ReadLine());

			if (galons < 1)
				Console.WriteLine("You should drink more water!");
			else
				Console.WriteLine("Good!");
		}
	}
}
