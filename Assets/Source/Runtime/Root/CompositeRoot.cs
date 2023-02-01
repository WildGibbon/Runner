using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sirenix.OdinInspector;

namespace Runner.Root
{
	public abstract class CompositeRoot : SerializedMonoBehaviour
	{
		public abstract void Compose();
	}
}
