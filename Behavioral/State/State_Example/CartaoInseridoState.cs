using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Example
{
    public class CartaoInseridoState : ICaixaEletronicoState
    {
        public void EjetarCartao()
        {
            Console.WriteLine("Cartão ejetado com sucesso.");
        }

        public void InformarSenha()
        {
            Console.WriteLine("Senha inserida com sucesso.");
        }

        public void InserirCartao()
        {
            Console.WriteLine("Operação inválida. O cartão já foi inserido");
        }

        public void sacarDinheiro()
        {
            Console.WriteLine("Saque realizado com sucesso");
        }
    }
}
