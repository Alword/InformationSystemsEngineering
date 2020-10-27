using Alword.Buisiness.AbstractFactory.Abstractions;
using Alword.Buisiness.Builder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Alword.Buisiness.AbstractFactory
{
	public class Startup
	{
		private BaseAttributes attributes;
		private SettingsBuilder settings;
		public Startup(BaseConfigurationFactory configurationFactory)
		{
			attributes = configurationFactory.CreateAttributes();
			settings = configurationFactory.CreateSettings();
		}

		public Context Run()
		{
			Debug.WriteLine($" Подключается {settings.Username}: {nameof(settings.UseSSL)}={settings.UseSSL}");
			Context context = new Context()
			{
				connectionAttributes = attributes.SimpleAttribute,
				connectionString = settings.BuildConnectionString()
			};
			return context;
		}
	}
}
