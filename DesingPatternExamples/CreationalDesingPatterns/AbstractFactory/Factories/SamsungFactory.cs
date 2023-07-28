using DesingPatternExamples.AbstractFactory.Products.AbstractProducts;
using DesingPatternExamples.AbstractFactory.Products.ConcreteProducts.Samsung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.AbstractFactory.Factories
{
    public class SamsungFactory : IAbstractFactory
    {
        public IHeadphones CreateHeadphones()
        {
            return new SamsungHeadphones();
        }

        public ITV CreateTv()
        {
            return new SamsungTv();
        }

        public IWashingMachine CreateWashingMachine()
        {
            return new SamsungWashingMachine();
        }
    }
}
