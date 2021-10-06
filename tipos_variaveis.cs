using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

//Pasta lógica
namespace TiposVariaveis{
	class Program{
		static void Main(string[],args){
            int numero1 = 10;
            int numero2 = 20;
            //o var define dinâmicamente o tipo de variável
            var some = numero1 + numero2;

            Console.WriteLine("10 + 20 = ",soma);

            //copia o valor da variável numero1
            int copia_numero1 = numero1;
            //será que o valor numero1 foi alterado?
            copia_numero1 = 11;

            Console.WriteLine("Numero1: ",numero1);
            Console.WriteLine("Copia numero1: ",copia_numero1);

            //cria o quadrado
            var quadrado1 = new Quadrado();
            //quadrado1 terá valor de lado = 10
            quadrado1.lado = 10;
            var quadrado2 = quadrado1;
            //ao alterar o quadrado2, também está alterando o quadrado1, pois ambas apontam para o mesmo lugar
            quadrado2.lado = 11;

            Console.WriteLine("quadrado1: ",quadrado1.lado);
            Console.WriteLine("quadrado2: ",quadrado2.lado);
		}

        //define uma classe chamada Quadrado
        class Quadrado{
            //define um atributo inteiro chamado lado, na classe Quadrado
            int lado;

        }
	}
}