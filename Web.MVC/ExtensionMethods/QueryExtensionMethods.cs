using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Entities.EnType;

namespace Web.MVC.ExtensionMethods
{
    public static class QueryExtensionMethods
    {
        public static string GetParamString(this IQueryCollection query, string param)
        {
            string ret = "";
            if (!string.IsNullOrEmpty(query[param]))
                ret = query[param].ToString();
            return ret;
        }
        public static int GetParamInt(this IQueryCollection query, string param)
        {
            int ret = 0;
            if (!string.IsNullOrEmpty(query[param]))
                ret = int.Parse(query[param].ToString());
            return ret;
        }

    }
}
