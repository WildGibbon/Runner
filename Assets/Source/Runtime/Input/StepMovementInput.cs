using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Runner.Input
{
	//It is not working module
	public class StepMovementInput : MonoBehaviour, IStepMovementInput
	{
		[SerializeField] private Button _nextStepButton;
		[SerializeField] private Button _previousStepButton;

		public bool IsMoveNextStepButtonPressed => throw new NotImplementedException();
		public bool IsMovePreviousStepButtonPressed => throw new NotImplementedException();
	}
}
