using System;

namespace Exercise10 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			Write a program that prints all multiples of 7 from 0 to 100.
			*/
			#endregion

			for (int i = 0; i < 100; i++) 
				if (i % 7 == 0)
					Console.WriteLine(i);
			
		}
	}
}
