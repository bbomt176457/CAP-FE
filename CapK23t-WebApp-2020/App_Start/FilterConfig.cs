﻿using System.Web;
using System.Web.Mvc;

namespace CapK23t_WebApp_2020
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
