using Runner.Model.Movement;
using System;

namespace Runner.UI.Buttons
{
	public class PreviousStepMoveButton : IButton
	{
		private IStepMovement _stepMovement;

		public PreviousStepMoveButton(IStepMovement stepMovement)
		{
			_stepMovement = stepMovement ?? throw new ArgumentNullException(nameof(stepMovement));
		}

		public void Press()
		{
			_stepMovement.MovePreviousStep();
		}
	}
}
