using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AdaptadorFahrenheit : DispositivoSensorTemperatura
    {
        private readonly TermometroFahrenheit _termometroFahrenheit;

        public AdaptadorFahrenheit(TermometroFahrenheit termometro)
        {
            _termometroFahrenheit = termometro;
        }

        public double ObtenerTemperatura()
        {
            //return _termometroFahrenheit.GetTemperatureInFahrenheit();
            return (_termometroFahrenheit.GetTemperatureInFahrenheit() - 32) * 5 / 9;
        }
       /* public double ObtenerTemperaturaCelcius()
        {
            return _termometroFahrenheit.GetTemperatureInFahrenheit();
        }*/
    }
}
