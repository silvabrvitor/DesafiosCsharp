using System;
using System.Linq;
using System.Collections.Generic;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> tiposJoia = new List<string>();
            
            do
            {
                if (!string.IsNullOrWhiteSpace(input))
                {
                tiposJoia.Add(input);
                input = Console.ReadLine();
                }

            }while (!string.IsNullOrWhiteSpace(input));
            int tiposDistintos = tiposJoia.Distinct().Count();
            Console.WriteLine(tiposDistintos);
        }
    }
}
