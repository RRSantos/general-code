using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GravacaoLog.Interfaces
{
    interface ILogavel
    {
        string NomeEntidade { get; }
        string NomeTabela { get; }
        List<AlteracaoCampo> ObterAlteracoes();

    }
}
