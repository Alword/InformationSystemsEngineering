using Alword.Buisiness.AbstractFactory.Abstractions;
using Alword.Buisiness.AbstractFactory.Attributes;
using Alword.Buisiness.AbstractFactory.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.AbstractFactory
{
	public class ProductionFactory : BaseConfigurationFactory
	{
		public override BaseAttributes CreateAttributes()
		{
			return new CloudAttributes();
		}

		public override BaseSettings CreateSettings()
		{
			return new ProductionSettings();
		}
	}
}
