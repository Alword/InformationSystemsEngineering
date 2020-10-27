using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.AbstractFactory.Abstractions
{
	public abstract class BaseConfigurationFactory
	{
		public abstract BaseSettings CreateSettings();
		public abstract BaseAttributes CreateAttributes();
	}
}
