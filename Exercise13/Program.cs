using System;
using Exercise13.Domain;

namespace Exercise13 {
	class Program {
		static void Main(string[] args) {
			#region QUESTION
			/*
			Define a class called Movie. In this class, you must define at least 5 properties that 
			describe attributes that a movie has. You are free to come up with your own properties, 
			but you must use at least one instance of each of the following data types: 
			
			- string, 
			- double, 
			- boolean, 
			- DateTime. 
			
			Your first property must be a string MovieID, which is initialized (in the constructor) 
			to a value that is guaranteed to be unique.

			The Movie class must have only one constructor, which is parameterless.

			In your Movie class, override the ToString method, so that it returns a string that contains 
			meaningful information about the object.
			*/
			#endregion

			Movie movie = new Movie();
			movie.Name = "Rambo";
			movie.Genre = Genre.Action;
			movie.IsShowing = true;
			movie.Rating = 9.9;
			movie.ReleaseDate = new DateTime(1982, 7, 15);

			Console.WriteLine(movie);
		}
	}
}
