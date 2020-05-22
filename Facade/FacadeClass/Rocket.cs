using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using VinayAG.Facade.Interface;

namespace VinayAG.Facade
{
    public class Rocket : IRocket
    {
        private readonly IEngine _engine;
        private readonly IFuel _fuel;
        private readonly IPropellents _propellents;
        private readonly ISatellite _satellite;

        public Rocket(IEngine engine, IFuel fuel, IPropellents propellents, ISatellite satellite)
        {
            _engine = engine;
            _fuel = fuel;
            _propellents = propellents;
            _satellite = satellite;
        }
        public void Launch()
        {
            Trace.WriteLine("\n=========== STARTED ============\n");


            // Obects formation and various operations using them

            _engine.AssembleEngine();

            _satellite.Install();

            _propellents.AddPropellents();

            _fuel.FillJetFuel();

            Trace.WriteLine("\n=========== Launching... ============\n");

            Ignite();

        }



        private static void Ignite()
        {
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Trace.WriteLine("\n" + i.ToString() + " Seconds ");
            }
            Thread.Sleep(2000);

            Trace.WriteLine("\n=========== Bhoooooom !!!! ============\n");
        }
    }
}
