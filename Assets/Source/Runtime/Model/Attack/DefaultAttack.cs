using Runner.Model.Health;
using Runner.View.Health;
using System;
using UnityEngine;

namespace Runner.Model.Attack
{
	public class DefaultAttack : IAttack
	{
		private readonly int _damage;

		public DefaultAttack(int damage)
		{
			if (damage < 0)
			{
				throw new ArgumentOutOfRangeException("Damage can not be less than 0");
			}

			_damage = damage;
		}

		public void Attack(IHealth health)
		{
		    health.TakeDamage(_damage);
		}
	}
}
