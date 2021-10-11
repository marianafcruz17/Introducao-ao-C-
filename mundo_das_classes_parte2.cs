using System;
using System.Collections.Generic;
using System.Linq;;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte2{

    class Program{
        static void Main(string[] args){
            var c = new Cachorro("Dudu",9);
            var g = new Gato("Malu",1);

            //Polimofismo: o gato também é um animal (o objeto tem mais de uma forma)
            Animal a = new Gato("Felix",5);

            exibeAnimal(c);
            exibeAnimal(g);
            exibeAnimal(a);
        }

        public static void exibeAnimal(Animal animal){
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Idade: {animal.Idade}");
            Console.WriteLine($"Som emitido: {animal.SomEmitido}");
            Console.WriteLine($"Locomoção: {animal.Locomocao}");
            Console.WriteLine($"-------------------------------");
        }
    }

    public abstract class Animal{
        public string Nome{get;}
        public int Idade{get;}
        public abstract Som SomEmitido{get;}
        public virtual string Locomocao{get{return "Está andando";}} //Pode ser sobre-escrita nas classes filhas

        public Animal(string nome, int idade){
            Nome = nome;
            Idade = idade;
        }
    }

    public class Cachorro:Animal{
        
        public Cachorro(string nome, int idade):base(nome,idade){
        }

        override Som SomEmitido => Som.Latido;
    }

    public class Gato:Animal{

        public Gato(string nome, int idade):base(nome,idade){
        }

        override Som SomEmitido => Som.Miado;
        override Locomocao => "Está pulando";
    }

    public enum Som{
        Latido,
        Miado,
        Rugido;
    }
}
