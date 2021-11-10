using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _02PhoneSoundsApp.Concrete
{
    public class Samsung : BasePhone
    {

        public Samsung()
        {
            player = new SoundPlayer(Environment.CurrentDirectory.Replace("\\bin\\Debug", "\\Resources\\samsung.wav"));
        }
        public Samsung(string path) : base(path)
        {
            
        }
        public override void PlaySound()
        {
            System.Windows.Forms.MessageBox.Show("Samsung çalıyor");
            base.PlaySound();
        }
    }
}
