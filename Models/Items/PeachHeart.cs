using System;

namespace vendigo
{
	public class PeachHeart : Item, ICandy, ISpain
	{
		public int Spiciness { get; set; }
		public bool Organic { get; set; }
	}
}