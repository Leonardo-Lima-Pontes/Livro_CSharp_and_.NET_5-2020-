using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacoteBiblioteca.Compartilhado
{
    class ZeVequeiro : Cantor
    {
        public sealed override void Cantar()
        {
            Console.WriteLine("Quando o som do paredão toca ...");
        }
    }
}
