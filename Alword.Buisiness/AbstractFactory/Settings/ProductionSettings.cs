using Alword.Buisiness.AbstractFactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alword.Buisiness.AbstractFactory.Settings
{
	class ProductionSettings : BaseSettings
	{
		public override string ConnecionString => "Подключаюсь к рабочему серверу";
	}
}
