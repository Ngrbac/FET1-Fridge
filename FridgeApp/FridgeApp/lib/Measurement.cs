﻿using System;
namespace Lib
{
	public class Measurement
	{
		public string Name;

		public Measurement(string name)
		{
            Name = name;
		}

        public override string ToString()
        {
            return Name;
        }
    }
}