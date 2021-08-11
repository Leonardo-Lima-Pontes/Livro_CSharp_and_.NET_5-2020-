using static System.Console;
using System;
using System.Text.RegularExpressions;

namespace TrabalhandoComExpressoesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a sua idade ?");
            string idade = Console.ReadLine();

            var checarIdade = new Regex(@"^\d+$");

            if (checarIdade.IsMatch(idade))
            {
                Console.WriteLine("Obrigado");
            }
            else
            {
                Console.WriteLine($"Esta não é uma idade valida: {idade}");
            }

            string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and TwoSmoking Barrels\"";
            string[] filmsDumb = films.Split(',');
            WriteLine("Dumb attempt at splitting:");
            foreach (string film in filmsDumb)
            {
                WriteLine(film);
            }
            ReadKey();

            var csv = new Regex("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
            MatchCollection filmsSmart = csv.Matches(films);
            WriteLine("Smart attempt at splitting:");
            foreach (Match film in filmsSmart)
            {
                WriteLine(film.Groups[2].Value);
            }
            ReadKey();
        }
    }
}
