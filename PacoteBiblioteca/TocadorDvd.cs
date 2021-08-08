using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacoteBiblioteca.Compartilhado
{
    class TocadorDvd : IJogavel
    {
        public void Jogar()
        {
            WriteLine("O dvd está tocando");
        }

        public void Pausar()
        {
            WriteLine("O dvd pausou por hora");
        }

    }
}
