using System;
namespace Lib
{
	public class FridgeItem: MeasuredItem
	{
		public DateTime TimeAdded;
		public int DaysRemainOnAdd;

		public FridgeItem(FoodItem item, decimal qty, Measurement measure, DateTime timeAdded, int daysRemaining):base(item, qty, measure)
		{
			TimeAdded = timeAdded;
			DaysRemainOnAdd = daysRemaining;
		}

		public FridgeItem(FoodItem item, decimal qty, DateTime timeAdded, int daysRemaining):base(item, qty)
		{
			TimeAdded = timeAdded;
			DaysRemainOnAdd = daysRemaining;	
		}

        public int DaysRemaining()
        {
            var daysElapsed = DateTime.Now - TimeAdded;
            return DaysRemainOnAdd - daysElapsed.Days;
        }
	}
}
