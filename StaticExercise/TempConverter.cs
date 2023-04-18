using System;
namespace StaticExercise
{
	public class TempConverter
	{
		public TempConverter()
		{
		}

		public static void FahrenheitToCelcius(double temp)
		{
			var newTemp = (temp - 32) * (5 / 9);
			Console.WriteLine(newTemp);
			
		}

		public static void CelciusToFahrenheit(double temp)
		{
			var newTemp = (temp * 1.8) + 32;
			Console.WriteLine(newTemp);
		}

	}
}

