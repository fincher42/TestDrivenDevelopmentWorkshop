using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDrivenDevelopment
{
    public static class Utilities
    {
        public static string BuildUrl(string host, string name, string value)
        {
            return $"{host}?{HttpUtility.UrlEncode(name)}={HttpUtility.UrlEncode(value)}";
        }

    }
}