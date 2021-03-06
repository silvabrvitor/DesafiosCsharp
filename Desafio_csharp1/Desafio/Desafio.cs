﻿using System;

namespace Desafio
{
    class Desafio {
        static void Main() {
            Console.WriteLine("Digite um número limite para entrada de dados:");
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++) 
            {
                Console.WriteLine("Digite dois números separados por espaço:");
                string[] line = Console.ReadLine().Split(" ");
                if (line.Length < 2) {
                    Console.WriteLine("divisao impossivel");
                    break;
                }
                if (line[1] == "") {
                    Console.WriteLine("divisao impossivel");
                    break;
                }
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                
                if (Y == 0) {
                    Console.WriteLine("divisao impossivel");
                } else {
                    double divisao = (double)X / Y; 
                    if(divisao < 0 && (divisao.ToString("N1") == "0.0"))
                    {
                      Console.WriteLine("-0.0");
                    }
                    else
                    {
                      Console.WriteLine(divisao.ToString("N1"));
                    }
                }
            }
        }
    }
}
