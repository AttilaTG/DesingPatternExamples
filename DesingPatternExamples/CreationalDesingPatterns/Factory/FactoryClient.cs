using DesingPatternExamples.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.CreationalDesingPatterns.Factory
{
    public class FactoryClient
    {
        public void Demo() 
        {
            CellPhoneFactory factory = new();
            CreateProduct(factory, "android");
            CreateProduct(factory, "ios");
            CreateProduct(factory, "notValidOption");

            Console.WriteLine();
        }

        private void CreateProduct(CellPhoneFactory factory, string os)
        {
            ICellPhone myNewPhone = factory.CreateCellPhone(os);
            myNewPhone?.DownloadApps("Whatsapp");
            myNewPhone?.CallNumber(123456);
            myNewPhone?.MakePhotos();
        }
    }
}
