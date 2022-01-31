using System;

namespace Strategy_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            CompressaoContext compressao = new CompressaoContext(new CompressaoRar());
            Console.WriteLine("Informe o nome do arquivo: ");
            var nomeArquivo = Console.ReadLine();

            Console.WriteLine("Informe o tipo de compressão a ser usada: ");
            Console.WriteLine("1 - RAR 2 - ZIP 3 - GZIP");
            var opcao = Convert.ToInt32(Console.ReadLine());

            if(opcao == 2)
            {
                compressao.DefineStrategy(new CompressaoZip());
            }
            else
            {
                compressao.DefineStrategy(new CompressaoGzip());
            }

            compressao.CriarArquivoCompactado(nomeArquivo);

            Console.ReadLine();
        }
    }
}
