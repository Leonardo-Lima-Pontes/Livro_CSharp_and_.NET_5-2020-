using static System.Console;
using System;
using PacoteBiblioteca.Compartilhado;

namespace PessoaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var leonardo = new Pessoa { Nome = "Leonardo" };
            //var jessica = new Pessoa { Nome = "Jessica" };
            //var camila = new Pessoa { Nome = "Camila" };

            //var bebe = leonardo.ProcriarCom(jessica);
            //bebe.Nome = "Ronaldo";

            //var bebe2 = Pessoa.Procriar(jessica, leonardo);

            //var bebe3 = leonardo * jessica;

            //WriteLine($"{leonardo.Nome} tem {leonardo.Criancas.Count} filhos");
            //WriteLine($"{jessica.Nome} tem {jessica.Criancas.Count} filhos");
            //WriteLine($"{camila.Nome} tem {camila.Criancas.Count} filhos");
            //WriteLine($"O primeiro nome do filho do {leonardo.Nome} é {leonardo.Criancas[0].Nome}");


            //string s1 = "Olá";
            //string s2 = " Mundo";
            //string s3 = string.Concat(s1, s2);
            //WriteLine(s3);

            //string s4 = "Olá";
            //string s5 = " Mundo";
            //string s6 = s4 + s5;
            //WriteLine(s6);

            //WriteLine("O Fatorial de qual numero deseja calcular ? ");
            //int numeroFatorial = int.Parse(ReadLine());
            //WriteLine($"{numeroFatorial}! = {Pessoa.Fatorial(numeroFatorial)}");

            //int primeiraResposta = leonardo.MetodoQueEuQueroChamar("leonardo");
            //WriteLine(primeiraResposta);

            //var odelegate = new DelegateParaMetodoQueEuQueroChamar(leonardo.MetodoQueEuQueroChamar);

            //int segundaResposta = odelegate(leonardo.Nome);
            //WriteLine(segundaResposta);

            //leonardo.Gritar += Leonardo_Grita;
            //leonardo.Cutucar();
            //leonardo.Cutucar();
            //leonardo.Cutucar();
            //leonardo.Cutucar();

            //Pessoa[] pessoas =
            //{
            //    new Pessoa { Nome = "Luciano"},
            //    new Pessoa { Nome = "Lucimar"},
            //    new Pessoa { Nome = "Lucindo"},
            //    new Pessoa { Nome = "Lugano"},
            //    new Pessoa { Nome = "Louco"}
            //};

            //WriteLine("Lista inicial de pessoas");
            //foreach (var pessoa in pessoas)
            //{
            //    WriteLine($"Nome: {pessoa.Nome}");
            //}

            //WriteLine("Utilizando Interface Icomparable");
            //Array.Sort(pessoas);
            //foreach (var pessoa in pessoas)
            //{
            //    WriteLine($"Nome: {pessoa.Nome}");
            //}

            //WriteLine("Utilizando Interface Icomparer");
            //Array.Sort(pessoas, new CompararPessoa());
            //foreach (var pessoa in pessoas)
            //{
            //    WriteLine($"Nome: {pessoa.Nome}");
            //}

            var t1 = new Coisa();
            t1.Dado = "maça";
            WriteLine($"Coisa com um tipo inteiro {t1.Processo("maça")}");

            var t2 = new Coisa();
            t2.Dado = 42;
            WriteLine($"Coisa com um tipo inteiro {t2.Processo(42)}");

            var t3 = new CoisaGenerica<int>();
            t3.Dado = 42;
            WriteLine($"Coisa com um tipo inteiro {t3.Processo(42)}");

            var t4 = new CoisaGenerica<string>();
            t4.Dado = "maça";
            WriteLine($"Coisa com um tipo inteiro {t4.Processo("maça")}");
        }

        private static void Leonardo_Grita(object sender, EventArgs e)
        {
            Pessoa p = (Pessoa)sender;
            WriteLine($"{p.Nome} está nervoso no nivel: {p.NivelAnjo} FUDEU!!!");
        }

        delegate int DelegateParaMetodoQueEuQueroChamar(string letras);
        
    }
}
