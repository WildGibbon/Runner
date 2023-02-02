using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Runner.Model.Enemy
{
	public interface IEnemy
	{
		int ScoreUpValue { get; }
		void Init(int scoreUpValue);
	}
}