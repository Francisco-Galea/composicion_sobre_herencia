using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComposicionSobreHerencia.Interfaces;

namespace ComposicionSobreHerencia.Models.EngineModels
{
    public class ElectricEngineModel : IEngine
    {
        
        public string move()
        {
            return "Electrico";
        }
    }
}
