using DesingPatternExamples.AbstractFactory.Products.AbstractProducts;
using DesingPatternExamples.AbstractFactory.Products.ConcreteProducts.Sony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.AbstractFactory.Factories
{
    public class SonyFactory : IAbstractFactory
    {
        public IHeadphones CreateHeadphones()
        {
            return new SonyHeadphones();
        }

        public ITV CreateTv()
        {
            return new SonyTv();
        }

        public IWashingMachine CreateWashingMachine()
        {
            return new SonyWashingMachine();
        }
    }
}
