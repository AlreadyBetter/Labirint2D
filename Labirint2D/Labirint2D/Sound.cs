using System.Media;

namespace Labirint2D
{
    public static class Sound
    {
        static SoundPlayer sound_lost = new SoundPlayer(Properties.Resources.lost);
        static SoundPlayer sound_start = new SoundPlayer(Properties.Resources.start);
        static SoundPlayer sound_won = new SoundPlayer(Properties.Resources.won);
        static SoundPlayer sound_keyFound = new SoundPlayer(Properties.Resources.keyFound);
        static bool sound_enabled = true;

        public static void sound_on()
        {
            sound_enabled = true;
        }

        public static void sound_off()
        {
            sound_enabled = false;
        }

        public static void play_lost()
        {
            if (sound_enabled)
                sound_lost.Play();
        }

        public static void play_start()
        {
            if (sound_enabled)
                sound_start.Play();
        }

        public static void play_won()
        {
            if (sound_enabled)
                sound_won.Play();
        }

        public static void play_keyFound()
        {
            if (sound_enabled)
                sound_keyFound.Play();
        }
    }
}
