﻿using Locadora.Filmes.Web.Filtros;
using System.Web;
using System.Web.Mvc;

namespace Locadora.Filmes.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogActionFilter());
        }
    }
}
