using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PacoteBiblioteca.Compartilhado
{
    public class Pessoa : IComparable<Pessoa>
    {
        public string Nome { get; set; }
        public DateTime DataDeNascenca { get; set; }
        public List<Pessoa> Criancas = new List<Pessoa>();

        public void EscreverParaConsole()
        {
            WriteLine($"{Nome} nasceu em {DataDeNascenca}");
        }

        public static Pessoa Procriar(Pessoa p1, Pessoa p2)
        {
            var bebe = new Pessoa { Nome = $"Bebe da {p1.Nome} e {p2.Nome}" };

            p1.Criancas.Add(bebe);
            p2.Criancas.Add(bebe);

            return bebe;
        }

        public Pessoa ProcriarCom(Pessoa parceiro)
        {
            return Procriar(this, parceiro);
        }

        public static Pessoa operator *(Pessoa p1, Pessoa p2)
        {
            return Pessoa.Procriar(p1, p2);
        }

        //Método que tem uma função local
        public static int Fatorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException($"{nameof(numero)} não ponde ser menor que zero");
            }

            return numeroFatorialLocal(numero);

            int numeroFatorialLocal(int numeroLocal)
            {
                if (numeroLocal < 1) return 1;
                return numeroLocal * numeroFatorialLocal(numeroLocal - 1);
            }
        }

        public int MetodoQueEuQueroChamar(string entrada)
        {
            return entrada.Length;
        }

        public event EventHandler Gritar;

        public int NivelAnjo;

        public void Cutucar()
        {
            NivelAnjo++;

            if (NivelAnjo >= 3)
            {
                if (Gritar != null)
                {
                    Gritar(this, EventArgs.Empty);
                }
            }
            else
            {
                WriteLine("Não está nervoso ..., porém um pouco mais a ponto disto !");
            }
        }

        public int CompareTo(Pessoa other)
        {
            return Nome.CompareTo(other.Nome);
        }

        public void ViagemNoTempo(DateTime when)
        {
            if (when <= DataDeNascenca)
            {
                throw new PessoaException("If you travel back in time to a date earlier than your own birth, then the universe will explode!");
            }
            else
            {
                Console.WriteLine($"Bem vindo a {when:yyyy}!");
            }
        }
    }
}
