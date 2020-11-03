using Locadora.Filmes.Dados.Entity.Context;
using Locadora.Filmes.Dominio;
using Locadora.Repositorios.Comum.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Filmes.Repositorios.Entity
{
    public class FilmesRepositorio : RepositorioGenericoEntity<Filme, int>
    {
        public FilmesRepositorio(FilmeDbContext contexto)
            : base(contexto)
        {

        }
    }
}