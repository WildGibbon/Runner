using Runner.View.Score;
using UnityEngine;
using UnityEngine.UI;

namespace Runner.View.Score
{
	public class ScoreView : MonoBehaviour, IScoreView
	{
		[SerializeField] private Text _label;

		public void Visualize(int score)
		{
			_label.text = score.ToString();
		}
	}
}
