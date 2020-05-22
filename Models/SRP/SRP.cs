using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.Models.SRP
{
    public class SRP
    {
        public string AssetId;
        public double AssetCost;
        public string AssetName;
        public string AssetLocation;
        public string PointId;
        public double PointCost;
        public string PointName;
        public string PointLocation;
        public object logger;
        public string driver;
        public object driverA;
        public string driverB;

        public void GetAssetDetails()
        {
            //get asset details 
        }
        public void GetPointDetails()
        {
            //implementation of point related operations
        }
        public void GetLocationDetails()
        {
            //implementation of location details 
        }
        public void ConnectToDB()
        {
            // connection to DB
        }

        public void LogMessage(string msg)
        {
            // log message
        }

    }
}
