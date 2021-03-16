using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Auditoriska_2_VP
{
    public class Songs
    {
        public String Name { get; set; }

        public Double Rating { get; set; }

        public int Duration { get; set; }

        public String URL { get; set; }

        public Songs() { }
        
        public Songs(String Name, Double Rating, int Duration, String URL)
        {
            this.Name = Name;
            this.Rating = Rating;
            this.Duration = Duration;
            this.URL = URL; 
        }

        public void playSong()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = this.URL;
            player.controls.play();

        }

       /* public void playVideo()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = this.URL;
            player.controls.p
        }*/

        public override string ToString()
        {
            return string.Format("Name: {0}, Duration: {1}, Rating: {2}, URL: {3}", Name, Rating, Duration, URL);
        }

    }
}
