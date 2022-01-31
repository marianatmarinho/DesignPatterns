using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Example
{
    public class CompressaoContext
    {
        private ICompressao compressao;

        public CompressaoContext(ICompressao compressao)
        {
            this.compressao = compressao;
        }

        public void DefineStrategy(ICompressao compressao)
        {
            this.compressao = compressao;
        }

        public void CriarArquivoCompactado(string nomeArquivo)
        {
            compressao.ComprimirArquiv(nomeArquivo);
        }
    }
}
