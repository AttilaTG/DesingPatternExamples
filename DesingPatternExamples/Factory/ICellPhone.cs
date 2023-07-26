using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternExamples.Factory
{
    public interface ICellPhone
    {
        void CallNumber(int number);
        void DownloadApps(string appName);
        void MakePhotos();
    }
}
