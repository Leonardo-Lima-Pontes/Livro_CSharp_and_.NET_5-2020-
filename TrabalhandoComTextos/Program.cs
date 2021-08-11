using static System.Console;
using System;

namespace TrabalhandoComTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "LeonardoLimaPontes";
            WriteLine($"{nome} tem {nome.Length} letras!");
            WriteLine($"a primeira letra é {nome[0]}, e a oitava é tem {nome[7]} letras!");
            ReadKey();

            string cidades = "São Paulo, Rio de Janeiro, Jales, Campo Grande";

            string[] cidadesArray = cidades.Split(',');
            foreach (var cidade in cidadesArray)
            {
                WriteLine(cidade);
            }
            ReadKey();

            string jessica = "Jessica Graciele";
            int espaco = jessica.IndexOf(" ");
            string jessicaPrimeroNome = jessica.Substring(0, espaco);
            string jessicaSegundoNome = jessica.Substring(espaco + 1);
            WriteLine($"O nome completo é: {jessica}");
            WriteLine($"O primero nome é: {jessicaPrimeroNome}");
            WriteLine($"O segundo nome é: {jessicaSegundoNome}");
            WriteLine($"O nome completo ao contrario é: {jessicaSegundoNome} {jessicaPrimeroNome}");
            ReadKey();

            string empresa = "SistemasBR";
            bool comecaCom = empresa.StartsWith("S");
            bool terminaCom = empresa.StartsWith("B");

            WriteLine($"{empresa} começa com S: {comecaCom} e termina com B: {terminaCom}");
            ReadKey();

            string combinado = string.Join(" X ", cidadesArray);
            WriteLine(combinado);
            ReadKey();

        }
    }
}
