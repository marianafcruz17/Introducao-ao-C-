using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora{
    //classe estática, que não pode ser instanciada, herder e nem ser herdada, apenas pode conter membros estáticos
    public static class OperacoesAritmeticas{
        public static double Adicao(double parcela1,double parcela2){
            return parcela1 + parcela2;
        }

        public static double Aubtracao(double minuando,double subtraendo){
            return minuando - subtraendo;
        }

        public static double Multiplicacao(double multiplicando,double multiplicador){
            return multiplicando * multiplicador;
        }

        public static double Divisao(double dividendo,double divisor){
            return dividendo/divisor;
        }
    }

    public class Tabuada{
        public int Numero{get;}

        public Tabuado(int numero){
            Numero = numero;
        }

        public string Calcular(int de,int ate){
            var sb = new StringBuilder();

            for(int i=0;i<=ate;i++){
                sb.AppendLine($"{Numero} x {i} = {OperacoesAritmeticas.Multiplicacao(Numero,i)}");
            }

            return sb.ToString
        }
    }
}