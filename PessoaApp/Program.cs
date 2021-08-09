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

            //var t1 = new Coisa();
            //t1.Dado = "maça";
            //WriteLine($"Coisa com um tipo inteiro {t1.Processo("maça")}");

            //var t2 = new Coisa();
            //t2.Dado = 42;
            //WriteLine($"Coisa com um tipo inteiro {t2.Processo(42)}");

            //var t3 = new CoisaGenerica<int>();
            //t3.Dado = 42;
            //WriteLine($"Coisa com um tipo inteiro {t3.Processo(42)}");

            //var t4 = new CoisaGenerica<string>();
            //t4.Dado = "maça";
            //WriteLine($"Coisa com um tipo inteiro {t4.Processo("maça")}");

            //string numero1 = "4";

            //WriteLine($"{numero1} ao quadrado é {MaisQuadrado.Quadrado<string>(numero1)}");

            //byte numero2 = 3;

            //WriteLine($"{numero2} ao quadrado é {MaisQuadrado.Quadrado<int>(numero2)}");

            //var dv1 = new VetorDeslocamento(3, 5);
            //var dv2 = new VetorDeslocamento(-2, 7);
            //var dv3 = dv1 + dv2;

            //WriteLine($"({dv1.X}, {dv1.Y} + {dv2.X}, {dv2.Y} = {dv3.X}, {dv3.Y})");

            //Empregado samiraEmpregada = new Empregado
            //{
            //    Nome = "Samira Carolina de Oliveria",
            //    DataDeNascenca = new DateTime(2000, 2, 12),
            //    DataContratacao = DateTime.Now,
            //    EmpregadoCodigo = 1
            //};

            //Pessoa samiraPessoa = samiraEmpregada;


            //if (samiraPessoa is Empregado)
            //{
            //    WriteLine(samiraPessoa);
            //    ReadKey();
            //}

            //Pessoa leonardoPessoa = new Pessoa { Nome = "Leonardo Lima Pontes", DataDeNascenca = new DateTime(1998, 8, 1) };

            ////lança um erro
            //Empregado leonardoEmpregado = (Empregado)leonardoPessoa;
            //WriteLine(leonardoPessoa.ToString());
            //ReadKey();

            //Empregado leonardoComoEmpregado = leonardoPessoa as Empregado;

            //if (leonardoComoEmpregado != null)
            //{
            //    WriteLine(leonardoComoEmpregado.ToString());
            //    ReadKey();
            //}

            //samiraEmpregada.EscreverParaConsole();

            //WriteLine(samiraEmpregada.ToString());

            //try
            //{
            //    samiraEmpregada.ViagemNoTempo(new DateTime(2001, 1, 1));
            //    samiraEmpregada.ViagemNoTempo(new DateTime(1999, 1, 1));
            //}
            //catch (PessoaException ex)
            //{
            //    WriteLine(ex.Message);
            //}

            string email0 = "leonardo@sistemasbr";
            string email1 = "leonardo@sistemasbr.net";
            string email2 = "leonardo";
            string email3 = "leonardo@hotmail.com";

            WriteLine($"{email0} é um email valido: {EstencaoString.ValidarEmail(email0)}");
            WriteLine($"{email1} é um email valido: {EstencaoString.ValidarEmail(email1)}");
            WriteLine($"{email2} é um email valido: {EstencaoString.ValidarEmail(email2)}");
            WriteLine($"{email3} é um email valido: {email3.ValidarEmail()}"); // utilizado com método de extenção

        }

        //private static void Leonardo_Grita(object sender, EventArgs e)
        //{
        //    Pessoa p = (Pessoa)sender;
        //    WriteLine($"{p.Nome} está nervoso no nivel: {p.NivelAnjo} FUDEU!!!");
        //}

        //delegate int DelegateParaMetodoQueEuQueroChamar(string letras);

    }
}
