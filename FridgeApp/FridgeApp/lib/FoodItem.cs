﻿using System;
namespace Lib
{
	public class FoodItem
	{
        public int ID;
		public string Name;
		public int ExpirationDays;
		public Measurement Measure;
       
       
        public FoodItem(string name, int expiresIn, Measurement measure)
        {
            Name = name;
            ExpirationDays = expiresIn;
            Measure = measure;
        }

        public override string ToString()
        {
            return Name;
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}
