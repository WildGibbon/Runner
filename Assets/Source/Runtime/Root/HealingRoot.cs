using Runner.Model.Movement;
using Runner.Root.SystemUpdates;
using Runner.View.Healing;
using Runner.View.Movement;
using Runtime.Model.Healing;
using UnityEngine;

namespace Runner.Root
{
	public class HealingRoot : CompositeRoot
	{
		[SerializeField] private HealingTransformView _healing;
		[SerializeField] private int _healingValue;
		[SerializeField] private IMovementView _movementView;
		[SerializeField] private float _moveSpeed;
		[SerializeField] private Vector2 _moveDirection;

		private ISystemUpdate _systemUpdate;
		private IDirectionalMovement _movement;

		public override void Compose()
		{
			_systemUpdate = new SystemUpdate();

			var healing = new DefaultHealing(_healingValue);
			_healing.Init(healing);

			var directionalMovementData = new DirectionalMovementData(_moveSpeed, _moveDirection);
			_movement = new DirectionalMovement(_movementView, directionalMovementData, transform.position);

			_systemUpdate.Add(_movement);
		}

		private void Update() => _systemUpdate.UpdateAll(Time.deltaTime);
	}
}
