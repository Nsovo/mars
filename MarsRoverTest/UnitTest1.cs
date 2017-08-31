using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MassRoverConsoleApp;
using System.Collections.Generic;

namespace MarsRoverTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void CanTurnLeftDirectionE()
		{
			var roverMovement = new RoverMovement();
			Assert.AreEqual("N", roverMovement.TurnLeft("E"));
		}

		[TestMethod]
		public void NotLeftTurnOfE()
		{
			var roverMovement = new RoverMovement();
			Assert.AreNotEqual("S", roverMovement.TurnLeft("E"));
		}

		[TestMethod]
		public void CanTurnRightDirectionN()
		{
			var roverMovement = new RoverMovement();
			Assert.AreEqual("E", roverMovement.TurnRight("N"));
		}

		[TestMethod]
		public void CanMoveForward()
		{
			var roverMovement = new RoverMovement();
				var expected = new Dictionary<int, int>();
			expected.Add(1, 3);
			Assert.AreEqual(true, roverMovement.MoveForward("N",1,2).ContainsKey(1));
		}

	}
}
