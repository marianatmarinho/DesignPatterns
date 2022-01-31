using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Example
{
    public class CaixaEletronico : ICaixaEletronicoState
    {
        public ICaixaEletronicoState caixaEletronicoState { get; set; }

        public CaixaEletronico()
        {
            caixaEletronicoState = new CartaoNaoInseridoState();
        }
        public void EjetarCartao()
        {
            caixaEletronicoState.EjetarCartao();
            if(caixaEletronicoState is CartaoInseridoState)
            {
                caixaEletronicoState = new CartaoNaoInseridoState();
                Console.WriteLine("O estado foi alterado para; " + caixaEletronicoState.GetType().Name);
            }
        }

        public void InformarSenha()
        {
            caixaEletronicoState.InformarSenha();
        }

        public void InserirCartao()
        {
            caixaEletronicoState.InserirCartao();
            if(caixaEletronicoState is CartaoNaoInseridoState)
            {
                caixaEletronicoState = new CartaoInseridoState();
                Console.WriteLine("O estado foi alterado para: "+ caixaEletronicoState.GetType().Name);
            }
        }

        public void sacarDinheiro()
        {
            caixaEletronicoState.sacarDinheiro();
        }
    }
}
