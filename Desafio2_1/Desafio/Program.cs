using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] v = new int[3];
            int limit = Convert.ToInt32(Console.ReadLine());
            if (limit > 1 && limit < 1000)
            {
                for (int i = 1; i <= limit; i++)
                {
                
                    v[0] = i;
                    v[1] = v[0] * v[0];
                    v[2] = v[0] * v[1];
                    Console.WriteLine($"{v[0]} {v[1]} {v[2]}");   
                }
            }    

        }
    }
}
