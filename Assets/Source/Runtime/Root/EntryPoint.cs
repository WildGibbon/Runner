using System.Collections.Generic;
using UnityEngine;

namespace Runner.Root
{
	public class EntryPoint : MonoBehaviour
	{
		[SerializeField] private List<CompositeRoot> _roots;

		private void Awake()
		{
			_roots.ForEach(root => root.Compose());
		}
	}
}
