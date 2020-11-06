using Locadora.Filmes.Web.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Filme
{
    public class FilmeViewModel
    {
        [Required(ErrorMessage = "O Id é obrigatório")]
        public long IdFilme { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome do Filme")]
        public string NomeFilme { get; set; }

        [Required(ErrorMessage = "Selecione um album")]
        [Display(Name = "Álbum")]
        public int IdAlbum { get; set; }
    }
}