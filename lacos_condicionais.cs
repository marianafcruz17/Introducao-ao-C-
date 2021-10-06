using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais{
    class Program{
        static void Main(string[] args){
            //laço if/else
            int hora = 16;

            if(hora<=15)
                Console.WriteLine("São menos que 15hrs!");
            else if(hora<=17)
                Console.WriteLine("A hora é menor ou igual a 17!");
            else{
                Console.WriteLine("Já passou das 17hrs!");

                if(hora==18)
                    Console.WriteLine("São 18hrs!");
                else
                    Console.WriteLine("Já passou das 18hrs!");
            }

            //laço switch
            switch(hora){
                case 15:
                    Console.WriteLine("São 15hrs!");
                    break;
                case 13:
                    Console.WriteLine("São 13hrs!");
                    break;
                case 18:
                    Console.WriteLine("São 18hrs!");
                    break;
                default:
                    Console.WriteLine("Hora indefinida!");
                    break;
            }

            Ano mes = Ano.Maio;

            /*if(mes==Ano.Janeiro)
                Console.WriteLine("Estamos em Janeiro");
            else if(mes==Ano.Fevereiro)
                Console.WriteLine("Estamos em Fevereiro");*/

            switch(mes){
                case Ano.Janeiro:
                    Console.WriteLine("Estamos em Janeiro");
                    break;
                case Ano.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro");
                    break;
                case Ano.Marco:
                    Console.WriteLine("Estamos em Marco");
                    break;
                case Ano.Abril:
                    Console.WriteLine("Estamos em Abril");
                    break;
                case Ano.Maio:
                    Console.WriteLine("Estamos em Maio");
                    break;
                case Ano.Junho:
                    Console.WriteLine("Estamos em Junho");
                    break;
                default:
                    Console.WriteLine("Estamos no Segundo Semestre");
                    break;
            }
        }
    }

    public enum Ano{
        Janeiro, Fevereiro, Marco, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro;
    }
}