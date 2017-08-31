using System.Collections.Generic;

namespace MassRoverConsoleApp
{
	public interface INavigate
	{
		Dictionary<int, int> MoveForward(string direction, int x, int y); // moves one step ahed of the current rover position
		string TurnRight(string direction); // turn rove 90 % in its right, changes direction but not coordiates
		string TurnLeft(string direction); //turn rove 90 % in its lett, changes direction but not coordiates
	}

}
