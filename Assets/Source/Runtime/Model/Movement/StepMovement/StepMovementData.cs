using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Runner.Model.Movement
{
	public struct StepMovementData
	{
		public float MaxPositionOnAxis { get; private set; }
		public float MinPositionOnAxis { get; private set; }
		public float StepLength { get; private set; }
		public float Speed { get; private set; }
		public Vector2 MovementAxis { get; private set; }

		public StepMovementData(float stepLength, float speed, Vector2 axis, float maxPositionOnAxis, float minPositionOnAxis)
		{
			if (stepLength < 0)
				throw new ArgumentOutOfRangeException(nameof(stepLength));
			if (speed < 0)
				throw new ArgumentOutOfRangeException(nameof(speed));
			if (maxPositionOnAxis <= minPositionOnAxis)
				throw new ArgumentException("MaxPositionOnAxis cant be less or equal MinPositionOnAxis");

			Speed = speed;
			StepLength = stepLength;
			MovementAxis = axis.normalized;
			MaxPositionOnAxis = maxPositionOnAxis;
			MinPositionOnAxis = minPositionOnAxis;
		}
	}
}
