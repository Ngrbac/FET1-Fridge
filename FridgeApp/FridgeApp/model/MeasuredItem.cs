using System;
namespace Lib
{
	public class MeasuredItem
	{
        public long ID;
		public FoodItem FoodItem;
		public decimal Qty;

        public MeasuredItem(FoodItem item, decimal qty)
		{
            ID = -1;
			FoodItem = item;
			Qty = qty;
		}

        public MeasuredItem(long id, FoodItem item, decimal qty)
        {
            ID = id;
            FoodItem = item;
            Qty = qty;
        }
    }
}



