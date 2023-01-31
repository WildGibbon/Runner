using Runner.Input;
using Runner.Model.Movement;
using Runner.Root.SystemUpdates;
using System;

namespace Runner.Model.Player
{
	public class Player : IUpdatable
	{
		private readonly IStepMovementInput _input;
		private readonly IStepMovement _movement;

		public Player(IStepMovementInput input, IStepMovement movement)
		{
			_input = input ?? throw new ArgumentNullException(nameof(input));
			_movement = movement ?? throw new ArgumentNullException(nameof(movement));
		}

		public void Update(float deltaTime)
		{
			if (_input.IsMoveNextStepButtonPressed)
			{
				_movement.MoveNextStep();
			}

			if(_input.IsMovePreviousStepButtonPressed)
			{
				_movement.MovePreviousStep();
			}

			_movement.Update(deltaTime);
		}
	}
}
