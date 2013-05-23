using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GravacaoLog.Entidades
{
    partial class Kit:GravacaoLog.Interfaces.ILogavel
    {
        protected List<AlteracaoCampo> _listaAlteracoes = new List<AlteracaoCampo>();

        protected void addAlteracao(string nomeCampo, string valorAntigo, string valorNovo)
        {
            var alteracao = new AlteracaoCampo
            {
                NomeCampo = nomeCampo,
                ValorAntigo = valorAntigo,
                ValorNovo = valorNovo
            };

            _listaAlteracoes.Add(alteracao);
        }


        public string NomeEntidade
        {
            get { return "Kit"; }
        }

        public string NomeTabela
        {
            get { return "CAD_KITS"; }
        }

        public List<AlteracaoCampo> ObterAlteracoes()
        {
            return _listaAlteracoes;
        }


        public void AtualizarAlteracoesCampo(Kit kitOriginal)
        {
            _listaAlteracoes.Clear();
            if (this.Nome != kitOriginal.Nome)
            {
                this.addAlteracao("Nome", kitOriginal.Nome, this.Nome);
            }

            if (this.Id!= kitOriginal.Id)
            {
                this.addAlteracao("Id", kitOriginal.Id.ToString(), this.Id.ToString());
            }

            if (this.Componentes != kitOriginal.Componentes)
            {
                this.addAlteracao("Componentes", kitOriginal.Componentes, this.Componentes);
            }

            if (this.Valor != kitOriginal.Valor)
            {
                this.addAlteracao("Valor", kitOriginal.Valor.ToString(), this.Valor.ToString());
            }
        }

      
    }
}
