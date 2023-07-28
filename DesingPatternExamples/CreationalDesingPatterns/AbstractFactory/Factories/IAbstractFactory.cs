using DesingPatternExamples.AbstractFactory.Products.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.AbstractFactory.Factories
{
    public interface IAbstractFactory
    {
        IWashingMachine CreateWashingMachine();
        ITV CreateTv();
        IHeadphones CreateHeadphones();
    }
}
