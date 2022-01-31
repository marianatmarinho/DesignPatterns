﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Example
{
    public class CartaoNaoInseridoState : ICaixaEletronicoState
    {
        public void EjetarCartao()
        {
            Console.WriteLine("Não é possível ejectar o cartão. O cartão não foi inserido.");
        }

        public void InformarSenha()
        {
            Console.WriteLine("Não é possível informar a senha. Insira o cartão.");
        }

        public void InserirCartao()
        {
            Console.WriteLine("Cartão inserido com sucesso.");
        }

        public void sacarDinheiro()
        {
            Console.WriteLine("Não é possível realizar o saque. Insira o cartão.");
        }
    }
}
