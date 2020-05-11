using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace VinayAG.Facade
{
    public class Satellite
    {

        public void Install()
        {
            Thread.Sleep(5000);
            Trace.WriteLine("\n Installing Satellite...");
            Thread.Sleep(4000);
        }
    }
}
