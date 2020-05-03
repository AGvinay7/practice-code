

using sample_Web_API.AdapterDesignPattern.Interface;
using System;

namespace sample_Web_API.AdapterDesignPattern.Impl
{
    public class AdapterClass : IAdapterDemo
    {
        readonly Adaptee Circle = new Adaptee();
        public int CalculateArea(int Property, string GeoObject)
        {
            int area = 0;
            if(GeoObject.Equals("circle"))
            {                
                area = (int)Circle.AreaOfaCircle(Property);
            }
            return area;
        }
    }
}
