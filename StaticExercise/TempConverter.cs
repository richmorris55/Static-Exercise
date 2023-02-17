using System;
namespace StaticExercise
{
	public static class TempConverter
	{

		public static double FarenheitToCelcius(double farenheit)
		{

			return (farenheit - 32) * .5556;

		}


        public static double CelciusToFarenheit(double farenheit2)
        {

            return farenheit2 * 1.8 + 32;

        }


    }

    





}

