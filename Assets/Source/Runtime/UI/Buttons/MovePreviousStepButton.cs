using Runner.Model.Movement;
using System;

namespace Runner.UI.Buttons
{
	public class MovePreviousStepButton : IButton
	{
		private IStepMovement _stepMovement;

		public MovePreviousStepButton(IStepMovement stepMovement)
		{
			_stepMovement = stepMovement ?? throw new ArgumentNullException(nameof(stepMovement));
		}

		public void Press()
		{
			if(_stepMovement.CanMovePreviousStep())
				_stepMovement.MovePreviousStep();
		}
	}
}
