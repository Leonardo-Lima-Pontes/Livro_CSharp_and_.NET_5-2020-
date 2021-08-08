using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacoteBiblioteca.Compartilhado
{
    public interface IJogavel
    {
        void Jogar();

        void Pausar();

        void Parar()
        {
            WriteLine("PAROU!");
        }
    }
}
