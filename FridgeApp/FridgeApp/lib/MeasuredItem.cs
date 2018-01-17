using System;
namespace Lib
{
	public class MeasuredItem
	{
		public FoodItem FoodItem;
		public Measurement Measure;
		public decimal Qty;

		public MeasuredItem(FoodItem item, decimal qty, Measurement measure)
		{
			FoodItem = item;
			Qty = qty;
			Measure = measure;
		}

		public MeasuredItem(FoodItem item, decimal qty)
		{
			FoodItem = item;
			Qty = qty;
			Measure = item.Measure;
		}
	}
}
