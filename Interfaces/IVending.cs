using System;

namespace vendigo
{
	public interface IVending
	{
		string Type { get; set; }
		string Locale { get; set; }
		int Capacity { get; set; }

	}
}