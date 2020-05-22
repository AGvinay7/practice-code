using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinayAG.Proxy.Interface;

namespace VinayAG.Proxy.Impl
{
    public class Proxy : ISubject
    {
        public readonly ISubject _RealSubject;
        public Proxy(ISubject RealSubject)
        {
            _RealSubject = RealSubject;
        }
        public IEnumerable<string> GetUserNames()
        {
            var returnData = new List<string>();
            returnData = GetCachedData();

            if (returnData.Count != 0)
            {
                return returnData;
            }

            else
            {
                returnData = _RealSubject.GetUserNames().ToList();
                CacheData(returnData);
            }
            return returnData;
        }

        private void CacheData(List<string> InputData)
        {
            // cache data 
        }

        private List<string> GetCachedData()
        {
            // return cached data if any
            return new List<string>();
        }
    }
}
