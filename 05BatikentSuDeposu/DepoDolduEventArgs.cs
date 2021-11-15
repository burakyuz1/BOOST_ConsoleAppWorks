using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BatikentSuDeposu
{
    internal class DepoDolduEventArgs : EventArgs
    {
        public DepoDolduEventArgs(int tasanMiktar)
        {
            TasanMiktar = tasanMiktar;
        }

        public int TasanMiktar { get; }
    }
}
