using VinayAG.AbstractFactory;
using VinayAG.AdapterDesignPattern;
using VinayAG.AdapterDesignPattern.Interface;
using VinayAG.FactoryDesignPattern;
using VinayAG.Processors.Interface;
using VinayAG.SingleTon;
using VinayAG.SingleTon.Interface;
using VinayAG.Facade;
using VinayAG.Decorator;
using System;
using VinayAG.Facade.Interface;

namespace VinayAG.Processors.Impl
{
    public class DesignPatterns : IDesignPatterns
    {
        public readonly ISingletonProcessor _singletonProcessor;
        private readonly IAdapterDemo _adapterdemo;
        private readonly ICircle _circle;
        private readonly IRocket _rocket;

        public DesignPatterns(ISingletonProcessor singletonProcessor, IAdapterDemo adapterDemo, ICircle circle, IRocket rocket)
        {
            _singletonProcessor = singletonProcessor;
            _adapterdemo = adapterDemo;
            _circle = circle;
            _rocket = rocket;
        }
        public void DemoDesignPatterns()
        {
            //FactoryDesignPattern();

            //AbstractFactoryDesignPattern();

            //_singletonProcessor.DemoSingleton();

            //AdapterDesignPattern();

            FacadeDemo();

            //DecoratorMethod();
        }       

        private void DecoratorMethod()
        {
            new DecoratorClient(_circle).DemoDecorator();
        }

        private void FacadeDemo()
        {
            var clientCode = new IsroStation(_rocket); // Client calling facade
            clientCode.Start();
        }

        private void AdapterDesignPattern()
        {
            AdapterDpCaller Adp = new AdapterDpCaller(_adapterdemo);
            Adp.ExecuteAdapterPattern();
        }

        private void AbstractFactoryDesignPattern()
        {
            // create objects using Abstract Factory Design Pattern
            var createTiger = new AnimalMaker();
            createTiger.CreateAnimal();
        }

        private void FactoryDesignPattern()
        {
            // create objects using Factory Design Pattern
            var callerObj = new Client();
            callerObj.GetMovies();
        }

    }
}
