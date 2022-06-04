using System;
using System.Collections.Generic;

namespace FactoryExample
{
	public class AudiFactory : Factory<Car>
	{
		public override void CreateOutput()
		{
			ProductionList.Add(new Audi());
			ProductionList.Add(new Audi());
			ProductionList.Add(new Audi());
			ProductionList.Add(new Audi());
		}
	}
}