using Runner.Root.SystemUpdates;
using UnityEngine;
using System;

namespace Runner.Model.Spawn.Timer
{
	public class Timer : ITimer
	{
		public bool IsActive { get; private set; }

		private readonly float _timeBetweenActivation;
		private float _elapsedTime;

		public Timer(float timeBetweenActivation)
		{
			if(timeBetweenActivation< 0)
			{
				throw new ArgumentOutOfRangeException("TimeBetweenSpawn can not be less than 0");
			}

			_timeBetweenActivation = timeBetweenActivation;
		}

		public void Update(float deltaTime)
		{
			IsActive = false;

			if (_elapsedTime >= _timeBetweenActivation)
			{
				IsActive = true;
				_elapsedTime = 0;
			}

			_elapsedTime += deltaTime;
		}
	}
}
