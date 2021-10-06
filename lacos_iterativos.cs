using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace LacosIterativos{
    class Program{
        static void Main(string[] args){
            //laço for
            for(int i=0;i<5;i++){
                Console.WriteLine("Valor de i é " + i);
            }

            //laço while
            int contador = 3;

            while(contador<10){
                Console.WriteLine(contador);
                contador++;
            }

            //laço do...while -> execução garantida, pelo menos 1 vez, pois executa o bloco primeiro e depois testa
            double j = 10;

            do{
                Console.WriteLine(j);
                j = j*1.5;
            }while(j<100);

            //laço foreach -> pecorre todos os elementos de um conjunto
            int[] conjunto = {1,2,3,4};

            foreach(int numero in conjunto){
                Console.WriteLine("Esse elemento do conjunto tem valor " + numero + "! Somando esse valor a 10 temos " + (numero+10));
            }
        }
    }
}