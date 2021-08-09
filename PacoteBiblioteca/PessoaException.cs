using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacoteBiblioteca.Compartilhado
{
    public class PessoaException : Exception
    {
        public PessoaException() : base() { }

        public PessoaException(string message) : base(message) { }

        public PessoaException(string message, Exception innerException) : base (message, innerException) { }

    }
}
