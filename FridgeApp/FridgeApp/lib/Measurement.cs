using System;
namespace Lib
{
	public class Measurement
	{
		public string Name;
		public Measurement MainMeasurement;
		public decimal CoefToMain;

		public Measurement(string name)
		{
            Name = name;
		}
	}
}
