using UnityEngine;

namespace Runner.View.Movement
{
	public class MovementView : MonoBehaviour, IMovementView
	{
		public void Visualize(Vector2 position)
		{
			transform.position = position;
		}
	}
}
