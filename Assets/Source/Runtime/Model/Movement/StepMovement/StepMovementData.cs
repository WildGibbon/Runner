using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Runner.Model.Movement
{
	public struct StepMovementData
	{
		public float StepLength { get; private set; }
		public float Speed { get; private set; }
		public Vector2 MovementAxis { get; private set; }
		
		public StepMovementData(float stepLength, float speed, Vector2 axis)
		{
			if(stepLength < 0)
				throw new ArgumentOutOfRangeException(nameof(stepLength));
			if(speed < 0)
				throw new ArgumentOutOfRangeException(nameof(speed));

			StepLength = stepLength;
			Speed = speed;
			MovementAxis = axis.normalized;
		}
	}
}
