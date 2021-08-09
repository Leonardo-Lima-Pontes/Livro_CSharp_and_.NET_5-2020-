using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PacoteBiblioteca.Compartilhado
{
    public static class MaisQuadrado
    {
        public static double Quadrado<T>(T entrada) where T : IConvertible
        {
            double d = entrada.ToDouble(Thread.CurrentThread.CurrentCulture);

            return d * d;
        }
    }
}
