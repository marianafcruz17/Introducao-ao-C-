using System;
using System.Collections.Generic;
using System.Linq;;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte1{
    //sem modificador de acesso explícito = internal por padrão
    class Program{
        static void Main(string[] args){
            //criando carro
            Carro carro = new Carro(Cor.Branco, 4, "Gol G6");
            Console.WriteLine("O carro é um " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas + " portas");


            Console.WriteLine(carro.Ligar());
            Console.WriteLine("Ligado? " + carro.Ligado);
            Console.WriteLine(carro.Andar());
            Console.WriteLine(carro.Desligar());
            Console.WriteLine("Desligado? " + carro.Ligado);
        }
    }

    public class Carro{
        //atributos
        public Cor Cor{get;};
        public int Portas{get;};
        public string Modelo{get;};
        //só a classe Carro tem acesso
        private bool ligado = false; 

        //propriedade: define uma maneira de acessar atributos

        
        public bool Ligado{
            //retornar valor
            get{
                return ligado;
            }
        }

        //método construtor da classe
        public Carro(Cor cor, int portas, string modelo){
            Cor = cor;
            Portas = portas;
            Modelo = modelo;
        }

        //métodos
        public string Ligar(){
            Ligado = true;
            return "O carro foi ligado";
        }

        public string Desligar(){
            Ligado = false;
            return "O carro foi desligado";
        }

        public string Andar(){
            return "O carro está andando";
        }
    }

    public enum Cor{
        Preto;
        Branco;
        Prata;
        Vermelho;
    }
}