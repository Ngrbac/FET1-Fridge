using System;
namespace Lib
{
	public class FridgeItem: MeasuredItem
	{
		public DateTime TimeAdded;
		public long DaysRemainOnAdd;

		public FridgeItem(FoodItem item, decimal qty, DateTime timeAdded, long daysRemaining):base(item, qty)
		{
			TimeAdded = timeAdded;
			DaysRemainOnAdd = daysRemaining;
		}
        
        public long DaysRemaining()
        {
            var daysElapsed = DateTime.Now - TimeAdded;
            return DaysRemainOnAdd - daysElapsed.Days;
        }
	}
}

//(2 days ago)
//(12 days remaining then)
//10 days remaining now -- editable

//change to 15 days remaining
//edit db daysRemainingOnAdd = 15 + 2