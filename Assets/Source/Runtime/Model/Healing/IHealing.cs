using Runner.Model.Health;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Model.Healing
{
	public interface IHealing
	{
		void Heal(IHealth health);
	}
}
