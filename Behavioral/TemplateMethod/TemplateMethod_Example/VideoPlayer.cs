using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_Example
{
    public abstract class VideoPlayer
    {
        public void ExecutarVideo()
        {
            CarregarArquivo();
            DecodeVideoFormato();
            IniciarExecucao();
        }

        public void CarregarArquivo()
        {
            Console.WriteLine("Arquivo de video carregado...\n");
        }

        public abstract void DecodeVideoFormato();
        public void IniciarExecucao()
        {
            Console.WriteLine("O video iniciou a execução...\n");
        }
    }
}
