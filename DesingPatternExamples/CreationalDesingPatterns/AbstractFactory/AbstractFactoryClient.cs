using DesingPatternExamples.AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.CreationalDesingPatterns.AbstractFactory
{
    public class AbstractFactoryClient
    {
        public void Demo() 
        {
            GetMakeDataFromFactory(new SamsungFactory());

            GetMakeDataFromFactory(new LGFactory());

            GetMakeDataFromFactory(new SonyFactory());
            Console.WriteLine();
        }

        private void GetMakeDataFromFactory(IAbstractFactory factory)
        {
            var headphones = factory.CreateHeadphones();
            var washingMachine = factory.CreateWashingMachine();
            var tv = factory.CreateTv();
            headphones.MakeName();
            washingMachine.MakeName();
            tv.MakeName();
        }
    }
}
