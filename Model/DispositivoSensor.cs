using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DispositivoSensor
    {
        public int Id { get; set; }
        public string BloqueNombre { get; set; }

        public List<DispositivoSensorTemperatura> Sensors;

        public DispositivoSensor()
        {
            this.Sensors = new List<DispositivoSensorTemperatura>();
        }
        public DispositivoSensor(int id, string bloqueNombre)
        {
            this.Id = id;
            this.BloqueNombre = bloqueNombre;
            this.Sensors = new List<DispositivoSensorTemperatura>();
        }

        // Add a temperature sensor to the block
        public void AddSensor(DispositivoSensorTemperatura sensor)
        {
            Sensors.Add(sensor);
        }

        // Get temperature from all sensors in the block
        public List<double> GetTemperatures()
        {
            return Sensors.Select(sensor => sensor.ObtenerTemperatura()).ToList();
        }

        // Retrieve all sensors
        public List<DispositivoSensorTemperatura> GetAllSensors()
        {
            return Sensors;
        }
    }
}
