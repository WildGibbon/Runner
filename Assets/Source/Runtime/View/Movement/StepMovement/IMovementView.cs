using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Runner.View.Movement.StepMovement
{
	public interface IMovementView
	{
		void Visualize(Vector2 position);
	}
}
