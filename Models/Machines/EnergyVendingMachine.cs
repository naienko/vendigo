using System;
using System.Collections.Generic;
using System.Globalization;

namespace vendigo
{
	public class EnergyVendingMachine : VendingMachine, ITypedMachine<IEnergyDrink>
	{
		public List<IEnergyDrink> CurrentStock { get; set; } = new List<IEnergyDrink>();
		public List<IEnergyDrink> SoldItems { get; set; } = new List<IEnergyDrink>();
		public void Purchase(IEnergyDrink item) {
			Console.Write($@"The {item.Name} costs {item.Price.ToString("C2", CultureInfo.CreateSpecificCulture(this.Locale))}. What denomination will you be using?
> ");
			double _cashInsert = double.Parse(Console.ReadLine());
			double _change = _cashInsert - item.Price;
			Console.WriteLine($"You spent {_cashInsert.ToString("C2", CultureInfo.CreateSpecificCulture(this.Locale))}. You recieved {item.Name}. Your change is {_change.ToString("C2", CultureInfo.CreateSpecificCulture(this.Locale))}. Thank you for your purchase.");
			Record(item);
		}
		public void Record(IEnergyDrink item) {
			SoldItems.Add(item);
		}
		public void Load(IEnergyDrink item)
		{
			if (CurrentStock.Count >= Capacity) {
				Console.WriteLine($"The vending machine is full. The {item.Name} cannot be added.");
			} else {
				CurrentStock.Add(item);
			}
		}
	}
}