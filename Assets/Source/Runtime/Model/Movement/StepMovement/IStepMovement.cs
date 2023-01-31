using Runner.Root.SystemUpdates;

namespace Runner.Model.Movement
{
	public interface IStepMovement : IUpdatable
	{
		void MoveNextStep();
		void MovePreviousStep();
	}
}