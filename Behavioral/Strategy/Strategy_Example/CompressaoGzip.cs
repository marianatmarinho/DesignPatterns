﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Example
{
    public class CompressaoGzip : ICompressao
    {
        public void ComprimirArquiv(string nomeArquivo)
        {
            Console.WriteLine($"\nO arquivo {nomeArquivo} foi compactado usando GZip.");

        }
    }
}
