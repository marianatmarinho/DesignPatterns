using ExampleBridge.Platforms;
using ExampleBridge.Transmissions;
using System;

namespace ExampleBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            StartLive(new Youtube());
            StartAdvancedLive(new Facebook());
            StartRecordLive(new DLive());

            Console.ReadLine();
        }

        static void StartLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde... ");

            Live live = new Live(platform);

            live.Broadcasting();
            live.Result();
        }

        static void StartAdvancedLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde... ");

            AdvancedLive live = new AdvancedLive(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Result();
        }

        static void StartRecordLive(IPlatform platform)
        {
            Console.WriteLine("Aguarde... ");

            RecordLive live = new RecordLive(platform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Record();
            live.Result();
        }
    }
}
