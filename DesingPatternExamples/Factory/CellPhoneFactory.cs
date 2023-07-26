using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesingPatternExamples.Factory.Phones;

namespace DesingPatternExamples.Factory
{
    public class CellPhoneFactory
    {
        public ICellPhone? CreateCellPhone(string operatingSystem)
        {
            switch (operatingSystem.ToLower())
            {
                case "android":
                    return new Android();
                case "ios":
                    return new IOS();
                default:
                    Console.WriteLine("Wrogn phone");
                    return null;
            }
        }
    }
}
