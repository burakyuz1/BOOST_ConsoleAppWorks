using _02PhoneSoundsApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace _02PhoneSoundsApp.Concrete
{
    public class BasePhone : IPlaySound
    {
        public BasePhone()
        {
            player = new SoundPlayer(soundPath);
        }
        public BasePhone(string path)
        {
            player = new SoundPlayer(soundPath);
        }
        private SoundPlayer player;
        protected string soundPath = Environment.CurrentDirectory.Replace("\\bin\\Debug", "\\Resources\\default.wav");
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }

        public void PlaySound()
        {
            player.Play();
        }

        public void StopSound()
        {
            player.Stop();
        }
    }
}
