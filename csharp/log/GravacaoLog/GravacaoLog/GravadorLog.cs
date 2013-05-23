using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GravacaoLog
{
    class GravadorLog
    {
        public void LogInsert(Interfaces.ILogavel logavel, string nomeUsuario)
        {
            Console.WriteLine("Gravando insert de {0} ({1})", logavel.NomeEntidade, logavel.NomeTabela);
            var ateracoes = logavel.ObterAlteracoes();
            
            foreach (var alteracao in ateracoes)
            {
                Console.WriteLine("\t{0}: {1} -> {2}", alteracao.NomeCampo, alteracao.ValorAntigo, alteracao.ValorNovo);
            }
            Console.WriteLine("Insert realizado por {0}", nomeUsuario);
        }
            
    }
}
