using _02PhoneSoundsApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PhoneSoundsApp.Concrete
{
    public class Iphone : BasePhone
    {
        public Iphone()
        {
            base.player = new System.Media.SoundPlayer(Environment.CurrentDirectory.Replace("\\bin\\Debug", "\\Resources\\iphone.wav"));
        }
        public Iphone(string path) : base(path)
        {

        }

        public override void PlaySound()
        {
            System.Windows.Forms.MessageBox.Show("iphone ok bastıktan sonra çalmaya başlayacak (OVERRIDE EDİLDİ)");
            base.PlaySound();
        }


    }
}
