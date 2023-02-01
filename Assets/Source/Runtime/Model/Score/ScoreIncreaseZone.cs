using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Runner.Model.Score;
using Runner.Model.Player;

namespace Runner.Model.Score
{
	[RequireComponent(typeof(BoxCollider2D))]
	public class ScoreIncreaseZone : MonoBehaviour
	{
		private IScore _increasingScore;

		public void Init(IScore score)
		{
			_increasingScore = score ?? throw new ArgumentNullException(nameof(score));
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.TryGetComponent<IEnemy>(out var enemy))
			{
				_increasingScore.Increase(enemy.ScoreUpValue);
			}
		}
	}
}