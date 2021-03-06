using System;

namespace Biblioteca
{
    public class Livro : Base
    {
        private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
        private string Autor {get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}

        public Livro (int id, Genero genero, string titulo, string descricao, string autor, int ano)
		{
            this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
            this.Autor = autor;
			this.Ano = ano;
            this.Excluido = false;
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Autor: " + this.Autor + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() 
        {
            this.Excluido = true;
        }
    }
}