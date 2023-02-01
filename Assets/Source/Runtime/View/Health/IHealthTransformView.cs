using Runner.Model.Health;

namespace Runner.View.Health
{
	public interface IHealthTransformView
	{
		IHealth Health { get; }

		void Init(IHealth health);
	}
}