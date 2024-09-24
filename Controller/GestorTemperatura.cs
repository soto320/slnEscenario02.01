using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    
    public class GestorTemperatura
    {
        private Model.DispositivoSensorTemperatura DispositivoSensorTemperatura;
        private List<Model.Bloque> Bloques= new List<Model.Bloque>();
        // Method to set the sensor (Celsius or Fahrenheit)
        public void AgregarDispositivo(Model.DispositivoSensorTemperatura dispositivoSensorTemperatura)
        {
            this.DispositivoSensorTemperatura = dispositivoSensorTemperatura;
        }
        public double ObtenerTemperatura()
        {
            if (DispositivoSensorTemperatura != null)
                return DispositivoSensorTemperatura.ObtenerTemperatura();
            throw new InvalidOperationException("No sensor is available.");

        }
        public int NextBloque() {
            return this.Bloques==null? this.Bloques.Max(x=>x.Id)+ 1:0;        
        }
        public void AddBlock( Bloque bloque)
        {
           this.Bloques.Add(bloque);
        }
        public Model.Bloque GetTemperaturesFromBlock(int item)
        {
            return this.Bloques.Find(x => x.Id == item);
        }

    }
}
