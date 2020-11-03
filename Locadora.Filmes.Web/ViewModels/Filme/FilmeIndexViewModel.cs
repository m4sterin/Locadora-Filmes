using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Filme
{
    public class FilmeIndexViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Filme")]
        public string Nome { get; set; }

        [Display(Name = "Álbum")]
        public int IdAlbum { get; set; }
    }
}