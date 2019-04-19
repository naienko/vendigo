using System;
using System.Collections.Generic;

namespace vendigo
{
	public interface IJapan
	{
		List<string> FoodColors { get; set; }
		string RfIdFrequency { get; set; }
		void RfIdBroadcast(string RfIdFrequency);
	}
}