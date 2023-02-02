using Runner.Model.Score;
using System;
using UnityEngine;

namespace Runner.Root
{
	public class ScoreIncreaseZoneRoot : CompositeRoot
	{
		[SerializeField] private ScoreIncreaseZone _increaseZone;
		[SerializeField] private PlayerRoot _playerRoot;

		public override void Compose()
		{
			_increaseZone.Init(_playerRoot.Score);
		}
	}
}
