using static System.Console;
using System;
using System.Xml.Linq;
using BibliotecaCompartilhada;

namespace AssembliesENamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //var doc = new XDocument();

            Write("Enter a color value in hex: ");
            string hex = ReadLine();
            WriteLine("Is {0} a valid color value? {1}",
             arg0: hex, arg1: hex.ValdidaHex());
            Write("Enter a XML element: ");
            string xmlTag = ReadLine();
            WriteLine("Is {0} a valid XML element? {1}",
             arg0: xmlTag, arg1: xmlTag.ValidaTagXml());
            Write("Enter a password: ");
            string password = ReadLine();
            WriteLine("Is {0} a valid password? {1}",
             arg0: password, arg1: password.ValidaSenha());
        }
    }
}
