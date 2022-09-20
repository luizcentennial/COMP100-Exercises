using System;

namespace Exercise03 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			Make a console application that calculates the area of a room that is 10 meters per 5.7 meters.
			*/
			#endregion

			double width = 10;
			double length = 5.7;
			double area = width * length;

			Console.WriteLine($"A room that is {width} wide and {length} long has {area} square meters.");
		}
	}
}
