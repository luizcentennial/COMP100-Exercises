using System;

namespace Exercise05 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			Make a console application that calculates the area of a circle. 
			The radius must be informed by the user.
			*/
			#endregion

			Console.WriteLine("Please input a radius value: ");
			double radius = double.Parse(Console.ReadLine());

			// A = pi * radius ^ 2
			double area = Math.PI * Math.Pow(radius, 2);

			Console.WriteLine($"A circle with radius {radius:F3} has area {area:F3}.");
		}
	}
}
