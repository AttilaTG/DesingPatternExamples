using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.Factory.Phones
{
    public class IOS : ICellPhone
    {
        public void CallNumber(int number)
        {
            Console.WriteLine("Calling from iPhone: {0}", number);
        }

        public void DownloadApps(string appName)
        {
            Console.WriteLine("AppStore Download: {0}", appName);
        }

        public void MakePhotos()
        {
            Console.WriteLine("Pro iPhone pic");
        }
    }
}
