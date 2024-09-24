using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Bloque
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        private List<Lecturas> Lecturas { get; set; }
        public Bloque()
        {
            this.Lecturas = new List<Lecturas>();
        }

        public Bloque(int id, string blockName)
        {
            this.Id = id;
            this.Nombre = blockName;
            this.Lecturas = new List<Lecturas>();
        }

        // Add a temperature sensor to the block
        public void AddSensor(string descripcion, double temperatura)
        {
            Lecturas.Add(new Lecturas() { Descripcion = descripcion, Temperatura = temperatura });
        }

        // Get temperature from all sensors in the block
        public List<double> GetTemperatures()
        {
            return Lecturas.Select(sensor => sensor.Temperatura).ToList();
        }
    }
}
