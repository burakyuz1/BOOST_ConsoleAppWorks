using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PhoneSoundsApp.Concrete
{
    public class Nokia : BasePhone
    {
        public Nokia()
        {
            base.player = new System.Media.SoundPlayer(Environment.CurrentDirectory.Replace("\\bin\\Debug", "\\Resources\\nokia.wav"));
        }
        public Nokia(string path) : base(path)
        {

        }
        public override void PlaySound()
        {
            System.Windows.Forms.MessageBox.Show("Nokia form açıldıktan sonra çalmaya başlayacak (OVERRIDE FARKI)");
            base.PlaySound();
        }

        public override string ToString()
        {
            return $"{Id}  {Brand}  {UnitPrice}  {Model}";
        }
    }
}
