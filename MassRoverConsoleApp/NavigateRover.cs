using System.Collections.Generic;
using System.Linq;

namespace MassRoverConsoleApp
{
	public class NavigateRover
	{
		public static string Navigate(string coordinates, string movement)
		{
			string navigate = "";
			INavigate roverMovement = new RoverMovement();

			string[] xyCoordinates = coordinates.Split(' ');
			string[] commands = movement.Select(c => c.ToString()).ToArray();

			Position position = new Position(int.Parse(xyCoordinates[0]), int.Parse(xyCoordinates[1]), xyCoordinates[2]);
		
			var xyValues = new Dictionary<int, int>();

			foreach (var command in commands)
			{

				if (command.Equals(Commands.M.ToString()))
					xyValues = roverMovement.MoveForward(position.Direction.ToString(), position.X, position.Y);
				else if (command.Equals(Commands.L.ToString()))
					position.Direction = roverMovement.TurnLeft(position.Direction.ToString());
				else if (command.Equals(Commands.R.ToString()))
					position.Direction = roverMovement.TurnLeft(position.Direction.ToString());

				if (xyValues.Count != 0)
					position = GetCordinates(xyValues, position);

			}
			navigate = position.X + " " + position.Y + " " + position.Direction;

			return navigate;
		}

		private static Position GetCordinates(IDictionary<int, int> xyValues, Position position)
		{
			foreach (var item in xyValues)
			{
				position.X = item.Key;
				position.Y = item.Value;
			}
			return position;
		}
	}
}
