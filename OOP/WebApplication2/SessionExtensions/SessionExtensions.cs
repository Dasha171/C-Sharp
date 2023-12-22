using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.SessionExtensions
{

   /*     public static class SessionExtensions
        {
            public static void Set<T>(this ISession session, string key, T value)
            {
                session.SetString(key, JsonSerializer.Serialize(value));
            }

            public static T? Get<T>(this ISession session, string key)
            {
                var value = session.GetString(key);
                var test = value != null ? JsonConvert.DeserializeObject<T>(value) : default;
                var output = value == null ? default(T) : JsonSerializer.Deserialize<T>(value);
                return test;
            }
        }*/
   
}