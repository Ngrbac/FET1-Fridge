using System;
using System.Collections.Generic;

namespace Lib
{
	public class Refrigerator
	{
		public List<FridgeItem> Items = new List<FridgeItem>();

		public Refrigerator()
		{
			
		}

		public void AddItem(FridgeItem item)
		{
            var food = item;
			Items.Add(food);
		}
        //public void AddItem(FoodItem item, decimal qty)
        //{
        //    var food = new FridgeItem(item, qty, DateTime.Now, item.ExpirationDays);
        //    Items.Add(food);
        //}

        public void AddItem(FoodItem item, decimal qty, int daysRemaining)
		{
			var food = new FridgeItem(item, qty, DateTime.Now, daysRemaining);
			Items.Add(food);
		}

	}
}
