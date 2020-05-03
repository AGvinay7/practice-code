

using VinayAG.AdapterDesignPattern.Interface;
using System;

namespace VinayAG.AdapterDesignPattern.Impl
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
