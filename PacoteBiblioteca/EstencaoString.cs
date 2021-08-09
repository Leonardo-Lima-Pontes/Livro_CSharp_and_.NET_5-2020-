using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PacoteBiblioteca.Compartilhado
{
    public static class EstencaoString
    {
        public static bool ValidarEmail(this string entrada)
        {
            return Regex.IsMatch(entrada,
            @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }

    }
}
