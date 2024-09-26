using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class TermometroFahrenheit
    {
        public double GetTemperatureInFahrenheit()
        {
            // Simulate reading temperature in Fahrenheit
            //77.0
            return new Random().Next(1, 212);
        }
    }

}
