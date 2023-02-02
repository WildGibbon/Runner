using Runner.Root;
using System.Collections.Generic;
using UnityEngine;

namespace Runner.Factories
{
	public class EnemyFactory : MonoBehaviour, IFactory<EnemyRoot>
	{
		[SerializeField] private List<Transform> _spawnPoints;
		[SerializeField] private EnemyRoot _spawningEnemy;

		public EnemyRoot Create()
		{
			var randomPointPosition = _spawnPoints[Random.Range(0, _spawnPoints.Count)].position;
			
			return Instantiate(_spawningEnemy, randomPointPosition, Quaternion.identity);
		}
	}
}
