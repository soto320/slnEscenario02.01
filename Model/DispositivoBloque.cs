using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DispositivoBloque
    {
        public string Descripcion { get; set; }
        public DispositivoSensorTemperatura Sensor { get; set; }
    }
}
