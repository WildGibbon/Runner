using System;
using UnityEngine;
using Runner.View.Movement;

namespace Runner.Model.Movement
{
	public class StepMovement : IStepMovement
	{
		private Vector2 _currentPosition;
		private Vector2 _targetPosition;
		
		private readonly StepMovementData _data;
		private readonly IMovementView _view;

		public StepMovement(Vector2 startPosition, IMovementView view, StepMovementData data)
		{
			_view = view ?? throw new ArgumentNullException(nameof(view));
			_currentPosition = _targetPosition = startPosition;
			_data = data;
		}

		public void MoveNextStep()
		{
			if (!CanMoveNextStep())
				throw new InvalidOperationException();

			_targetPosition += _data.StepLength * _data.MovementAxis;
		}

		public void MovePreviousStep()
		{
			if (!CanMovePreviousStep())
				throw new InvalidOperationException();

			_targetPosition -= _data.StepLength * _data.MovementAxis;
		}

		public bool CanMoveNextStep()
		{
			var nextTargetPosition = _targetPosition + _data.StepLength * _data.MovementAxis;
			var minPosition = _data.MinPositionOnAxis * _data.MovementAxis;
			var maxPosition = _data.MaxPositionOnAxis * _data.MovementAxis;

			return Vector2.Distance(minPosition, maxPosition) >= Vector2.Distance(minPosition, nextTargetPosition);
		}

		public bool CanMovePreviousStep()
		{
			var nextTargetPosition = _targetPosition - _data.StepLength * _data.MovementAxis;
			var minPosition = _data.MinPositionOnAxis * _data.MovementAxis;
			var maxPosition = _data.MaxPositionOnAxis * _data.MovementAxis;

			return Vector2.Distance(minPosition, maxPosition) >= Vector2.Distance(maxPosition, nextTargetPosition);
		}

		public void Update(float deltaTime)
		{
			_currentPosition = Vector2.MoveTowards(_currentPosition, _targetPosition, deltaTime * _data.Speed);
			_view.Visualize(_currentPosition);
		}
	}
}
