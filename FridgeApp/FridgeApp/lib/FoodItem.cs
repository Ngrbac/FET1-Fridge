using System;
namespace Lib
{
	public class FoodItem
	{
		public string Name;
		public int ExpirationDays;
		public Measurement Measure;

		public FoodItem()
		{
            Name = "Orange";
            ExpirationDays = 10;
            Measure = new Measurement("Pieces");
		}

        public override string ToString()
        {
            return Name;
        }
    }
}
