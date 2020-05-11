using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.Decorator
{
    public class Client
    {
        private readonly ICircle _circle;
        public Client(ICircle circle)
        {
            _circle = circle;
        }

        public void DemoDecorator()
        {
            _circle.DrawCircle();
        }
    }
}
