using System;

namespace Task3
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop()
        {
            Console.WriteLine("Test");
        }
    }

    internal class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Playing started");
        }
        public void Record()
        {
            Console.WriteLine("Recording started");
        }
        public void Pause()
        {
            Console.WriteLine("Pause for both IPlayable and IRecordable");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop playing");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Stop recording");
        }
    }

    internal class Program
    {
        public static void PlayActions(IPlayable player)
        {
            player.Play();
            player.Pause();
            player.Stop();
        }

        public static void RecordActions(IRecordable player)
        {
            player.Record();
            player.Pause();
            player.Stop();
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            string line = new string('-', Console.WindowWidth);

            RecordActions(player);
            Console.WriteLine(line);

            PlayActions(player);
        }
    }
}
