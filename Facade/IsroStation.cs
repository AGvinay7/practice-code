using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinayAG.Facade.Interface;

namespace VinayAG.Facade
{
    public class IsroStation // Client who is going to interact with Facade 
    {
        private readonly IRocket _rocket;
       public IsroStation(IRocket rocket)
        {
            _rocket = rocket;
        }
        public void Start()
        {
            // Rocket class is a facade which handles inner mechanism
            _rocket.Launch();
        }
    }
}
