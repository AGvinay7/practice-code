using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_Web_API.AdapterDesignPattern.Interface
{
    public interface IAdapterDemo
    {
        int CalculateArea(int Property, string GeoObject);
    }
}
