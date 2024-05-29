using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComposicionSobreHerencia.Interfaces;
using ComposicionSobreHerencia.Models.EngineModels;

namespace ComposicionSobreHerencia.Models
{
    public class TransportModel
    {
        private string vehicle;
        private IDriver driver;
        private IEngine engine;

        public TransportModel()
        {

        }
        public void SetEngine(IEngine engine)
        {
            this.engine = engine;
        }
        public void SetDriver(IDriver driver)
        {
            this.driver = driver;
        }
        public string Vehicle
        {
            get { return vehicle; }
            set { vehicle = value; }
        }
        public string showInfo()
        {
            string showDriver = driver.navigate();
            string showEngine = engine.move();
            return $"El vehiculo {Vehicle}, viajara con un piloto {showDriver}, y su motor es de tipo: {showEngine}";
        }
        
    }
}
