﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using VinayAG.Facade.Interface;

namespace VinayAG.Facade
{
    public class Propellents : IPropellents
    {
        public void AddPropellents()
        {
            Thread.Sleep(5000);

            Trace.WriteLine("\n Adding 4 Propellents...");
            Thread.Sleep(3000);
        }
    }
}
