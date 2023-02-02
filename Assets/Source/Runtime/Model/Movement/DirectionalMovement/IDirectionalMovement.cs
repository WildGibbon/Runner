using Runner.Root.SystemUpdates;
using UnityEngine;

namespace Runner.Model.Movement
{
	public interface IDirectionalMovement : IUpdatable
	{
		Vector2 CurrentPosition { get; }
	}
}
