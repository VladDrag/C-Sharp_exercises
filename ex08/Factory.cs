using System;
using System.Collections.Generic;

namespace FactoryExample
{
	public abstract class Factory <T>
	{
		private List<T> _productionList;

		public Factory()
		{
			CreateOutput();
		}
		// Factory Method!!!
		public abstract void CreateOutput();

		public List<T> ProductionList { get { return _productionList;} }

	}
}