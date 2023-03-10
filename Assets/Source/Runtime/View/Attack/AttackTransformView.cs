using Runner.Model.Attack;
using Runner.View.Health;
using System;
using UnityEngine;

namespace Runner.View.Attack
{
	public class AttackTransformView : MonoBehaviour
	{
		private IAttack _attack;

		public void Init(IAttack attack)
		{
			_attack = attack ?? throw new ArgumentNullException("Attack can not be null");
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.TryGetComponent<IHealthTransformView>(out var healthTransformView))
			{
				_attack.Attack(healthTransformView.Health);	
			}

		}
	}
}
