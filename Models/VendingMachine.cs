using System;

namespace vendigo
{
	public class VendingMachine : IVending
	{
		public string Type { get; set; }
		public string Locale { get; set; }
		public int Capacity { get; set; }

	}
}