using Runner.Model.Movement;
using System;

namespace Runner.UI.Buttons
{
	public class MoveNextStepButton : IButton
	{
		private IStepMovement _stepMovement;

		public MoveNextStepButton(IStepMovement stepMovement)
		{
			_stepMovement = stepMovement ?? throw new ArgumentNullException(nameof(stepMovement));
		}

		public void Press()
		{
			if(_stepMovement.CanMoveNextStep())
				_stepMovement.MoveNextStep();
		}
	}
}
