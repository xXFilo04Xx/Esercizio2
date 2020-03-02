﻿using Libreria_Es_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEs2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("inserisci un numero");
                double n = double.Parse(Console.ReadLine());
                int n1;
                if (Utilità.VerificaIntero(n))
                {
                    Console.WriteLine("il numero è intero");
                    n1 = (int)n;
                }
                else
                {
                    Console.WriteLine("il numero non è intero");
                    n1 = Utilità.Arrotonda(n);
                }
                if (Utilità.PariDispari(n1))
                {
                    Console.WriteLine("il numero è pari");
                }
                else
                {
                    Console.WriteLine("il numero è dispari");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("devi inserire un numero", e.Message);
            }
            Console.ReadLine();
        }
    }
}