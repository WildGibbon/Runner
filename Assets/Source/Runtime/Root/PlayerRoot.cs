using Runner.Model.Movement;
using Runner.Model.Score;
using Runner.Root.SystemUpdates;
using Runner.UI;
using Runner.UI.Buttons;
using Runner.View.Health;
using Runner.View.Movement;
using Runner.View.Score;
using UnityEngine;

namespace Runner.Root
{
	public class PlayerRoot : CompositeRoot
	{
		[SerializeField] private IHealthTransformView _health;
		[SerializeField] private IScoreView _scoreView;
		[SerializeField] private UnityButton _nextStepButton;
		[SerializeField] private UnityButton _previousStepButton;
		[SerializeField] private float _stepLength;
		[SerializeField] private float _moveSpeed;
		[SerializeField] private Vector2 _moveAxis;
		[SerializeField] private IMovementView _movementView;
		
		private ISystemUpdate _systemUpdate;

		public IScore Score { get; private set; }

		public override void Compose()
		{
			_systemUpdate = new SystemUpdate();
			Score = new Score(0, _scoreView);

			var movementData = new StepMovementData(_stepLength, _moveSpeed, _moveAxis);
			var movement = new StepMovement(transform.position, _movementView, movementData);

			_nextStepButton.Init(new NextStepMoveButton(movement));
			_previousStepButton.Init(new PreviousStepMoveButton(movement));

			_systemUpdate.Add(movement);
		}

		private void Update()
		{
			_systemUpdate.UpdateAll(Time.deltaTime);
		}
	}
}
