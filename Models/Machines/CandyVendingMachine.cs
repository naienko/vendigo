using System;
using System.Collections.Generic;
using System.Globalization;

namespace vendigo
{
	public class CandyVendingMachine : VendingMachine, ITypedMachine<ICandy>
	{
		public List<ICandy> CurrentStock { get; set; } = new List<ICandy>();
		public List<ICandy> SoldItems { get; set; } = new List<ICandy>();
		public void Purchase(ICandy item) {
			Console.Write($@"The {item.Name} costs {item.Price.ToString("C2", CultureInfo.CreateSpecificCulture(this.Locale))}. What denomination will you be using?
> ");
			double _cashInsert = double.Parse(Console.ReadLine());
			double _change = _cashInsert - item.Price;
			Console.WriteLine($"You spent {_cashInsert.ToString("C2", CultureInfo.CreateSpecificCulture(this.Locale))}. You recieved {item.Name}. Your change is {_change.ToString("C2", CultureInfo.CreateSpecificCulture(this.Locale))}. Thank you for your purchase.");
			Record(item);
		}
		public void Record(ICandy item) {
			SoldItems.Add(item);
		}
		public void Load(ICandy item)
	{
			if (CurrentStock.Count >= Capacity) {
				Console.WriteLine("The vending machine is full. No more products can be added.");
			} else {
				CurrentStock.Add(item);
			}
		}
	}
}