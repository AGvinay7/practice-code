using VinayAG.SingleTon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.SingleTon.Impl
{
    public class SingletonProcessor : ISingletonProcessor
    {
        public void DemoSingleton()
        {
            Parallel.Invoke(
                   () => Task1(),
                   () => Task2(),
                   () => Task3()
               );
        }
        private static void Task3()
        {
            var obj3 = SingletonDemo.CreateInstance();
            obj3.Display("Dept Object");
        }

        private static void Task2()
        {
            var obj2 = SingletonDemo.CreateInstance();
            obj2.Display("Student Object");
        }

        private static void Task1()
        {
            var obj1 = SingletonDemo.CreateInstance();
            obj1.Display("Employee Object");
        }


    }
}
