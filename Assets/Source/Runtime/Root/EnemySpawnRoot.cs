using Runner.Factories;
using Runner.Model.Spawn;
using Runner.Model.Spawn.Timer;
using Runner.Root.SystemUpdates;
using System.Collections.Generic;
using UnityEngine;

namespace Runner.Root
{
	public class EnemySpawnRoot : CompositeRoot
	{
		[SerializeField] private EnemyFactory _factory;
		[SerializeField] private int _timeBetweenSpawn;
		[SerializeField] private List<Transform> _spawnPoints;

		private SpawnCycle<EnemyRoot> _spawnCycle;
		private ISystemUpdate _systemUpdate;

		public override void Compose()
		{
			_systemUpdate = new SystemUpdate();

			var timer = new Timer(_timeBetweenSpawn);
			_spawnCycle = new SpawnCycle<EnemyRoot>(_factory, timer);

			_systemUpdate.Add(timer, _spawnCycle);
		}

		private void Update() => _systemUpdate.UpdateAll(Time.deltaTime);
	}
}
