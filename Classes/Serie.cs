using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dio_series
{
    public class Serie : EntidadeBase
    {
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
		private bool Excluido { get; set; }

		public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{
			Id = id;
			Genero = genero;
			Titulo = titulo;
			Descricao = descricao;
			Ano = ano;
			Excluido = false;
		}

		public override string ToString()
		{
			return 
			"Gênero: " + Genero + "\n"
			+ "Titulo: " + Titulo + "\n"
			+ "Descrição: " + Descricao + "\n"
			+ "Ano de Início: " + Ano + "\n"
			+ "Excluido: " + Excluido; ;
		}

		public string retornaTitulo()
		{
			return Titulo;
		}

		public int retornaId()
		{
			return Id;
		}
		public bool retornaExcluido()
		{
			return Excluido;
		}
		public void Excluir()
		{
			Excluido = true;
		}
	}
}
