using System;
using System.Collections.Generic;
using System.Globalization;

namespace vendigo
{
	public class SundriesVendingMachine : VendingMachine, ITypedMachine<ISundries>
	{
		public List<ISundries> CurrentStock { get; set; } = new List<ISundries>();
		public List<ISundries> SoldItems { get; set; } = new List<ISundries>();
		public void Purchase(ISundries item) {
			Console.Write($@"The {item.Name} costs {item.Price.ToString("C2", CultureInfo.CreateSpecificCulture(this.Locale))}. What denomination will you be using?
> ");
			double _cashInsert = double.Parse(Console.ReadLine());
			double _change = _cashInsert - item.Price;
			Console.WriteLine($"You spent {_cashInsert.ToString("C2", CultureInfo.CreateSpecificCulture(this.Locale))}. You recieved {item.Name}. Your change is {_change.ToString("C2", CultureInfo.CreateSpecificCulture(this.Locale))}. Thank you for your purchase.");
			Record(item);
		}
		public void Record(ISundries item) {
			SoldItems.Add(item);
		}
		public void Load(ISundries item)
		{
			if (CurrentStock.Count >= Capacity) {
				Console.WriteLine("The vending machine is full. No more products can be added.");
			} else {
				CurrentStock.Add(item);
			}
		}
	}
}