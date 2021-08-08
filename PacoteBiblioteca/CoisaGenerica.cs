using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacoteBiblioteca.Compartilhado
{
    public class CoisaGenerica<T> where T : IComparable
    {
        public T Dado = default(T);

        public string Processo(T entrada)
        {
            if (Dado.CompareTo(entrada) == 0)
            {
                return "Dado e entrada são iguais";
            }
            else
            {
                return "Dado e entrada NÃO são iguais";
            }
        }
    }
}
