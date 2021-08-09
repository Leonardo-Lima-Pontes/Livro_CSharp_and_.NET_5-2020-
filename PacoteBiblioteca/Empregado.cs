using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacoteBiblioteca.Compartilhado
{
    public class Empregado : Pessoa
    {
        public int EmpregadoCodigo { get; set; }
        public DateTime DataContratacao { get; set; }

        public new void EscreverParaConsole()
        {
            WriteLine($"Nome: {Nome}\nData de Nascença: {DataDeNascenca:d}\nData de Contratação:{DataContratacao:d} \nCodigo do empregado:{EmpregadoCodigo}");
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\nData de Nascença: {DataDeNascenca:d}\nData de Contratação:{DataContratacao:d} \nCodigo do empregado:{EmpregadoCodigo}";
        }
    }
}
