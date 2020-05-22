using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinayAG.Models.OCP.classes;

namespace VinayAG.Models.OCP
{
    public class OCP
    {

        public bool DecideCourse()
        {
            BE Course = new BE();
            var Duration = Course.GetDuration();
            var Fee = Course.GetFee();

            return (Duration < 5 && Fee <= 3000000);
            
        }

    }
}
