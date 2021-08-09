using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacoteBiblioteca.Compartilhado
{
    public struct VetorDeslocamento
    {
        public int X;
        public int Y;

        public VetorDeslocamento(int inicialX, int inicialY)
        {
            X = inicialX;
            Y = inicialY;
        }

        public static VetorDeslocamento operator +(VetorDeslocamento vetor1, VetorDeslocamento vetor2)
        {
            return new VetorDeslocamento(vetor1.X + vetor2.X, vetor1.Y + vetor2.Y);
        }
    }
}
