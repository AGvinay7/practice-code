using System;
using System.Diagnostics;
using System.Threading;

namespace VinayAG.Decorator
{
    public class DecoratorPat : ICircle
    {
        public bool DrawCircle()
        {
            bool flag = false;
            try
            {
                PrintMsg("Decorating the Circle class");
                PrintMsg("Drawing Circle...");
                Circle circle = new Circle();

                circle.CreateCircle();

                PrintMsg("Done");
                flag = true;
            }
            catch (Exception e)
            {                
                PrintMsg("Exception caught" + e);
            }
            return flag;
        }

        private static void PrintMsg(string msg)
        {
            Thread.Sleep(2000);
            Trace.WriteLine("\n\n"+ msg);
        }
    }
}
