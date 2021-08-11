using System;
using System.Collections.Generic;

namespace TrabalhandoComListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cidades = new List<string>();
            cidades.Add("Rio de Janeiro");
            cidades.Add("Bahia");
            cidades.Add("São Paulo");

            foreach (var cidade in cidades)
            {
                Console.WriteLine(cidade);
            }

            Console.WriteLine("\n\n\n\n");

            Console.WriteLine($"Primeira cidade: {cidades[0]}");
            Console.WriteLine($"Ultima cidade: {cidades[2]}");

            cidades.Insert(0, "Santa Catarina");

            foreach (var cidade in cidades)
            {
                Console.WriteLine(cidade);
            }

            Console.WriteLine("\n\n\n\n");

            cidades.RemoveAt(1);
            cidades.Remove("Bahia");

            foreach (var cidade in cidades)
            {
                Console.WriteLine(cidade);
            }

            Console.WriteLine("\n\n\n\n");
        }
    }
}
