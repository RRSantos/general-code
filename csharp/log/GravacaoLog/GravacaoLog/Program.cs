using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GravacaoLog.Entidades;

namespace GravacaoLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var kitOriginal = new Kit
            {
                Componentes = "Shampoo, Sabonete, Pente, Toalha",
                Id = 1,
                Nome = "Kit banho",
                Valor = 123.65m
            };

            var kitAlterado = new Kit
            {
                Componentes = "Shampoo, Sabonete, Pente, Toalha, Creme dental, Escova de dentes",
                Id = 1,
                Nome = "Kit higiene",
                Valor = 199.90m
            };

            kitAlterado.AtualizarAlteracoesCampo(kitOriginal);

            var meuLog = new GravadorLog();
            Console.WriteLine("Antes de gravar log...");
            meuLog.LogInsert(kitAlterado, "RRamos");

            Console.ReadKey();



        }
    }
}
