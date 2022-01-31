using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Example
{
    public interface ICaixaEletronicoState
    {
        void InserirCartao();
        void EjetarCartao();
        void InformarSenha();
        void sacarDinheiro();
    }
}
