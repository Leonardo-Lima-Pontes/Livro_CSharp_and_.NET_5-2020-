using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BibliotecaCompartilhada
{
    public static class StringExtentions
    {
        public static bool ValidaTagXml(this string entrada)
        {
            return Regex.IsMatch(entrada, @"^<([a-z]+)([^<]+)*(?:>(.*)<\/\1>|\s+\/>)$");
        }

        public static bool ValidaSenha(this string entrada)
        {
            return Regex.IsMatch(entrada, "^[a-zA-Z0-9_-]{8,}$");
        }

        public static bool ValdidaHex(this string entrada)
        {
            return Regex.IsMatch(entrada, "^#?([a-fA-F0-9]{3}|[a-fA-F0-9]{6})$");
        }
    }
}
