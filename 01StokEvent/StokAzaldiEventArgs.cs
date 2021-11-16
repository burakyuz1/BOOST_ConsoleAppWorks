using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01StokEvent
{
    public class StokAzaldiEventArgs : EventArgs
    {
        public StokAzaldiEventArgs(DateTime dt)
        {
            Dt = dt;
        }

        public DateTime Dt { get; }
    }
}
