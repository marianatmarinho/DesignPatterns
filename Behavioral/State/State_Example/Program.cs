using System;

namespace State_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            CaixaEletronico caixa = new CaixaEletronico();
            Console.WriteLine("Estado atual do caixa eletronico: " + caixa.caixaEletronicoState.GetType().Name);
            Console.WriteLine();
            caixa.InformarSenha();
            caixa.sacarDinheiro();
            caixa.EjetarCartao();
            caixa.InserirCartao();
            Console.WriteLine();

            Console.WriteLine("Estado atual do caixa eletronico: " + caixa.caixaEletronicoState.GetType().Name);
            caixa.InformarSenha();
            caixa.sacarDinheiro();
            caixa.InserirCartao();
            caixa.EjetarCartao();
            Console.WriteLine("Estado atual do caixa eletronico: " + caixa.caixaEletronicoState.GetType().Name);

            Console.ReadKey();
        }
    }
}
