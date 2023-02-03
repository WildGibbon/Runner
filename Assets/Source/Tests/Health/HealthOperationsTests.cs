using Runner.Model.Health;
using NUnit.Framework;

namespace FlappyBean.Tests.Health
{
	public class HealthOperationsTests
	{
		private IHealth _health;

		[SetUp]
		public void Setup()
		{
			_health = new Runner.Model.Health.Health(100, 100);
		}

		[Test]
		public void IsDamagingWorksCorrectly()
		{
			var errors = 0;

			try
			{
				_health.TakeDamage(-1);
			}

			catch { errors++; }

			try
			{
				_health.TakeDamage(100);
				_health.TakeDamage(1);
			}

			catch { errors++; }

			Assert.AreEqual(errors, 2);
		}

		[Test]
		public void IsHealingWorksCorrectly()
		{
			var errors = 0;

			try
			{
				_health.Heal(-1);
			}

			catch { errors++; }

			try
			{
				_health.TakeDamage(100);
				_health.Heal(1);
			}

			catch { errors++; }

			Assert.AreEqual(errors, 2);
		}

		[Test]
		public void IsDamageCalculatingCorrectly()
		{
			_health.TakeDamage(1);

			Assert.AreEqual(_health.Value, 99);
		}


		[Test]
		public void IsHealingCalculatingCorrectly()
		{
			_health.TakeDamage(25);
			_health.Heal(25);

			Assert.AreEqual(_health.Value, 100);
		}
	}
}