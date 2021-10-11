using System;
using System.Collections.Generic;
using System.Linq;;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces{

    class Program{
        static void Main(string[] args){
            var i = new ImpressoraComum();
            var ic = new ImpressoraComum();
            var x = new Xerox();

            Console.WriteLine(i.Imprimir("Estou estudando C#"));
            Console.WriteLine(ic.Imprimir("Estou estudando C# e estou gostando"));
            Console.WriteLine(ic.Copiar("Estou estudando C# e estou gostando"));
        }

        public static void CopiarDocumento(ICopiadora c, string texto){
            Console.WriteLine("Estou copiando o texto a seguir: " + c.Copiar(texto));
        }
    }

    public interface IImpressora{
        string Imprimir(string texto);
    }

    public interface ICopiadora{
        string Copiar(string texto);
    }

    public class ImpressoraComum:IImpressora{
        public string Imprimir(string texto){
            return $"Texto a imprimir: {texto}";
        }
    }

    public class ImpressoraCopiadora:IImpressora, ICopiadora{
        public string Imprimir(string texto){
            return $"Texto a imprimir: {texto}";
        }
        
        public string Copiar(string texto){
            return $"Texto a ser copiado: {texto}";
        }
    }

    public class Xerox:ICopiadora{

        public string Copiar(string texto){
            return $"Texto a ser copiado: {texto}";
        }
    }
}
