﻿using System.Web;
using System.Web.Mvc;

namespace dotnet_MusicStore.Client.Apis
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
