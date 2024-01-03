using System;
using System.Windows.Media;

namespace SNAKEGAME
{
    internal class Audio
    {
        public readonly static MediaPlayer Dewy = LoadAudio("DRoses.mp3", true, true);
        public readonly static MediaPlayer Unravel = LoadAudio("Unravel.mp3");

        public static MediaPlayer LoadAudio(string filename, bool Repeat = false, bool autoReset = true)
        {
            MediaPlayer player = new();
            player.Open(new Uri($"Assets/{filename}", UriKind.Relative));

            if (autoReset == true)
            {
                player.MediaEnded += Player_MediaEnded;
            }

            if (Repeat == true)
            {
                player.MediaEnded += PlayerRepeat_MediaEnded;
            }
            return player;
        }

        private static void PlayerRepeat_MediaEnded (object sender, EventArgs e)
        {
            MediaPlayer m = sender as MediaPlayer;
            m.Position = new TimeSpan(0);
            m.Play();
        }

        private static void Player_MediaEnded (object sender, EventArgs e)
        {
            MediaPlayer m = sender as MediaPlayer;
            m.Stop();
            m.Position = new TimeSpan(0);
        }
    }
}
