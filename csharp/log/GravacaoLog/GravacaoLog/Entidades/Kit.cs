using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GravacaoLog.Entidades
{
    partial class Kit:IDisposable
    {
        public int Id { get; set; }
        public string Nome {get; set; }
        public string Componentes { get; set; }
        public decimal Valor { get; set; }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
