using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tier.Entities.EnType;

namespace Web.MVC.ExtensionMethods
{
    public static class SessionExtensionMethods
    {
        public static void SetObject(this ISession session, SessionType key, object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key.ToString(), objectString);
        }

        public static T GetObject<T>(this ISession session, SessionType key) where T : class
        {
            string objectString = session.GetString(key.ToString());
            if (string.IsNullOrEmpty(objectString))
                return null;

            T value = JsonConvert.DeserializeObject<T>(objectString);
            return value;
        }
    }
}
