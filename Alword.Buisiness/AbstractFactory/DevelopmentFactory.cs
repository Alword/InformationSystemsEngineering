using Alword.Buisiness.AbstractFactory.Abstractions;
using Alword.Buisiness.AbstractFactory.Attributes;
using Alword.Buisiness.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.AbstractFactory
{
	public class DevelopmentFactory : BaseConfigurationFactory
	{
		public override BaseAttributes CreateAttributes()
		{
			return new LocalAttributes();
		}

		public override SettingsBuilder CreateSettings()
		{
			return new InMemoryStorage();
		}
	}
}
