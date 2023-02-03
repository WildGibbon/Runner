using Runner.Factories;
using Runner.Model.Spawn;
using Runner.Model.Spawn.Timer;
using Runner.Root.SystemUpdates;
using System.Collections.Generic;
using UnityEngine;

namespace Runner.Root
{
	public class CompositeRootsSpawnRoot : CompositeRoot
	{
		[SerializeField] private RootsFactory _factory;
		[SerializeField] private int _timeBetweenSpawn;

		private SpawnCycle<CompositeRoot> _spawnCycle;
		private ISystemUpdate _systemUpdate;

		public override void Compose()
		{
			_systemUpdate = new SystemUpdate();

			var timer = new Timer(_timeBetweenSpawn);
			_spawnCycle = new SpawnCycle<CompositeRoot>(_factory, timer);

			_systemUpdate.Add(timer, _spawnCycle);
		}

		private void Update() => _systemUpdate.UpdateAll(Time.deltaTime);
	}
}
