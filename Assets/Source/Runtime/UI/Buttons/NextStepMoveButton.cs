using Runner.Model.Movement;
using System;

namespace Runner.UI.Buttons
{
	public class NextStepMoveButton : IButton
	{
		private IStepMovement _stepMovement;

		public NextStepMoveButton(IStepMovement stepMovement)
		{
			_stepMovement = stepMovement ?? throw new ArgumentNullException(nameof(stepMovement));
		}

		public void Press()
		{
			_stepMovement.MoveNextStep();
		}
	}
}
