using NUnit.Framework;
using Runner.Model.Health;

namespace FlappyBean.Tests.Health
{
	public class CreatingHealthTests
	{
		[Test]
		public void CantCreateHealthWithInvalidArguments()
		{
			var errors = 0;

			try
			{
				var healthWithNegativeCount = new Runner.Model.Health.Health(-1);
			}

			catch { errors++; }

			Assert.AreEqual(errors, 1);
		}
	}
}