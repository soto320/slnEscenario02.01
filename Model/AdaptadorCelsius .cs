using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AdaptadorCelsius : DispositivoSensorTemperatura
    {
        private readonly TermometroCelsius _termometroCelsius;

        public AdaptadorCelsius(TermometroCelsius termometro)
        {
            _termometroCelsius = termometro;
        }

        public double ObtenerTemperatura()
        {
            return _termometroCelsius.GetTemperatureInCelsius();
        }
    }
}
