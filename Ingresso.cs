using System;
namespace Aula19CodingDojo
{
    public class Ingresso
    {
        public float ValorIngresso { get;set; }

        public void ImprimirValor(){
            System.Console.WriteLine($"O valor do ingresso é R${ValorIngresso} (valor refente somente a entrada)");
        }
    }
} 