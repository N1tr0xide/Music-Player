using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Music_Player
{
    public static class AudioPlayer
    {
        static MediaPlayer player = new MediaPlayer();
        static bool isPlaying;
        
        public static void PlayAudio()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (ofd.ShowDialog() == true)
            {
                player.Open(new Uri(ofd.FileName));
                player.Play();
                isPlaying = true;
            }
        }

        public static void PauseAudio() 
        {
            if(isPlaying)
            {
                player.Pause();
                isPlaying = false;
                return;
            }

            player.Play();
            isPlaying= true;
        }
    }
}
