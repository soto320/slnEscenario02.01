using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TermometroCelsius
    {
        public double GetTemperatureInCelsius()
        {
            // Simulate reading temperature in Celsius
            //25.0
            return new Random().Next(1,100);
        }
    }

}
