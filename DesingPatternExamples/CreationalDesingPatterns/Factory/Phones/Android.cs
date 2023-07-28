using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.Factory.Phones
{
    public class Android : ICellPhone
    {
        public void CallNumber(int number)
        {
            Console.WriteLine("Calling from Android: {0}", number);
        }

        public void DownloadApps(string appName)
        {
            Console.WriteLine("PlayStore Download: {0}", appName);
        }

        public void MakePhotos()
        {
            Console.WriteLine("Goofy 'ol Android pic");
        }
    }
}
