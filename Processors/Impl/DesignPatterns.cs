using VinayAG.AbstractFactory;
using VinayAG.AdapterDesignPattern;
using VinayAG.AdapterDesignPattern.Interface;
using VinayAG.FactoryDesignPattern;
using VinayAG.Processors.Interface;
using VinayAG.SingleTon;
using VinayAG.SingleTon.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VinayAG.Facade;

namespace VinayAG.Processors.Impl
{
    public class DesignPatterns : IDesignPatterns
    {
        public readonly ISingletonProcessor _singletonProcessor;
        private readonly IAdapterDemo _adapterdemo;

        public DesignPatterns(ISingletonProcessor singletonProcessor, IAdapterDemo adapterDemo)
        {
            _singletonProcessor = singletonProcessor;
            _adapterdemo = adapterDemo;
        }
        public void DemoDesignPatterns()
        {
            FactoryDesignPattern();

            AbstractFactoryDesignPattern();

            _singletonProcessor.DemoSingleton();

            AdapterDesignPattern();
           
        }

        private void AdapterDesignPattern()
        {
            AdapterDpCaller Adp = new AdapterDpCaller(_adapterdemo);
            Adp.ExecuteAdapterPattern();
        }

        private void AbstractFactoryDesignPattern()
        {
            // creat objects using Abstract Factory Design Pattern
            var createTiger = new AnimalMaker();
            createTiger.CreateAnimal();
        }

        private void FactoryDesignPattern()
        {
            // creat objects using Factory Design Pattern
            var callerObj = new Client();
            callerObj.GetMovies();
        }     

      
    }
}
