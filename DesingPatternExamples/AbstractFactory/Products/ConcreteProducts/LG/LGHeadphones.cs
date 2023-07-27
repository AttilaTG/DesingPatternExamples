using DesingPatternExamples.AbstractFactory.Products.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.AbstractFactory.Products.ConcreteProducts.LG
{
    public class LGHeadphones : IHeadphones
    {
        public void MakeName()
        {
            Console.WriteLine("LG Headphones");
        }
    }
}
