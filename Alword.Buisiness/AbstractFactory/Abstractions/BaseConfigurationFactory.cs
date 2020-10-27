using Alword.Buisiness.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.AbstractFactory.Abstractions
{
	public abstract class BaseConfigurationFactory
	{
		public abstract SettingsBuilder CreateSettings();
		public abstract BaseAttributes CreateAttributes();
	}
}
