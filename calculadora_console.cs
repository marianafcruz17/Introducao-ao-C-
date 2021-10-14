using ModuloCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraConsole{
    class Program{
        static void Main(string[] args){
            var continuar = true;

            while(continuar){
                double resultado = 0;

                Console.WriteLine("Escolha a operação: \n1- Soma \n2- Subtração \n3- Multiplicação \n4- Divisão");
                //ler a opcao do usuario
                var operacao = Console.ReadLine();

                Console.Write("Digite um número: ");
                var numero1 = double.Parse(Console.ReadLine());

                Console.Write("Digite outro número: ");
                var numero2 = double.Parse(Console.ReadLine());

                //Realiza a operação escolhida pelo usuario
                if(operacao=="1")
                    resultado = OperacoesAritmeticas.Adicao(numero1,numero2);
                else if(operacao=="2")
                    resultado = OperacoesAritmeticas.Subtracao(numero1,numero2);
                else if(operacao=="3")
                    resultado = OperacoesAritmeticas.Multiplicacao(numero1,numero2);
                else if(operacao=="4")
                    resultado = OperacoesAritmeticas.Divisao(numero1,numero2);
                else
                    Console.WriteLine("Opção inválida. Por favor, tente novamente.");

                Console.WriteLine("Resultado: " + resultado);
                Console.WriteLine();
                Console.Write("Deseja continuar? S/N");

                if(Console.ReadLine()=="N")
                    continuar = false;
                else
                    Console.WriteLine();
            }
        }
    }
}