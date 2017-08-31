using System;
using System.Collections.Generic;

namespace MassRoverConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\n1 Enter Location of the text file or leave empty to use default file");
			string line = Console.ReadLine();

			if (string.IsNullOrEmpty(line))
				line = "marsrover.txt";

			string[] data = System.IO.File.ReadAllLines(@"" + line);

			List<String> deployedRovers = new List<string>();
			foreach (var rover in GetRoverList(data))
			{
				string navigate = NavigateRover.Navigate(rover.Coordinates, rover.Movement);
				deployedRovers.Add(navigate);
			}

			foreach (string item in deployedRovers)
			{
				Console.WriteLine(item);
			}
		}

		//reads the input , parses it and returns rovers deployed in mars
		private static List<Rover> GetRoverList(string[] data)
		{
			var rovers = new List<Rover>();
			for (int i = 1; i <= data.Length - 1; i++)
			{
				var rover = new Rover()
				{
					Coordinates = data[i],
					Movement = data[i + 1]
				};
				rovers.Add(rover);
				i += 1;
			}
			return rovers;
		}




	}
}
