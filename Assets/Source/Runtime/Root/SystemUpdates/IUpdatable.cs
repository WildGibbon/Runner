using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Root.SystemUpdates
{
	public interface IUpdatable
	{
		void Update(float deltaTime);
	}
}
