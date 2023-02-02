using Runner.Model.Attack;
using Runner.Model.Enemy;
using Runner.Model.Movement;
using Runner.Root.SystemUpdates;
using Runner.View.Attack;
using Runner.View.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Runner.Root
{
	public class EnemyRoot : CompositeRoot
	{
		[SerializeField] private AttackTransformView _attack;
		[SerializeField] private int _damage;
		[SerializeField] private IEnemy _enemy;
		[SerializeField] private int _scoreIncreaseValue;
		[SerializeField] private IMovementView _movementView;
		[SerializeField] private int _speed;
		[SerializeField] private Vector2 _moveDirection;

		private IDirectionalMovement _movement;
		private ISystemUpdate _systemUpdate;

		public override void Compose()
		{
			_systemUpdate = new SystemUpdate();

			var attack = new DefaultAttack(_damage);
			_attack.Init(attack);

			_enemy.Init(_scoreIncreaseValue);

			var movementData = new DirectionalMovementData(_speed, _moveDirection);
			_movement = new DirectionalMovement(_movementView, movementData, transform.position);

			_systemUpdate.Add(_movement);
		}

		private void Update() => _systemUpdate.UpdateAll(Time.deltaTime);
	}
}
