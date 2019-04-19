using System;
using System.Collections.Generic;

namespace vendigo
{
	public interface IUnitedStates
	{
		bool Recyclable { get; set; }
		List<string> Ingredients { get; set; }
	}
}