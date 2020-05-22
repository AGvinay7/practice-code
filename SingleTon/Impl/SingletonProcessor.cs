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
            var Department = SingletonDemo.CreateInstance();
            Department.Display("Dept Object consumes singleton instance");
        }

        private static void Task2()
        {
            var Student = SingletonDemo.CreateInstance();
            Student.Display("Student Object consumes singleton instance");
        }

        private static void Task1()
        {
            var Faculty = SingletonDemo.CreateInstance();
            Faculty.Display("Employee Object consumes singleton instance");
        }


    }
}
