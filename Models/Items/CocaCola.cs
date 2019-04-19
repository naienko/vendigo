using System;
using System.Collections.Generic;

namespace vendigo
{
	public class CocaCola : Item, ISoda, IUnitedStates
	{
		public bool Recyclable { get; set; }
		public List<string> Ingredients { get; set; }
	}
}