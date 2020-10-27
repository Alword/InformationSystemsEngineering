using Alword.Buisiness.AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Alword.Buisiness.AbstractFactory
{
	public class Startup
	{
		private BaseAttributes attributes;
		private BaseSettings settings;
		public Startup(BaseConfigurationFactory configurationFactory)
		{
			attributes = configurationFactory.CreateAttributes();
			settings = configurationFactory.CreateSettings();
		}

		public Context Run()
		{
			Context context = new Context()
			{
				connectionAttributes = attributes.SimpleAttribute,
				connectionString = settings.ConnecionString
			};
			return context;
		}
	}
}
