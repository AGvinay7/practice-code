using VinayAG.AdapterDesignPattern.Interface;
using System;
using System.Diagnostics;

namespace VinayAG.AdapterDesignPattern
{
    public class AdapterDpCaller
    {
        private readonly IAdapterDemo _adapaterDemo;      

        public AdapterDpCaller(IAdapterDemo adapterDemo)
        {
            _adapaterDemo = adapterDemo;
        }
        public void ExecuteAdapterPattern()
        {
            Trace.WriteLine("\n\n Calculate Area of circle with radius 7");

            int result = _adapaterDemo.CalculateArea(7, "circle");

            Trace.WriteLine("\n\n Area of circle is " + result +"\n\n");
        }
    }

}
