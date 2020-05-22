using System;
using System.Diagnostics;
using System.Threading;


namespace VinayAG.SingleTon
{
    public sealed class SingletonDemo 
    {
        public static int Counter = 0;
        public static SingletonDemo mySingleton = null; 
        

        private static readonly object oneAtaTime = new object();

        private SingletonDemo()
        {
            Counter++;
            Trace.WriteLine("\n\n Counter Value:" + Counter);
        }

        public static SingletonDemo CreateInstance()
        {
            if (mySingleton == null)
            {
                lock (oneAtaTime)
                {
                    if (mySingleton == null)
                    {
                        mySingleton = new SingletonDemo();
                    }
                }
            }
            return mySingleton;
        }
        public void Display(string msg)
        {
            Thread.Sleep(2000);
            Trace.WriteLine("\n\n" + msg);
            //Trace.WriteLine("called ")
        }

        
    }
}
