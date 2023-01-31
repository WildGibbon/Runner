using System;
using UnityEngine;
using Runner.View.Movement.StepMovement;

namespace Runner.Model.Movement
{
	public class StepMovement : IStepMovement
	{
		private Vector2 _currentPosition;
		private Vector2 _targetPosition;
		
		private readonly StepMovementData _data;
		private readonly IMovementView _view;

		public StepMovement(Vector2 currentPosition, IMovementView view, StepMovementData data)
		{
			_view = view ?? throw new ArgumentNullException(nameof(view));
			_currentPosition = _targetPosition = currentPosition;
			_data = data;
		}

		public void MoveNextStep()
		{
			_targetPosition += _data.StepLength * _data.MovementAxis;
		}

		public void MovePreviousStep()
		{
			_targetPosition -= _data.StepLength * _data.MovementAxis;
		}

		public void Update(float deltaTime)
		{
			_currentPosition = Vector2.MoveTowards(_currentPosition, _targetPosition, deltaTime * _data.Speed);
			_view.Visualize(_currentPosition);
		}
	}
}
