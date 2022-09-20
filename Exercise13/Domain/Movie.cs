using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13.Domain {
	public class Movie {
		public string MovieID { get; set; }
		public string Name { get; set; }
		public bool IsShowing { get; set; }
		public double Rating { get; set; }
		public DateTime ReleaseDate { get; set; }
		public Genre Genre { get; set; }

		public Movie() {
			this.MovieID = Guid.NewGuid().ToString();
		}

		public override string ToString() {
			return $"Movie ID: {this.MovieID} \n" +
				   $"Name: {this.Name} \n" +
				   $"Showing Now: {this.IsShowing} \n" +
				   $"Rating: {this.Rating:F1} \n" +
				   $"Release Date: {this.ReleaseDate} \n" +
				   $"Genre: {this.Genre} ";
		}
	}

	public enum Genre {
		Action,
		Romance,
		Comedy,
		Horror
	}
}
