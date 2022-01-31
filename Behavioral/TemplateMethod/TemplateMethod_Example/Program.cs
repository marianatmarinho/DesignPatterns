using System;

namespace TemplateMethod_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MKV");
            VideoPlayer videoPlayer = new VideoMKV();
            videoPlayer.CarregarArquivo();
            videoPlayer.DecodeVideoFormato();
            videoPlayer.IniciarExecucao();

            Console.WriteLine("MP4");
            videoPlayer = new VideoMP4();
            videoPlayer.CarregarArquivo();
            videoPlayer.DecodeVideoFormato();
            videoPlayer.IniciarExecucao();
        }
    }
}
