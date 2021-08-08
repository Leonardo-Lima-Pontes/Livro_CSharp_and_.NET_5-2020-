using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacoteBiblioteca.Compartilhado
{
    public class CompararPessoa : IComparer<Pessoa>
    {
        public int Compare(Pessoa x, Pessoa y)
        {
            int resultado = x.Nome.Length.CompareTo(y.Nome.Length);

            if (resultado == 0)
            {
                return x.Nome.CompareTo(y.Nome);
            }
            else
            {
                return resultado;
            }
        }
    }
}
