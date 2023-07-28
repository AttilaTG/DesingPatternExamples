using DesingPatternExamples.AbstractFactory.Products.AbstractProducts;
using DesingPatternExamples.AbstractFactory.Products.ConcreteProducts.LG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.AbstractFactory.Factories
{
    public class LGFactory : IAbstractFactory
    {
        public IHeadphones CreateHeadphones()
        {
            return new LGHeadphones();
        }

        public ITV CreateTv()
        {
            return new LGTv();
        }

        public IWashingMachine CreateWashingMachine()
        {
            return new LGWashingMachine();
        }
    }
}
