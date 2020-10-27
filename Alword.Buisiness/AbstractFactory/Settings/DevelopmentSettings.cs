using Alword.Buisiness.AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.AbstractFactory.Settings
{
	class DevelopmentSettings : BaseSettings
	{
		public override string ConnecionString => "Подключаюсь к стенду разработки";
	}
}
