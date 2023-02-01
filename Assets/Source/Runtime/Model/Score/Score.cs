using Runner.Model.Score;
using Runner.View.Score;
using System;

namespace Runner.Model.Score
{
	public class Score : IScore
	{
		public int Value { get; private set; }

		private readonly IScoreView _view;

		public Score(int value, IScoreView view)
		{
			if(value < 0)
			{
				throw new ArgumentOutOfRangeException("Score can not be less than 0");
			}
			Value = value;

			_view = view ?? throw new ArgumentNullException("Score view can not be null");
		}

		public void Decrease(int value)
		{
			if(value < 0)
			{
				throw new ArgumentOutOfRangeException("Value can not be less than 0");
			}

			if (!CanDown(value))
			{
				throw new InvalidOperationException($"Can not score lower on {value}, its so much");
			}
			
			Value -= value;
			_view.Visualize(Value);
		}

		public void Increase(int value)
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("Value can not be less than 0");
			}

			Value += value;
			_view.Visualize(Value);
		}

		public bool CanDown(int value)
		{
			return Value - value >= 0;
		}
	}
}
