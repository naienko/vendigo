using System;
using System.Collections.Generic;

namespace vendigo
{
	public interface ITypedMachine<T> : IVending
	{
		List<T> CurrentStock { get; set; }
		List<T> SoldItems { get; set; }
		void Purchase(T item);
		void Record(T item);
		void Load(T item);
	}
}