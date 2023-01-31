using System.Collections.Generic;

namespace Runner.Root.SystemUpdates
{
	public class SystemUpdate : ISystemUpdate
	{
		private List<IUpdatable> _updatables;

		public SystemUpdate()
		{
			_updatables = new List<IUpdatable>();
		}

		public void Add(params IUpdatable[] updatables)
		{
			_updatables.AddRange(updatables);
		}

		public void UpdateAll(float deltaTime)
		{
			_updatables.ForEach(updatable => updatable.Update(deltaTime));
		}
	}
}
