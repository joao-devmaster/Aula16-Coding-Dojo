﻿using System;

namespace Aula19CodingDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            IngressoVip bilhete = new IngressoVip();
            bilhete.ValorIngresso = 20f;
            bilhete.Adicional = 15.0f;
            bilhete.ImprimirValor();
            bilhete.ImprimirValorVIP();
            System.Console.WriteLine();
            System.Console.WriteLine($"A diferença é {bilhete.Adicional}");
        }
    }
}
