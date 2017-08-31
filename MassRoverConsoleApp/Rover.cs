using System.Collections.Generic;

namespace MassRoverConsoleApp
{
	public class Rover
	{
		public string Movement { get; set; }
		public string Coordinates { get; set; }
	}

	public enum Direction
	{
		N,
		E,
		S,
		W 
	}

	public enum Commands {
		L,
		R,
		M
	}
}
