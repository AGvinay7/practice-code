using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.Decorator
{
    public class DecoratorClient
    {
        private readonly ICircle _circle;
        public DecoratorClient(ICircle circle)
        {
            _circle = circle;
        }

        public void DemoDecorator()
        {
            _circle.DrawCircle();

        }
    }
}
