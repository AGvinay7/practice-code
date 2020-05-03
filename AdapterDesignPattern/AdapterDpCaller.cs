using VinayAG.AdapterDesignPattern.Interface;
using System;

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
            int result = _adapaterDemo.CalculateArea(57, "circle");
            Console.WriteLine("Area of circle is" + result);
        }
    }

}
