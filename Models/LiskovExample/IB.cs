﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.Models.LiskovExample
{
    interface IB : InterfaceA
    {       
        void B();
    }
}
