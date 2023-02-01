using Runner.Model.Health;
using UnityEngine;

namespace Runner.Model.Attack
{
	public interface IAttack
	{
		void Attack(IHealth health);
	}
}
