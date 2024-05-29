using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComposicionSobreHerencia.Interfaces;

namespace ComposicionSobreHerencia.Models.DriverModels
{
    public class RobotDriverModel : IDriver
    {
        public string navigate()
        {
            return "Robot";
        }
    }
}
