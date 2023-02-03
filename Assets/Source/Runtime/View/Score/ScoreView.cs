using Runner.View.Score;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Runner.View.Score
{
	public class ScoreView : MonoBehaviour, IScoreView
	{
		[SerializeField] private TMP_Text _label;

		public void Visualize(int score)
		{
			_label.text = score.ToString();
		}
	}
}
