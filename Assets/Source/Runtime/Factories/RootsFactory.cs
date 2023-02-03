using Runner.Root;
using System.Collections.Generic;
using UnityEngine;

namespace Runner.Factories
{
	public class RootsFactory : MonoBehaviour, IFactory<CompositeRoot>
	{
		[SerializeField] private List<Transform> _spawnPoints;
		[SerializeField] private List<CompositeRoot> _spawningEnemies;

		public CompositeRoot Create()
		{
			var randomSpawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Count)];
			var randomRoot = _spawningEnemies[Random.Range(0, _spawningEnemies.Count)];

			var root = Instantiate(randomRoot, randomSpawnPoint.position, Quaternion.identity);
			root.Compose();

			return root;
		}
	}
}
