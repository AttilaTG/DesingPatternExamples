using DesingPatternExamples.AbstractFactory.Products.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.AbstractFactory.Products.ConcreteProducts.Sony
{
    public class SonyWashingMachine : IWashingMachine
    {
        public void MakeName()
        {
            Console.WriteLine("Sony Washing machine");
        }
    }
}
