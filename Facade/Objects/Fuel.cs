using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VinayAG.Facade.Interface;

namespace VinayAG.Facade
{
    public class Fuel :IFuel
    {
        public void FillJetFuel()
        {
            Thread.Sleep(8000);
            Trace.WriteLine("\n Filling Jet Fuel...");
            Thread.Sleep(2000);
        }
    }
}
