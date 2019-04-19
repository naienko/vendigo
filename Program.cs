using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace vendigo
{
	class Program
	{
		static void Main()
		{
			List<IVending> allMachines = new List<IVending>();

			// United States machines
			SodaVendingMachine sodaUS = new SodaVendingMachine()
			{
				Type = "Soda",
				Locale = "en-US",
				Capacity = 15
			};
			CandyVendingMachine candyUS = new CandyVendingMachine()
			{
				Type = "Candy",
				Locale = "en-US",
				Capacity = 20
			};
			ClothingVendingMachine clothingUS = new ClothingVendingMachine()
			{
				Type = "Clothing",
				Locale = "en-US",
				Capacity = 10
			};
			CoffeeVendingMachine coffeeUS = new CoffeeVendingMachine()
			{
				Type = "Coffee",
				Locale = "en-US",
				Capacity = 15
			};
			EnergyVendingMachine energyUS = new EnergyVendingMachine()
			{
				Type = "Energy Drink",
				Locale = "en-US",
				Capacity = 3
			};
			MealVendingMachine mealUS = new MealVendingMachine()
			{
				Type = "Ready Meal",
				Locale = "en-US",
				Capacity = 12
			};
			SundriesVendingMachine sundriesUS = new SundriesVendingMachine()
			{
				Type = "Sundries",
				Locale = "en-US",
				Capacity = 30
			};
			allMachines.Add(sodaUS);
			allMachines.Add(candyUS);
			// allMachines.Add(clothingUS);
			// allMachines.Add(coffeeUS);
			allMachines.Add(energyUS);
			// allMachines.Add(mealUS);
			// allMachines.Add(sundriesUS);

			// Spain machines
			SodaVendingMachine sodaES = new SodaVendingMachine()
			{
				Type = "Soda",
				Locale = "es-ES",
				Capacity = 15
			};
			CandyVendingMachine candyES = new CandyVendingMachine()
			{
				Type = "Candy",
				Locale = "es-ES",
				Capacity = 20
			};
			ClothingVendingMachine clothingES = new ClothingVendingMachine()
			{
				Type = "Clothing",
				Locale = "es-ES",
				Capacity = 10
			};
			CoffeeVendingMachine coffeeES = new CoffeeVendingMachine()
			{
				Type = "Coffee",
				Locale = "es-ES",
				Capacity = 15
			};
			EnergyVendingMachine energyES = new EnergyVendingMachine()
			{
				Type = "Energy Drink",
				Locale = "es-ES",
				Capacity = 15
			};
			MealVendingMachine mealES = new MealVendingMachine()
			{
				Type = "Ready Meal",
				Locale = "es-ES",
				Capacity = 12
			};
			SundriesVendingMachine sundriesES = new SundriesVendingMachine()
			{
				Type = "Sundries",
				Locale = "es-ES",
				Capacity = 30
			};
			// allMachines.Add(sodaES);
			allMachines.Add(candyES);
			// allMachines.Add(clothingES);
			// allMachines.Add(coffeeES);
			// allMachines.Add(energyES);
			// allMachines.Add(mealES);
			// allMachines.Add(sundriesES);

			// Japan machines
			SodaVendingMachine sodaJP = new SodaVendingMachine()
			{
				Type = "Soda",
				Locale = "ja-JP",
				Capacity = 15
			};
			CandyVendingMachine candyJP = new CandyVendingMachine()
			{
				Type = "Candy",
				Locale = "ja-JP",
				Capacity = 20
			};
			ClothingVendingMachine clothingJP = new ClothingVendingMachine()
			{
				Type = "Clothing",
				Locale = "ja-JP",
				Capacity = 10
			};
			CoffeeVendingMachine coffeeJP = new CoffeeVendingMachine()
			{
				Type = "Coffee",
				Locale = "ja-JP",
				Capacity = 15
			};
			EnergyVendingMachine energyJP = new EnergyVendingMachine()
			{
				Type = "Energy Drink",
				Locale = "ja-JP",
				Capacity = 15
			};
			MealVendingMachine mealJP = new MealVendingMachine()
			{
				Type = "Ready Meal",
				Locale = "ja-JP",
				Capacity = 12
			};
			SundriesVendingMachine sundriesJP = new SundriesVendingMachine()
			{
				Type = "Sundries",
				Locale = "ja-JP",
				Capacity = 30
			};
			// allMachines.Add(sodaJP);
			// allMachines.Add(candyJP);
			// allMachines.Add(clothingJP);
			// allMachines.Add(coffeeJP);
			// allMachines.Add(energyJP);
			// allMachines.Add(mealJP);
			// allMachines.Add(sundriesJP);

			// United States items
			CocaCola cocacola = new CocaCola()
			{
				Name = "Coca-Cola",
				Price = 1.25,
				Recyclable = true,
				Ingredients = new List<string>() { "sugar" }
			};
			Sprite sprite = new Sprite()
			{
				Name = "Sprite",
				Price = 1.25,
				Recyclable = true,
				Ingredients = new List<string>() { "sugar" }
			};
			sodaUS.Load(cocacola);
			sodaUS.Load(sprite);
			Nos nos = new Nos()
			{
				Name = "NOS",
				Price = 2.5,
				Recyclable = true,
				Ingredients = new List<string>() { "caffeine" }
			};
			RedBull redbull = new RedBull()
			{
				Name = "Red Bull",
				Price = 2,
				Recyclable = true,
				Ingredients = new List<string>() { "taurine" }
			};
			FiveHour fivehourpeach = new FiveHour()
			{
				Name = "Five Hour Energy Drink Peach Flavour",
				Price = .50,
				Recyclable = false,
				Ingredients = new List<string>() { "peach flavour" }
			};
			FiveHour fivehourfruit = new FiveHour()
			{
				Name = "Five Hour Energy Drink Fruit Punch Flavour",
				Price = .50,
				Recyclable = false,
				Ingredients = new List<string>() { "fruit punch flavour" }
			};
			energyUS.Load(nos);
			energyUS.Load(redbull);
			energyUS.Load(fivehourpeach);
			energyUS.Load(fivehourfruit);

            // Spain items
            PeachHeart kantan = new PeachHeart() {
                Name = "Kantan Flirty Peach Hearts",
                Price = .75,
                Spiciness = 0,
                Organic = false
            };
            candyES.Load(kantan);
			///////

			Console.Write($@"1. United States
2. Spain
3. Japan
4. Display reports
5. Exit

Choose a country
> ");

			int countryChoice = int.Parse(Console.ReadLine());
			if (countryChoice == 1)
			{
				Console.WriteLine("US vending");
				List<IVending> usMachines = (
					from machine in allMachines
					where machine.Locale == "en-US"
					select machine
				).ToList();
				foreach (IVending machine in usMachines)
				{
					Console.WriteLine($@"{usMachines.IndexOf(machine) + 1}. {machine.Type}");
				}
				Console.Write($@"What kind of product would you like to purchase?
> ");
				int typeChoice = int.Parse(Console.ReadLine());
                if (typeChoice > usMachines.Count) {
                    Console.WriteLine("Invalid entry.");
                    return;
                } 
				string selectedType = usMachines[typeChoice - 1].Type;

				if (selectedType == "Soda")
				{
					SodaVendingMachine selectedOption = sodaUS;
					if (selectedOption.CurrentStock.Count > 0)
					{
						foreach (ISoda item in selectedOption.CurrentStock)
						{
							Console.WriteLine($"{selectedOption.CurrentStock.IndexOf(item) + 1}. {item.Name} {item.Price.ToString("C2", CultureInfo.CreateSpecificCulture(selectedOption.Locale))}");
						}
						Console.Write($@"Which {selectedOption.Type} would you like to purchase?
> ");
						int itemChoice = int.Parse(Console.ReadLine());
						selectedOption.Purchase(selectedOption.CurrentStock[itemChoice - 1]);
					}
					else
					{
						Console.WriteLine("That machine has no stock currently.");
					}
				}
				else if (selectedType == "Candy")
				{
					CandyVendingMachine selectedOption = candyUS;
					if (selectedOption.CurrentStock.Count > 0)
					{
						foreach (ICandy item in selectedOption.CurrentStock)
						{
							Console.WriteLine($"{selectedOption.CurrentStock.IndexOf(item) + 1}. {item.Name} {item.Price.ToString("C2", CultureInfo.CreateSpecificCulture(selectedOption.Locale))}");
						}
						Console.Write($@"Which {selectedOption.Type} would you like to purchase?
> ");
						int itemChoice = int.Parse(Console.ReadLine());
						selectedOption.Purchase(selectedOption.CurrentStock[itemChoice - 1]);
					}
					else
					{
						Console.WriteLine("That machine has no stock currently.");
					}
				}
                else if (selectedType == "Energy Drink")
				{
					EnergyVendingMachine selectedOption = energyUS;
					if (selectedOption.CurrentStock.Count > 0)
					{
						foreach (IEnergyDrink item in selectedOption.CurrentStock)
						{
							Console.WriteLine($"{selectedOption.CurrentStock.IndexOf(item) + 1}. {item.Name} {item.Price.ToString("C2", CultureInfo.CreateSpecificCulture(selectedOption.Locale))}");
						}
						Console.Write($@"Which {selectedOption.Type} would you like to purchase?
> ");
						int itemChoice = int.Parse(Console.ReadLine());
						selectedOption.Purchase(selectedOption.CurrentStock[itemChoice - 1]);
					}
					else
					{
						Console.WriteLine("That machine has no stock currently.");
					}
				}
                else
                {
                    Console.WriteLine("There are no machines of that type.");
                }
			}
            else if (countryChoice == 2) 
            {
				Console.WriteLine("Spain vending");
				List<IVending> esMachines = (
					from machine in allMachines
					where machine.Locale == "es-ES"
					select machine
				).ToList();
				foreach (IVending machine in esMachines)
				{
					Console.WriteLine($@"{esMachines.IndexOf(machine) + 1}. {machine.Type}");
				}
				Console.Write($@"What kind of product would you like to purchase?
> ");
				int typeChoice = int.Parse(Console.ReadLine());
                if (typeChoice > esMachines.Count) {
                    Console.WriteLine("Invalid entry.");
                    return;
                } 
				string selectedType = esMachines[typeChoice - 1].Type;

				if (selectedType == "Soda")
				{
					SodaVendingMachine selectedOption = sodaES;
					if (selectedOption.CurrentStock.Count > 0)
					{
						foreach (ISoda item in selectedOption.CurrentStock)
						{
							Console.WriteLine($"{selectedOption.CurrentStock.IndexOf(item) + 1}. {item.Name} {item.Price.ToString("C2", CultureInfo.CreateSpecificCulture(selectedOption.Locale))}");
						}
						Console.Write($@"Which {selectedOption.Type} would you like to purchase?
> ");
						int itemChoice = int.Parse(Console.ReadLine());
						selectedOption.Purchase(selectedOption.CurrentStock[itemChoice - 1]);
					}
					else
					{
						Console.WriteLine("That machine has no stock currently.");
					}
				}
				else if (selectedType == "Candy")
				{
					CandyVendingMachine selectedOption = candyES;
					if (selectedOption.CurrentStock.Count > 0)
					{
						foreach (ICandy item in selectedOption.CurrentStock)
						{
							Console.WriteLine($"{selectedOption.CurrentStock.IndexOf(item) + 1}. {item.Name} {item.Price.ToString("C2", CultureInfo.CreateSpecificCulture(selectedOption.Locale))}");
						}
						Console.Write($@"Which {selectedOption.Type} would you like to purchase?
> ");
						int itemChoice = int.Parse(Console.ReadLine());
						selectedOption.Purchase(selectedOption.CurrentStock[itemChoice - 1]);
					}
					else
					{
						Console.WriteLine("That machine has no stock currently.");
					}
				}
            }
            else if (countryChoice == 4)
            {
                Console.WriteLine("REPORTS");
                Console.WriteLine("Top 10 items sold worldwide by count.");
                // linq through all IVending group by SoldItems?
// Top 10 item types sold worldwide by count.
// Top 10 items sold worldwide by revenue.
// Top 10 items sold by revenue per country.
            }
            else if (countryChoice == 5)
            {
                Console.WriteLine("END");
            }
			else
			{
				Console.WriteLine("You picked the wrong number.");
			}
		}
	}
}
