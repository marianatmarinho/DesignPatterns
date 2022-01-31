using System;

namespace Proxy_Example
{
    public class SharedFolder : ISharedFolder
    {
        public void ReadWriteOperation()
        {
            Console.WriteLine("### Operação de Leitura e Escrita na pasta compartilhada ###");
        }
    }
}
