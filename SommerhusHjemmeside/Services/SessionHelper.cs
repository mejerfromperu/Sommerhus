﻿using System.Text.Json;

namespace SommerhusHjemmeside.Services
{
    public class SessionHelper
    {

        // henter et objekt af typen T fra session
        public static T Get<T>(HttpContext context)
        {
            String sessionName = typeof(T).Name;
            String? s = context.Session.GetString(sessionName);
            if (string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentException($"No session value for {sessionName}");
            }
            return JsonSerializer.Deserialize<T>(s);
        }
        // gemmer et objekt af typen T i session
        public static void Set<T>(T t, HttpContext context)
        {
            String sessionName = typeof(T).FullName;
            String s = JsonSerializer.Serialize(t);
            context.Session.SetString(sessionName, s);
        }
        // fjerner et objekt af type T fra session
        public static void Clear<T>(HttpContext context)
        {
            context.Session.Remove(typeof(T).Name);
        }

    }
}
