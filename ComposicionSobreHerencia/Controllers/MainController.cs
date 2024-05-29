using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComposicionSobreHerencia.Interfaces;
using ComposicionSobreHerencia.Models;
using ComposicionSobreHerencia.Models.DriverModels;
using ComposicionSobreHerencia.Models.EngineModels;

namespace ComposicionSobreHerencia.Controllers
{
    public class MainController
    {
        public static TransportModel CreateVehicle(string vehicle, string engine, string driver)
        {
            var transport = new TransportModel { Vehicle = vehicle };
            selectEngine(engine, transport);
            selectDriver(driver, transport);

            return transport;
        }

        public static void selectEngine(string engine, TransportModel transport)
        {
            switch (engine)
            {
                case "Combustion":
                    var combustion = new CombustionEngineModel();
                    transport.SetEngine(combustion);
                    break;

                case "Electrico":
                    var electric = new ElectricEngineModel();
                    transport.SetEngine(electric);
                    break;
            }

        }

        public static void selectDriver(string driver, TransportModel transport)
            {
                switch (driver)
                {
                    case "Humano":
                        var human = new HumanDriverModel();
                        transport.SetDriver(human);
                        break;

                    case "Robot":
                        var robot = new RobotDriverModel();
                        transport.SetDriver(robot);
                        break;
                }
            }
        }

    }