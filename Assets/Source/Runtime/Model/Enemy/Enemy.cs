using UnityEngine;
using System;

namespace Runner.Model.Enemy
{
	public class Enemy : MonoBehaviour, IEnemy
	{
		public int ScoreUpValue { get; private set; }

		public void Init(int scoreUpValue)
		{ 
			if(scoreUpValue < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(scoreUpValue));
			}

			ScoreUpValue = scoreUpValue;
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			Destroy(this);
		}
	}
}
