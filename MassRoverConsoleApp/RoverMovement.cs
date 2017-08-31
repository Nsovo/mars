using System;
using System.Collections.Generic;

namespace MassRoverConsoleApp
{
	public class RoverMovement : INavigate
	{
		public Dictionary<int, int> MoveForward(string direction, int x, int y)
		{
			Dictionary<int, int> coordinates = new Dictionary<int, int>();

			if (direction.Equals(Direction.N.ToString()))
				y ++;
			else
			if (direction.Equals(Direction.E.ToString()))
				x ++;
			else
			if (direction.Equals(Direction.S.ToString()))
				y --;
			else
			if (direction.Equals(Direction.W.ToString()))
				x --;

			coordinates.Add(x, y);
			return coordinates;
		}

		public string TurnLeft(string direction)
		{
			string directionFacing = "";
			foreach (var item in GetLeftFacingDirection())
			{
				if (item.Item1.Equals(direction))
					directionFacing = item.Item2;
			}
			return directionFacing;
		}
		public string TurnRight(string direction)
		{
			string directionFacing = "";
			foreach (var item in GetRightFacingDirection())
			{
				if (item.Item1.Equals(direction))
					directionFacing = item.Item2;
			}
			return directionFacing;
		}
		private List<Tuple<string, string>> GetLeftFacingDirection()
		{
			var directionList = new List<Tuple<string, string>>
					{
						new Tuple<string, string>(Direction.N.ToString(), Direction.W.ToString()),
						new Tuple<string,string>(Direction.E.ToString(), Direction.N.ToString()),
						new Tuple<string, string>( Direction.S.ToString(), Direction.E.ToString()),
						new Tuple<string, string>( Direction.W.ToString(), Direction.S.ToString())
					};
			return directionList;
		}

		private List<Tuple<string, string>> GetRightFacingDirection()
		{
			var directionList = new List<Tuple<string, string>>
					{
						new Tuple<string, string>(Direction.N.ToString(), Direction.E.ToString() ),
						new Tuple<string,string>(Direction.E.ToString(), Direction.S.ToString() ),
						new Tuple<string, string>( Direction.S.ToString(), Direction.W.ToString() ),
						new Tuple<string, string>( Direction.W.ToString(), Direction.N.ToString() )
					};
			return directionList;
		}
		private int PositiveCoordinate(int value, string direction)
		{
			value++;
			return value;
		}
		private int NegativeCoordinate(int value)
		{
			value--;
			return value;
		}

	}

}
