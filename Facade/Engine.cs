using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace VinayAG.Facade
{
    public class Engine
    {
        public void AssembleEngine()
        {
            Thread.Sleep(4000);
            Trace.WriteLine("\n Assembling Rocket ENgine...");
            Thread.Sleep(3000);
        }
    }

}
