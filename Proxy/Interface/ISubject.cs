using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.Proxy.Interface
{
    public interface ISubject
    {
        IEnumerable<string> GetUserNames(); 
    }
}
