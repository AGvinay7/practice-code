using System;

namespace VinayAG.SingleTon
{
    public sealed class SingletonDemo
    {
        public static int Counter = 0;
        public static SingletonDemo mySingleton = null;
        private static readonly object obj = new object();

        private SingletonDemo()
        {
            Counter++;
            Console.WriteLine("Counter Value:" + Counter);
        }

        public static SingletonDemo CreateInstance()
        {
            lock (obj)
            {
                if (mySingleton == null)
                {
                    mySingleton = new SingletonDemo();
                }
            }
            return mySingleton;
        }
        public void Display(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
