using System;
using System.Collections.Generic;

namespace vendigo
{
	public class Nos : Item, IEnergyDrink, IUnitedStates
	{
		public bool Recyclable { get; set; }
		public List<string> Ingredients { get; set; }
	}
}