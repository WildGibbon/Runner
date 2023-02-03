using System;
using Runner.Model.Healing;
using Runner.Model.Health;

namespace Runtime.Model.Healing
{
	public class DefaultHealing : IHealing
	{
		private readonly int _healingValue;

		public DefaultHealing(int healingValue)
		{
			if(healingValue < 0)
				throw new ArgumentOutOfRangeException(nameof(healingValue));

			_healingValue = healingValue;
		}

		public void Heal(IHealth health)
		{
			health.Heal(_healingValue);
		}
	}
}
