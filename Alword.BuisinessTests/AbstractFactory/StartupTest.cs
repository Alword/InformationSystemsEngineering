using Alword.Buisiness.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Alword.BuisinessTests.AbstractFactory
{
	public class StartupTest
	{
		[Fact]
		public void DevelopmentConfig()
		{
			// Arrange
			var factory = new DevelopmentFactory();

			// Act
			Startup startup = new Startup(factory);
			var atcualContex = startup.Run();

			// Assert
			var expectedContext = new Context
			{
				connectionAttributes = "Аттрибуты для работы с локальным хранилищем",
				connectionString = "Подключаюсь к стенду разработки"
			};

			Assert.Equal(expectedContext, atcualContex);
		}

		[Fact]
		public void ProductionConfig()
		{
			// Arrange
			var factory = new ProductionFactory();

			// Act
			Startup startup = new Startup(factory);
			var atcualContex = startup.Run();

			// Assert
			var expectedContext = new Context
			{
				connectionAttributes = "Аттрибуты для работы с облаком",
				connectionString = "Подключаюсь к рабочему серверу"
			};

			Assert.Equal(expectedContext, atcualContex);
		}
	}
}
