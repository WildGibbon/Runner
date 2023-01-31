using Runner.Model.Health;
namespace FlappyBean.Runtime.View.Health
{
	public interface IHealthTransformView
	{
		IHealth Health { get; }

		void Init(IHealth health);
	}
}