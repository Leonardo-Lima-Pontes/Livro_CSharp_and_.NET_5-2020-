using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacoteBiblioteca.Compartilhado
{
    public class Coisa
    {
        public object Dado = default(object);

        public string Processo(object entrada)
        {
            if (Dado == entrada)
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
