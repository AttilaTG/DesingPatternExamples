using DesingPatternExamples.AbstractFactory.Products.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.AbstractFactory.Products.ConcreteProducts.Samsung
{
    public class SamsungHeadphones : IHeadphones
    {
        public void MakeName()
        {
            Console.WriteLine("Samsung Headphones");
        }
    }
}
