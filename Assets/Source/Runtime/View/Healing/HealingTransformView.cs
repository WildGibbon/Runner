using Runner.Model.Healing;
using UnityEngine;
using System;
using Runner.View.Health;

namespace Runner.View.Healing
{
	public class HealingTransformView : MonoBehaviour
	{
		private IHealing _healing;

		public void Init(IHealing healing)
		{
			_healing = healing ?? throw new ArgumentNullException(nameof(healing));
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (TryGetComponent<IHealthTransformView>(out var healthTransformView))
				_healing.Heal(healthTransformView.Health);

			Destroy(gameObject);
		}
	}
}
