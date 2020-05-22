using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using VinayAG.Facade.Interface;

namespace VinayAG.Facade
{
    public class Engine : IEngine
    {
        public void AssembleEngine()
        {
            Thread.Sleep(4000);
            Trace.WriteLine("\n Assembling Rocket ENgine...");
            Thread.Sleep(3000);
        }
    }

}
