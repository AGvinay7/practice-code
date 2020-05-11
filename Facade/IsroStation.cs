using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.Facade
{
    public class IsroStation
    {
        public void start()
        {
            Rocket rocket = new Rocket();
            rocket.Launch();
        }
    }
}
