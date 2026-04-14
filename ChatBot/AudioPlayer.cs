using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Media;
using System.IO;

namespace ChatBot
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            string path = "Greeting.wav";

            if (File.Exists(path))
            {
                SoundPlayer player = new SoundPlayer(path);
                player.Play();
            }
        }
    }
}