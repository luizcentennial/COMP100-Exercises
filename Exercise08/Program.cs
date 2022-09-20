using System;

namespace Exercise08 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			Write a program that prompts the user for the current ambient temperature.
			If the temperature is lower than 20 degrees, display the message "Too cold!". 
			If the temperature is equal to 20, display the message "This feels good.". 
			If the temperature is higher than 20 degrees, display the message "Too warm!".
			*/
			#endregion

			Console.WriteLine("What is the current ambient temperature? ");
			double temperature = double.Parse(Console.ReadLine());

			if (temperature < 20) {
				Console.WriteLine("Too cold!");
			}
			else if (temperature == 20) {
				Console.WriteLine("This feels good.");
			}
			else {
				Console.WriteLine("Too warm!");
			}
		}
	}
}
