using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace VinayAG.Facade
{
    public class Rocket
    {
        public  void Launch()
        {
            Console.WriteLine("\n=========== STARTED ============\n");
            Trace.WriteLine("\n=========== STARTED ============\n");
            Engine engine = new Engine();
            engine.AssembleEngine();
            Satellite satellite = new Satellite();
            satellite.Install();
            Propellents propellents = new Propellents();
            propellents.AddPropellents();
            Fuel fuel = new Fuel();
            fuel.FillJetFuel();
            Trace.WriteLine("\n=========== Launching... ============\n");
            for (int i = 10; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Trace.WriteLine("\n" + i.ToString() + " Seconds ");
            }
            Thread.Sleep(5000);
            Trace.WriteLine("\n=========== Bhoooooom !!!! ============\n");

        }

    }
}
