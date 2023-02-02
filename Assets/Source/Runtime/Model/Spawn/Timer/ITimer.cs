using Runner.Root.SystemUpdates;

namespace Runner.Model.Spawn.Timer
{
	public interface ITimer : IUpdatable
	{
		bool IsActive { get; }
	}
}
