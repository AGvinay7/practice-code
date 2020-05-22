using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinayAG.Proxy.Interface;

namespace VinayAG.Proxy.Impl
{
    public class RealSubject : ISubject
    {
        public IEnumerable<string> GetUserNames()
        {
            return new List<string>() { 
                "User1" ,
                "User2" ,
            };
        }
    }
}
