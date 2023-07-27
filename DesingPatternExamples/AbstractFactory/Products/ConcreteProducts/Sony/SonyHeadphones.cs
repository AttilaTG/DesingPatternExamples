using DesingPatternExamples.AbstractFactory.Products.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.AbstractFactory.Products.ConcreteProducts.Sony
{
    public class SonyHeadphones : IHeadphones
    {
        public void MakeName()
        {
            Console.WriteLine("Sony Headphones");
        }
    }
}
