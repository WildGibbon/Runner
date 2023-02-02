using Runner.View.Movement;
using Runner.Root.SystemUpdates;
using System;
using UnityEngine;

namespace Runner.Model.Movement
{
	public class DirectionalMovement : IDirectionalMovement
	{
		public Vector2 CurrentPosition { get; private set; }

		private readonly DirectionalMovementData _data;
		private readonly IMovementView _view;

		public DirectionalMovement(IMovementView view, DirectionalMovementData data, Vector2 position)
		{
			CurrentPosition = position;
			_data = data;
			_view = view ?? throw new ArgumentNullException("View can not be null");
		}

		public void Update(float deltaTime)
		{
			CurrentPosition += _data.Direction.normalized * _data.Speed * deltaTime;
			_view.Visualize(CurrentPosition);
		}
	}
}
