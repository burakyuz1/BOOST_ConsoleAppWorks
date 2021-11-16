using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01StokEvent
{
    public delegate void StokAzaldiEventHandler(object sender, StokAzaldiEventArgs e);
    public class Urun
    {
        public event StokAzaldiEventHandler StokAzaldi;
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal BirimFiyat { get; set; }
        public int StokMiktari { get { return StokMiktari; } set { if (value < 10 && StokAzaldi != null) StokAzaldi(this, new StokAzaldiEventArgs(DateTime.Now)); } }


    }
}
