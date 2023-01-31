namespace Runner.Input
{
	public interface IStepMovementInput
	{
		bool IsMoveNextStepButtonPressed { get; }
		bool IsMovePreviousStepButtonPressed { get; }
	}
}
