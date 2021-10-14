using System;

namespace Coding.Exercise{
    public interface IImpressora{
        string Imprimir(string texto);
    }

    public interface ICopiadora{
        string Copiar(string texto);
    }

    public interface IEscaneadora{
        string Escanear(string texto);
    }

    public class Escaneadora : IEscaneadora{
        public string Escanear(string texto){
            return texto;
        }
    }

    public class Multifuncional : IEscaneadora,ICopiadora,IImpressora{
        public string Imprimir(string texto){
            return texto;
        }

        public string Copiar(string texto){
            return texto;
        }

        public string Escanear(string texto){
            return texto;
        }
    }
}