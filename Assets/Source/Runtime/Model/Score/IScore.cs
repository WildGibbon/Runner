namespace Runner.Model.Score
{
	public interface IScore
	{
		int Value { get; }
		void Increase(int value);
		void Decrease(int value);
		bool CanDown(int value);
	}
}
