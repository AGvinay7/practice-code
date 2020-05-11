using System;
using System.Diagnostics;

namespace VinayAG.Decorator
{
    public class DecoratorPat : ICircle
    {
        public bool DrawCircle()
        {
            bool flag = false;
            try
            {
                Trace.WriteLine("Drawing circle");
                Circle circle = new Circle();
                circle.CreateCircle();
                Trace.WriteLine("Done");
                flag = true;
            }
            catch(Exception e)
            {
                Trace.WriteLine("Exception caught" + e);
            }
            return flag;
        }
    }
}
